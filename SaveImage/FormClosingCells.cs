using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SaveImage
{
    public partial class FormClosingCells : Form
    {
        int numberOfRows = 12;
        int numberOfColumns = 8;
        public byte[,] cells;
        public List<int> list_closedCells = new List<int>();

        /*
          cell[i] == 0   -    ячейка не обработана
                  == 1   -    ячейка обработана
                  == 2   -    "закрытое гнездо"
                                                                   */

        public FormClosingCells(List<int> _list_closedCells)
        {
            InitializeComponent();
            load_Cells(_list_closedCells);
        }

        public void load_Cells(List<int> _list_closedCells)
        {
            list_closedCells = _list_closedCells;
            cells = new byte[numberOfColumns, numberOfRows];
            int height = (dataGridView_closedCells.Height - 2) / numberOfRows;

            DataGridViewButtonColumn[] columns = new DataGridViewButtonColumn[numberOfColumns];
            for (int numberColumn = 0; numberColumn <= numberOfColumns - 1; numberColumn++)
            {
                columns[numberColumn] = new DataGridViewButtonColumn();
                dataGridView_closedCells.Columns.Add(columns[numberColumn]);
            }

            for (int numberRow = 0; numberRow < numberOfRows; numberRow++)
            {
                dataGridView_closedCells.Rows.Add();
                dataGridView_closedCells.Rows[numberRow].Height = height;
            }

            int k = 1;

            for (int numberRow = 0; numberRow < numberOfRows; numberRow++)
            {
                for (int numberColumn = 0; numberColumn <= numberOfColumns - 1; numberColumn++)
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridView_closedCells.Rows[numberRow].Cells[numberColumn];
                    buttonCell.Value = k;
                    if (list_closedCells.Any(db => db.Equals(k)))
                    {
                        cells[numberColumn, numberRow] = 2;
                        paintCell(buttonCell);
                    }
                    k++;                  
                }
            }
        }

        private void paintCell(DataGridViewButtonCell buttonCell)
        {
            int value = cells[buttonCell.ColumnIndex, buttonCell.RowIndex];
            switch (value)
            {
                case 0:
                    buttonCell.Style.BackColor = System.Drawing.Color.White;
                    break;
                case 1:
                    buttonCell.Style.BackColor = System.Drawing.Color.Gainsboro;
                    break;
                case 2:
                    buttonCell.Style.BackColor = System.Drawing.Color.DarkGray;
                    break;
            }
            buttonCell.FlatStyle = FlatStyle.Popup;
        }


        private void button_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_closedCells_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {       
            int value = cells[e.ColumnIndex, e.RowIndex];
            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridView_closedCells.Rows[e.RowIndex].Cells[e.ColumnIndex];
            switch (value)
            {
                case 0:
                    cells[e.ColumnIndex, e.RowIndex] = 2;
                    list_closedCells.Add((int)buttonCell.Value);
                    paintCell(buttonCell);
                    break;
                case 2:
                    cells[e.ColumnIndex, e.RowIndex] = 0;
                    list_closedCells.Remove((int)buttonCell.Value);
                    paintCell(buttonCell);
                    break;
                default:
                    break;
            }
        }

        private void button_ClearCells_Click(object sender, EventArgs e)
        {
            for (int numberRow = 0; numberRow < numberOfRows; numberRow++)
            {
                for (int numberColumn = 0; numberColumn <= numberOfColumns - 1; numberColumn++)
                {
                    if(cells[numberColumn, numberRow] == 2)
                    {                      
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridView_closedCells.Rows[numberRow].Cells[numberColumn];
                        cells[numberColumn, numberRow] = 0;
                        list_closedCells.Remove((int)buttonCell.Value);
                        paintCell(buttonCell);
                    }
                }
            } 
        }
    }
}
