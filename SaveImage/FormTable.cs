using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaveImage
{
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
        }

        public FormTable(FormMain form)
        {
            InitializeComponent();
            load_Cells();
        }

        static int numberOfRows = 12;
        static int numberOfColumns = 8;
        static DataGridViewCell cell;
        static public byte[,] cells = new byte[12, 8];

        /*
          cell[i] == 0   -    ячейка не обработана
                  == 1   -    ячейка обработана
                  == 2   -    "закрытое гнездо"
                                                                   */

        private void button_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void load_Cells()
        {
            int height = (dataGridView_closedCells.Height - 2) / numberOfRows;
        
            DataGridViewButtonColumn firstColumn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn secondColumn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn thirdColumn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn fourthColumn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn fifthColumn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn sixthColumn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn seventhColumn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn eighthColumn = new DataGridViewButtonColumn();

            dataGridView_closedCells.Columns.Add(firstColumn);
            dataGridView_closedCells.Columns.Add(secondColumn);
            dataGridView_closedCells.Columns.Add(thirdColumn);
            dataGridView_closedCells.Columns.Add(fourthColumn);
            dataGridView_closedCells.Columns.Add(fifthColumn);
            dataGridView_closedCells.Columns.Add(sixthColumn);
            dataGridView_closedCells.Columns.Add(seventhColumn);
            dataGridView_closedCells.Columns.Add(eighthColumn);

            dataGridView_closedCells.ColumnCount = numberOfColumns;

            int k = 1;
            
            for (int i = 0; i < numberOfRows; i++)
            {
                dataGridView_closedCells.Rows.Add();
                dataGridView_closedCells.Rows[i].Height = height;
                for (int j = 0; j < numberOfColumns; j++)
                {
                    cell = dataGridView_closedCells.Rows[i].Cells[j];
                    cell.Value = k;
                    int value = cells[i, j];
                    switch (value)
                    {
                        case 0:
                            paintCell(i, j, Color.White);
                            break;
                        case 1:
                            paintCell(i, j, Color.Gainsboro);
                            break;
                        case 2:
                            paintCell(i, j, Color.DarkGray);
                            break;
                        //case 3:
                        //    paintCell(i, j, Color.Gainsboro);
                        //    cell.Style.BackColor = Color.Red;
                        //    break;
                    }
                    k++;
                }
            }


        }

        public void paintCell(int x, int y, Color color)
        {
            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridView_closedCells.Rows[x].Cells[y];
            buttonCell.FlatStyle = FlatStyle.Popup;
            buttonCell.Style.BackColor = color;
        }


        private void dataGridView_closedCells_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x, y;
            y = dataGridView_closedCells.CurrentCellAddress.X;
            x = dataGridView_closedCells.CurrentCellAddress.Y;
            int value = cells[x, y];
            if ((x * 8 + y + 1) < FormMain.numberReport)
                { MessageBox.Show("Данные по этой ячейке уже сохранены", "", MessageBoxButtons.OK); }
            else
            {
                switch (value)
                {
                    case 0:
                        if (FormMain.numberReport == (x * 8 + y + 1))
                        {
                            DialogResult dialogResult = MessageBox.Show("Отметить данную ячейку как 'закрытое гнездо'? В таком случае данные относительно этой ячейки будут удалены.", "Работа с ячейками", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                cells[x, y] = 2;
                                paintCell(x, y, Color.DarkGray);
                                FormMain.list_closedCells.Add(x * 8 + y + 1);
                                FormMain.numberReport++;
                            }
                        }
                        else
                        {
                            cells[x, y] = 2;
                            paintCell(x, y, Color.DarkGray);
                            FormMain.list_closedCells.Add(x * 8 + y + 1);
                        }
                        break;
                    case 2:
                        cells[x, y] = 0;
                        paintCell(x, y, Color.White);
                        FormMain.list_closedCells.Remove(x * 8 + y + 1);
                        break;
                    default:
                        break;
                }
            }
            FormMain.showNumberCells();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    cells[i, j] = 0; 
                }
            }
            load_Cells();
            FormMain.list_closedCells.Clear();
        }
    }
}
