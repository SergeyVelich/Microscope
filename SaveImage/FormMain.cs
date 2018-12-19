using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace SaveImage
{
    public partial class FormMain : Form
    {
        #region Form

        private Camera camera;
        static private List<int> List_closedCells = new List<int>();

        public FormMain(User _user)
        {
            InitializeComponent();

            comboBox_User.Items.Add(_user);
            comboBox_User.SelectedItem = _user;

            numericUpDown_Nest.Value = 1;

            switch ((Roles)_user.Role)
            {
                case Roles.Controller:
                    break;
                case Roles.Administrator:
                    break;
                default:
                    break;
            }
        }
        
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camera != null)
                camera.TurnOff();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(Path.Combine(Common.path, "temp.bmp")))
            {
                File.Delete(Path.Combine(Common.path, "temp.bmp"));
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)//??
        {
            if (((TabControl)sender).SelectedTab == tabPage_Search)
            {
                FillDataGridView_DB();
            }
        }

        #endregion

        #region Main

        private void button_TurnOnCamera_Click(object sender, EventArgs e)
        {
            if(camera != null)
                camera.TurnOff();

            camera = new Camera(pictureBox_Photo);
            camera.TurnOn();        
        }
            
        private void button_replacement_Click(object sender, EventArgs e)
        {
            if (camera != null)
                camera.TurnOff();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AddExtension = false;
            openFileDialog.SupportMultiDottedExtensions = false;
            openFileDialog.AutoUpgradeEnabled = true;
            openFileDialog.Title = "Открыть файл изображения:";
            openFileDialog.Filter = "Графические файлы | *.bmp; *.jpg; *.png; *.gif; *.tiff";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        pictureBox_Photo.Image = Bitmap.FromFile(openFileDialog.FileName);
                    }
                }
                catch
                {
                    Common.ShowErrorMessage("Невозможно открыть выбранный файл");
                }
            }
        }

        private void button_closedCells_Click(object sender, EventArgs e)//??
        {
            FormClosingCells formTable = new FormClosingCells(List_closedCells);
            formTable.ShowDialog();
            List_closedCells = formTable.list_closedCells;
            label_numbClCells.Text = showNumberCells();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            //if ((x * 8 + y + 1) < FormMain.numberReport)//??
            //    {
            //        Common.ShowErrorMessage("Данные по этой ячейке уже сохранены");
            //    }
            //else
            //{
            if (CheckDataBeforeSaving())
                return;

            Data dataRow = new Data();
            dataRow.Period = DateTime.Now;
            dataRow.User = (User)comboBox_User.SelectedItem;
            dataRow.Shift = textBox_Shift.Text;
            dataRow.WorkCenter = (WorkCenter)comboBox_WorkCenter.SelectedItem;
            dataRow.Pressform = (Pressform)comboBox_Pressform.SelectedItem;
            dataRow.Color = (Color)comboBox_Color.SelectedItem;
            dataRow.BoxNumber = textBox_boxNumber.Text;
            dataRow.NestNumber = (byte)numericUpDown_Nest.Value;
            dataRow.ControlType = 0;//??
            dataRow.Comments = textBox_Comments.Text;
            dataRow.ClosedNests = label_numbClCells.Text;
            dataRow.Defect = comboBox_Defect.SelectedItem == null ? null : (Defect)comboBox_Defect.SelectedItem;
            dataRow.HasDefect = comboBox_Defect.SelectedItem == null ? false : true;

            byte[] imagedata;
            using (var ms = new MemoryStream())
            {
                ImageFormat fmt = ImageFormat.Jpeg;
                pictureBox_Photo.Image.Save(ms, fmt);
                imagedata = ms.ToArray();
            }         
            dataRow.Photo = imagedata;

            DBRepositoryData repository = new DBRepositoryData();
            try
            {
                repository.Create(dataRow);            
            }
            catch (Exception ex)
            {
                Common.ShowErrorMessage(ex.ToString());
                return;
            }
            Common.ShowInfoMessage("Данные отправлены");
            do
            {
                numericUpDown_Nest.Value++;
            }
            while (List_closedCells.Any(db => db.Equals((int)numericUpDown_Nest.Value)));
        }
        private bool CheckDataBeforeSaving()
        {
            bool showMessage = false;
            string emptyFields = "Пожалуйста, заполните необходимые поля:";

            if (comboBox_WorkCenter.SelectedItem == null)
            {
                ChangeBorderColor(panel_WorkCenters, System.Drawing.Color.Red);
                emptyFields += "\n  -Рабочий центр";
                showMessage = true;
            }
            if (comboBox_Pressform.SelectedItem == null)
            {
                ChangeBorderColor(panel_Press_Forms, System.Drawing.Color.Red);
                emptyFields += "\n  -Номер пресс-формы";
                showMessage = true;
            }
            if (comboBox_Color.SelectedItem == null)
            {
                ChangeBorderColor(panel_Colors, System.Drawing.Color.Red);
                emptyFields += "\n  -Цвет";
                showMessage = true;
            }
            if (pictureBox_Photo.Image == null)
            {
                ChangeBorderColor(panel_Photo, System.Drawing.Color.Red);
                emptyFields += "\n  -Фото";
                showMessage = true;
            }

            if (showMessage)
            {
                Common.ShowErrorMessage(emptyFields);
            }
            return showMessage;
        }

        private void SavePhoto(MemoryStream memoryStream)
        {
            pictureBox_Photo.Image.Save(memoryStream, pictureBox_Photo.Image.RawFormat);
        }

        private List<WorkCenter> GetListWorkCenter()
        {
            List<WorkCenter> dtWorkCentres;
            using (DBContext dbContext = new DBContext())
            {
                dtWorkCentres = dbContext.WorkCenters.OrderBy(w=>w.Name).ToList();
            }
            return dtWorkCentres;
        }
        private List<Pressform> GetListPressform()
        {
            List<Pressform> dtPressforms;
            using (DBContext dbContext = new DBContext())
            {
                dtPressforms = dbContext.Pressforms.OrderBy(p => p.Name).ToList();
            }
            return dtPressforms;
        }
        private List<Color> GetListColor()
        {
            List<Color> dtColors;
            using (DBContext dbContext = new DBContext())
            {
                dtColors = dbContext.Colors.OrderBy(c => c.Name).ToList();
            }
            return dtColors;
        }
        private List<Defect> GetListDefect()
        {
            List<Defect> dtDefects;
            using (DBContext dbContext = new DBContext())
            {
                dtDefects = dbContext.Defects.OrderBy(d => d.Name).ToList();
            }
            return dtDefects;
        }

        private void comboBox_WorkCenter_DropDown(object sender, EventArgs e)
        {
            comboBox_WorkCenter.SelectedIndexChanged -= new System.EventHandler(this.comboBox_WorkCenter_SelectedIndexChanged);
            comboBox_WorkCenter.DataSource = GetListWorkCenter();
            comboBox_WorkCenter.SelectedIndex = -1;
            comboBox_WorkCenter.SelectedIndexChanged += new System.EventHandler(this.comboBox_WorkCenter_SelectedIndexChanged);
        }
        private void comboBox_Pressform_DropDown(object sender, EventArgs e)
        {
            comboBox_Pressform.SelectedIndexChanged -= new System.EventHandler(this.comboBox_Pressform_SelectedIndexChanged);
            comboBox_Pressform.DataSource = GetListPressform();
            comboBox_Pressform.SelectedIndex = -1;
            comboBox_Pressform.SelectedIndexChanged += new System.EventHandler(this.comboBox_Pressform_SelectedIndexChanged);
        }
        private void comboBox_Color_DropDown(object sender, EventArgs e)
        {
            comboBox_Color.SelectedIndexChanged -= new System.EventHandler(this.comboBox_Color_SelectedIndexChanged);
            comboBox_Color.DataSource = GetListColor();
            comboBox_Color.SelectedIndex = -1;
            comboBox_Color.SelectedIndexChanged += new System.EventHandler(this.comboBox_Color_SelectedIndexChanged);
        }
        private void comboBox_Defect_DropDown(object sender, EventArgs e)
        {
            comboBox_Defect.DataSource = GetListDefect();
            comboBox_Defect.SelectedIndex = -1;
        }

        private void comboBox_WorkCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeBorderColor(panel_WorkCenters, System.Drawing.Color.Silver);
        }
        private void comboBox_Pressform_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeBorderColor(panel_Press_Forms, System.Drawing.Color.Silver);
        }
        private void comboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeBorderColor(panel_Colors, System.Drawing.Color.Silver);
        }

        private void button_AddWorkCenter_Click(object sender, EventArgs e)
        {
            if (comboBox_WorkCenter.SelectedValue == null)
                return;

            WorkCenter workCenter = new WorkCenter();
            workCenter.Name = comboBox_WorkCenter.Text;
            using (DBContext dbContext = new DBContext())
            {
                dbContext.WorkCenters.Add(workCenter);
                try
                {
                    dbContext.SaveChanges();                   
                }
                catch (Exception ex)
                {
                    Common.ShowErrorMessage(ex.ToString());
                    return;
                }               
            }
            Common.ShowInfoMessage("Рабочий центр добавлен");
            comboBox_WorkCenter.SelectedIndex = -1;
        }
        private void button_AddPressform_Click(object sender, EventArgs e)
        {
            if (comboBox_Pressform.SelectedValue == null)
                return;

            Pressform pressForm = new Pressform();
            pressForm.Name = comboBox_Pressform.Text;
            using (DBContext dbContext = new DBContext())
            {
                dbContext.Pressforms.Add(pressForm);
                try
                {
                    dbContext.SaveChanges();                  
                }
                catch (Exception ex)
                {
                    Common.ShowErrorMessage(ex.ToString());
                    return;
                }                
            }
            Common.ShowInfoMessage("Прессформа добавлена");
            comboBox_Pressform.SelectedIndex = -1;
        }
        private void button_AddColor_Click(object sender, EventArgs e)
        {
            if (comboBox_Color.SelectedValue == null)
                return;

            Color color = new Color();
            color.Name = comboBox_Color.Text;
            using (DBContext dbContext = new DBContext())
            {
                dbContext.Colors.Add(color);
                try
                {
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    Common.ShowErrorMessage(ex.ToString());
                    return;
                }
            }
            Common.ShowInfoMessage("Цвет добавлен");
            comboBox_Color.Text = "";
        }

        private void button_ClearDefect_Click(object sender, EventArgs e)
        {
            comboBox_Defect.SelectedIndex = -1;
        }

        static public string showNumberCells()//??
        {
            string textForLabel;
            if (List_closedCells.Count != 0)
            {
                int[] closedCells = new int[List_closedCells.Count];
                List_closedCells.CopyTo(closedCells, 0);
                Array.Sort(closedCells);
                textForLabel = "";
                for (int i = 0; i < closedCells.Length; i++)
                {
                    textForLabel += closedCells[i] + ", ";
                }
                string[] multiLines = textForLabel.Split(',');
                textForLabel = "";
                for (int i = 0; i < multiLines.Length; i++)
                {
                    if (multiLines[i] != " ")
                    {
                        textForLabel += multiLines[i] + ",";
                        if (i % 10 == 0 && i >= 10)
                        {
                            textForLabel += "\n";
                        }
                    }
                }
            }
            else
            {
                textForLabel = "";
            }

            return textForLabel;
        }

        private void ChangeBorderColor(Panel panel, System.Drawing.Color color)
        {
            ControlPaint.DrawBorder(panel.CreateGraphics(), panel.DisplayRectangle, color, ButtonBorderStyle.Solid);
        }

        #endregion

        #region History

        private void FillDataGridView_DB()
        {           
            dataGridView_DB.DataSource = GetDataDB();
            GetFilterDataGridView_DB();        
            SetOrderDataGridView_DB();
            //SetDecorDataGridView_DB();
        }
        private DataTable GetDataDB()
        {
            DateTime startDate = new DateTime(dateTimePicker_FilterStartPeriod.Value.Year, dateTimePicker_FilterStartPeriod.Value.Month, dateTimePicker_FilterStartPeriod.Value.Day);
            DateTime finishDate = new DateTime(dateTimePicker_FilterFinishPeriod.Value.Year, dateTimePicker_FilterFinishPeriod.Value.Month, dateTimePicker_FilterFinishPeriod.Value.Day, 23, 59, 59);

            System.Windows.Forms.SortOrder SortDirection;
            string SortedColumn;

            if (dataGridView_DB.SortedColumn == null)
            {
                SortedColumn = "Period";
                SortDirection = System.Windows.Forms.SortOrder.Descending;
            }
            else
            {
                SortedColumn = dataGridView_DB.SortedColumn.Name;
                SortDirection = dataGridView_DB.SortOrder;
            }
            
            DataTable dtData = new DataTable();
            dtData.Columns.Add("Id");
            dtData.Columns.Add("Period", typeof(DateTime));
            dtData.Columns.Add("Shift");
            dtData.Columns.Add("WorkCenter");
            dtData.Columns.Add("NestNumber");
            dtData.Columns.Add("BoxNumber");
            dtData.Columns.Add("Pressform");
            dtData.Columns.Add("Color");
            dtData.Columns.Add("HasDefect", typeof(bool));

            using (DBContext dbContext = new DBContext())
            {
                try {
                    //var dataRows = dbContext.Data.Select(d => new//??
                    var dataRows = dbContext.Data.Where(d => d.Period > startDate && d.Period <= finishDate).Select(d => new
                    {
                        Id = d.Id,
                        Period = d.Period,
                        Shift = d.Shift,
                        WorkCenter = d.WorkCenter,
                        NestNumber = d.NestNumber,
                        BoxNumber = d.BoxNumber,
                        Pressform = d.Pressform,
                        Color = d.Color,
                        HasDefect = d.HasDefect
                    });

                    dataRows = Common.Order(dataRows, SortedColumn, SortDirection);

                    DataRow dtRow;
                    foreach (var d in dataRows)
                    {
                        dtRow = dtData.NewRow();
                        dtRow["Id"] = d.Id;
                        dtRow["Period"] = d.Period;
                        dtRow["Shift"] = d.Shift;
                        dtRow["WorkCenter"] = d.WorkCenter.Name;
                        dtRow["NestNumber"] = d.NestNumber;
                        dtRow["BoxNumber"] = d.BoxNumber;
                        dtRow["Pressform"] = d.Pressform.Name;
                        dtRow["Color"] = d.Color.Name;
                        dtRow["HasDefect"] = d.HasDefect;
                        dtData.Rows.Add(dtRow);
                    }
                }
                catch (Exception ex)
                {
                    Common.ShowErrorMessage(ex.ToString());
                }
            }
            return dtData;         
        }

        private void GetFilterDataGridView_DB()
        {
            int CountFilters = 8;

            Control[] Filters = new Control[CountFilters];
            Filters[0] = dateTimePicker_FilterStartPeriod;
            Filters[1] = comboBox_FilterWorkCenter;
            Filters[2] = comboBox_FilterPressform;
            Filters[3] = comboBox_FilterColor;
            Filters[4] = textBox_FilterBoxNumber;
            Filters[5] = textBox_FilterShift;
            Filters[6] = textBox_FilterNestNumber;
            Filters[7] = checkBox_FilterHasDefect;

            string[] FiltersText = new string[CountFilters];

            foreach (Control f in Filters)
            {
                if (f is TextBox)
                {
                    if (f.Text != String.Empty)
                    {
                        FiltersText[Array.IndexOf(Filters, f)] = " AND " + String.Format(f.Name.Substring(14) + " = '{0}'", f.Text);
                    }
                }
                if (f is ComboBox)
                {
                    if (f.Text != String.Empty)
                    {
                        FiltersText[Array.IndexOf(Filters, f)] = " AND " + String.Format(f.Name.Substring(15) + " = '{0}'", ((ComboBox)f).Text);
                    }
                }
                else if (f is CheckBox)
                {
                    if (((CheckBox)f).CheckState == CheckState.Checked || ((CheckBox)f).CheckState == CheckState.Unchecked)
                    {
                        FiltersText[Array.IndexOf(Filters, f)] = " AND " + String.Format(f.Name.Substring(15) + " = '{0}'", ((CheckBox)f).Checked);
                    }
                }
            }
            ((DataTable)dataGridView_DB.DataSource).DefaultView.RowFilter = "true " + string.Concat(FiltersText);
        }
        private void SetOrderDataGridView_DB()
        {
            dataGridView_DB.Columns["Period"].HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Descending;
        }
        //private void SetDecorDataGridView_DB()
        //{
        //for (int i = 0; i < dataGridView_DB.RowCount; i++)
        //{
        //    if (((bool)dataGridView_DB.Rows[i].Cells["HasDefect"].Value) == true)
        //    {
        //        dataGridView_DB.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
        //    }
        //}
        //}
        private void button_Search_Click(object sender, EventArgs e)
        {
            int currentId = Convert.ToInt32(dataGridView_DB.CurrentRow.Cells["Id"].Value);
            try
            {
                using (DBContext dbContext = new DBContext())
                {
                    var currentData = dbContext.Data.Where(d => d.Id == currentId).Select(d => new
                    {
                        User = d.User.Login,
                        Shift = d.Shift,
                        Period = d.Period,
                        WorkCenter = d.WorkCenter.Name,
                        NestNumber = d.NestNumber,
                        BoxNumber = d.BoxNumber,
                        Pressform = d.Pressform.Name,
                        Color = d.Color.Name,
                        Comment = d.Comments,
                        ClosedNests = d.ClosedNests
                    }).Single();

                    string info = "Период: " + currentData.Period + "\n" + "Рабочая смена: " + currentData.Shift + "\n" + "Логин сотрудника: " + currentData.User + "\n" + "Рабочий центр: " + currentData.WorkCenter + "\n" + "Номер ячейки: " + currentData.NestNumber + "\n" + "Номер короба: " + currentData.BoxNumber + "\n" + "Номер пресс-формы: " + currentData.Pressform + "\n" + "Цвет: " + currentData.Color + "\n" + "Комментарии: " + currentData.Comment + "\n" + "Заблокированные гнезда: " + currentData.ClosedNests;
                    Common.ShowInfoMessage(info);
                }
            }
            catch (Exception ex)
            {
                Common.ShowErrorMessage(ex.ToString());
                return;
            }
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = false;
            saveFileDialog.SupportMultiDottedExtensions = false;
            saveFileDialog.AutoUpgradeEnabled = true;
            saveFileDialog.Title = "Открыть файл изображения:";
            saveFileDialog.Filter = "JPEG Image (.jpeg)|*.jpeg|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff";
            saveFileDialog.FileName = "Micro " + DateTime.UtcNow.ToString();
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ImageFormat format = ImageFormat.Bmp;
                    string ext = Path.GetExtension(saveFileDialog.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        case ".gif":
                            format = ImageFormat.Gif;
                            break;
                        case ".tiff":
                            format = ImageFormat.Tiff;
                            break;
                    }
                    pictureBox_downloadImage.Image.Save(saveFileDialog.FileName, format);
                }
                catch
                {
                    Common.ShowErrorMessage("Невозможно открыть выбранный файл");
                }
            }

        }
       
        private void dataGridView_DB_SelectionChanged(object sender, EventArgs e)
        {
            if (!dataGridView_DB.Focused)
                return;

            if (dataGridView_DB.CurrentRow != null)
            {
                using (DBContext dbContext = new DBContext())
                {
                    try
                    {
                        int currentId = Convert.ToInt32(dataGridView_DB.CurrentRow.Cells["Id"].Value);
                        byte[] bytearray = dbContext.Data.Where(d => d.Id == currentId).Select(d => d.Photo).Single();

                        using (var memstr = new MemoryStream(bytearray))
                        {
                            Bitmap bitmap = new Bitmap(memstr);
                            pictureBox_downloadImage.Image = bitmap;
                        }
                    }
                    catch (Exception ex)
                    {
                        Common.ShowErrorMessage(ex.ToString());
                    }
                }
            }
        }

        private void dateTimePicker_FilterStartPeriod_ValueChanged(object sender, EventArgs e)
        {
                dataGridView_DB.DataSource = GetDataDB();
        }
        private void dateTimePicker_FilterFinishPeriod_ValueChanged(object sender, EventArgs e)
        {
                dataGridView_DB.DataSource = GetDataDB();
        }
        private void comboBox_FilterWorkCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
                GetFilterDataGridView_DB();
        }
        private void comboBox_FilterPressform_SelectedIndexChanged(object sender, EventArgs e)
        {
                GetFilterDataGridView_DB();
        }
        private void comboBox_FilterColor_SelectedIndexChanged(object sender, EventArgs e)
        {
                GetFilterDataGridView_DB();
        }
        private void textBox_FilterBoxNumber_Leave(object sender, EventArgs e)
        {
                GetFilterDataGridView_DB();
        }
        private void textBox_FilterShift_Leave(object sender, EventArgs e)
        {
                GetFilterDataGridView_DB();
        }
        private void textBox_FilterNestNumber_Leave(object sender, EventArgs e)
        {
                GetFilterDataGridView_DB();
        }
        private void checkBox_FilterHasDefect_CheckStateChanged(object sender, EventArgs e)
        {
                GetFilterDataGridView_DB();
        }

        private void dateTimePicker_FilterStartPeriod_KeyUp(object sender, KeyEventArgs e)
        {
            SelectNextFilter(sender, e);
        }
        private void dateTimePicker_FilterFinishPeriod_KeyUp(object sender, KeyEventArgs e)
        {
            SelectNextFilter(sender, e);
        }
        private void comboBox_FilterWorkCenter_KeyUp(object sender, KeyEventArgs e)
        {
            SelectNextFilter(sender, e);
        }
        private void comboBox_FilterPressform_KeyUp(object sender, KeyEventArgs e)
        {
            SelectNextFilter(sender, e);
        }
        private void comboBox_FilterColor_KeyUp(object sender, KeyEventArgs e)
        {
            SelectNextFilter(sender, e);
        }
        private void textBox_FilterBoxNumber_KeyUp(object sender, KeyEventArgs e)
        {
            SelectNextFilter(sender, e);
        }
        private void textBox_FilterShift_KeyUp(object sender, KeyEventArgs e)
        {
            SelectNextFilter(sender, e);
        }
        private void textBox_FilterNestNumber_KeyUp(object sender, KeyEventArgs e)
        {
            SelectNextFilter(sender, e);
        }
        private void checkBox_FilterHasDefect_KeyUp(object sender, KeyEventArgs e)
        {
            SelectNextFilter(sender, e);
        }
        private void SelectNextFilter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void button_DeleteRow_Click(object sender, EventArgs e)//??обновить ТЧ после удаления
        {
            if (dataGridView_DB.CurrentRow == null)
                return;

            int id = Convert.ToInt32(dataGridView_DB.CurrentRow.Cells["Id"].Value);
            DBRepositoryData repository = new DBRepositoryData();
            try
            {
                repository.Delete(id);
                dataGridView_DB.DataSource = GetDataDB();
            }
            catch (Exception ex)
            {
                Common.ShowErrorMessage(ex.ToString());
            }           
        }

        private void comboBox_FilterWorkCenter_DropDown(object sender, EventArgs e)
        {
            comboBox_FilterWorkCenter.SelectedIndexChanged -= new EventHandler(comboBox_FilterWorkCenter_SelectedIndexChanged);
            comboBox_FilterWorkCenter.DataSource = GetListWorkCenter();
            comboBox_FilterWorkCenter.SelectedIndex = -1;
            comboBox_FilterWorkCenter.SelectedIndexChanged += new EventHandler(comboBox_FilterWorkCenter_SelectedIndexChanged);
        }
        private void comboBox_FilterPressform_DropDown(object sender, EventArgs e)
        {
            comboBox_FilterPressform.SelectedIndexChanged -= new EventHandler(comboBox_FilterPressform_SelectedIndexChanged);
            comboBox_FilterPressform.DataSource = GetListPressform();
            comboBox_FilterPressform.SelectedIndex = -1;
            comboBox_FilterPressform.SelectedIndexChanged += new EventHandler(comboBox_FilterPressform_SelectedIndexChanged);
        }
        private void comboBox_FilterColor_DropDown(object sender, EventArgs e)
        {
            comboBox_FilterColor.SelectedIndexChanged -= new EventHandler(comboBox_FilterColor_SelectedIndexChanged);
            comboBox_FilterColor.DataSource = GetListColor();
            comboBox_FilterColor.SelectedIndex = -1;
            comboBox_FilterColor.SelectedIndexChanged += new EventHandler(comboBox_FilterColor_SelectedIndexChanged);
        }

        private void button_FilterWorkCenter_Remove_Click(object sender, EventArgs e)
        {
            comboBox_FilterWorkCenter.SelectedIndex = -1;
        }
        private void button_FilterPressform_Remove_Click(object sender, EventArgs e)
        {
            comboBox_FilterPressform.SelectedIndex = -1;
        }
        private void button_FilterColor_Remove_Click(object sender, EventArgs e)
        {
            comboBox_FilterColor.SelectedIndex = -1;
        }

        #endregion

        private void button_RemoveWorkCenter_Click(object sender, EventArgs e)
        {
            if (comboBox_WorkCenter.SelectedValue == null)
                return;

            int id = (int)comboBox_WorkCenter.SelectedValue;
            try
            {
                using (DBContext dbContext = new DBContext())
                {
                    WorkCenter workCenter = dbContext.WorkCenters.Where(d => d.Id == id).Single();
                    int countWorkCenters = dbContext.Data.Where(d => d.WorkCenter.Id == id).Count();
                    if (countWorkCenters == 0)
                    {
                        dbContext.WorkCenters.Remove(workCenter);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        Common.ShowErrorMessage("Этот рабочий центр уже используется");
                        return;
                    }                       
                }
            }
            catch (Exception ex)
            {
                Common.ShowErrorMessage(ex.ToString());
            }
            Common.ShowInfoMessage("Рабочий центр удален");
        }
        private void button_RemovePressform_Click(object sender, EventArgs e)
        {
            if (comboBox_Pressform.SelectedValue == null)
                return;

            int id = (int)comboBox_Pressform.SelectedValue;
            try
            {
                using (DBContext dbContext = new DBContext())
                {
                    Pressform pressform = dbContext.Pressforms.Where(d => d.Id == id).Single();
                    int countPressforms = dbContext.Data.Where(d => d.Pressform.Id == id).Count();
                    if (countPressforms == 0)
                    {
                        dbContext.Pressforms.Remove(pressform);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        Common.ShowErrorMessage("Эта прессформа уже используется");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Common.ShowErrorMessage(ex.ToString());
            }
            Common.ShowInfoMessage("Прессформа удалена");
        }
        private void button_RemoveColor_Click(object sender, EventArgs e)
        {
            if (comboBox_Color.SelectedValue == null)
                return;

            int id = (int)comboBox_Color.SelectedValue;
            try
            {
                using (DBContext dbContext = new DBContext())
                {
                    Color color = dbContext.Colors.Where(d => d.Id == id).Single();
                    int countColors = dbContext.Data.Where(d => d.Color.Id == id).Count();
                    if (countColors == 0)
                    {
                        dbContext.Colors.Remove(color);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        Common.ShowErrorMessage("Этот цвет уже используется");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Common.ShowErrorMessage(ex.ToString());
            }
            Common.ShowInfoMessage("Цвет удален");
        }
    }
}