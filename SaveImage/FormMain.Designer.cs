namespace SaveImage
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPage_Search = new System.Windows.Forms.TabPage();
            this.panel_downloadImage = new System.Windows.Forms.TableLayoutPanel();
            this.button_DeleteRow = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_download = new System.Windows.Forms.Button();
            this.pictureBox_downloadImage = new System.Windows.Forms.PictureBox();
            this.dataGridView_DB = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NestNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasDefect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_FilterColor_Remove = new System.Windows.Forms.Button();
            this.button_FilterPressform_Remove = new System.Windows.Forms.Button();
            this.button_FilterWorkCenter_Remove = new System.Windows.Forms.Button();
            this.comboBox_FilterColor = new System.Windows.Forms.ComboBox();
            this.comboBox_FilterPressform = new System.Windows.Forms.ComboBox();
            this.comboBox_FilterWorkCenter = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_FilterFinishPeriod = new System.Windows.Forms.DateTimePicker();
            this.label__FilterFinishPeriod = new System.Windows.Forms.Label();
            this.dateTimePicker_FilterStartPeriod = new System.Windows.Forms.DateTimePicker();
            this.label_FilterColor = new System.Windows.Forms.Label();
            this.label_FilterPressform = new System.Windows.Forms.Label();
            this.label_FilterWorkCenter = new System.Windows.Forms.Label();
            this.label_FilterStartPeriod = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_FilterBoxNumber = new System.Windows.Forms.TextBox();
            this.label_FilterBoxNumber = new System.Windows.Forms.Label();
            this.label_FilterWorkingShift = new System.Windows.Forms.Label();
            this.textBox_FilterShift = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_FilterNestNumber = new System.Windows.Forms.Label();
            this.checkBox_FilterHasDefect = new System.Windows.Forms.CheckBox();
            this.textBox_FilterNestNumber = new System.Windows.Forms.TextBox();
            this.label_FilterHasDefect = new System.Windows.Forms.Label();
            this.tabPage_Photo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_WorkCenters = new System.Windows.Forms.Panel();
            this.button_RemoveWorkCenter = new System.Windows.Forms.Button();
            this.comboBox_WorkCenter = new System.Windows.Forms.ComboBox();
            this.button_AddWorkCenter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_send = new System.Windows.Forms.Button();
            this.panel_Press_Forms = new System.Windows.Forms.Panel();
            this.button_RemovePressform = new System.Windows.Forms.Button();
            this.comboBox_Pressform = new System.Windows.Forms.ComboBox();
            this.button_AddPressform = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_Comments = new System.Windows.Forms.Label();
            this.textBox_Comments = new System.Windows.Forms.TextBox();
            this.panel_Defects = new System.Windows.Forms.Panel();
            this.button_ClearDefect = new System.Windows.Forms.Button();
            this.comboBox_Defect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_ClosedCells = new System.Windows.Forms.Panel();
            this.label_numbClCells = new System.Windows.Forms.Label();
            this.button_closedCells = new System.Windows.Forms.Button();
            this.panel_Colors = new System.Windows.Forms.Panel();
            this.button_RemoveColor = new System.Windows.Forms.Button();
            this.comboBox_Color = new System.Windows.Forms.ComboBox();
            this.button_AddColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_BoxNumber = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_boxNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Photo = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown_Nest = new System.Windows.Forms.NumericUpDown();
            this.comboBox_User = new System.Windows.Forms.ComboBox();
            this.label_Nest = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.textBox_Shift = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_TurnOnCamera = new System.Windows.Forms.Button();
            this.button_Replacement = new System.Windows.Forms.Button();
            this.panel_Photo = new System.Windows.Forms.Panel();
            this.pictureBox_Photo = new System.Windows.Forms.PictureBox();
            this.imagesdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabPage_Search.SuspendLayout();
            this.panel_downloadImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_downloadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DB)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage_Photo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_WorkCenters.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_Press_Forms.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_Defects.SuspendLayout();
            this.panel_ClosedCells.SuspendLayout();
            this.panel_Colors.SuspendLayout();
            this.panel_BoxNumber.SuspendLayout();
            this.tableLayoutPanel_Photo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Nest)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_Photo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesdbDataSetBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_Search
            // 
            this.tabPage_Search.BackColor = System.Drawing.Color.Silver;
            this.tabPage_Search.Controls.Add(this.panel_downloadImage);
            this.tabPage_Search.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Search.Name = "tabPage_Search";
            this.tabPage_Search.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Search.Size = new System.Drawing.Size(1160, 712);
            this.tabPage_Search.TabIndex = 1;
            this.tabPage_Search.Text = "Поиск данных";
            // 
            // panel_downloadImage
            // 
            this.panel_downloadImage.ColumnCount = 3;
            this.panel_downloadImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panel_downloadImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panel_downloadImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panel_downloadImage.Controls.Add(this.button_DeleteRow, 0, 2);
            this.panel_downloadImage.Controls.Add(this.button_Search, 1, 2);
            this.panel_downloadImage.Controls.Add(this.button_download, 2, 2);
            this.panel_downloadImage.Controls.Add(this.pictureBox_downloadImage, 1, 1);
            this.panel_downloadImage.Controls.Add(this.dataGridView_DB, 0, 1);
            this.panel_downloadImage.Controls.Add(this.panel1, 0, 0);
            this.panel_downloadImage.Controls.Add(this.panel5, 1, 0);
            this.panel_downloadImage.Controls.Add(this.panel6, 2, 0);
            this.panel_downloadImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_downloadImage.Location = new System.Drawing.Point(3, 3);
            this.panel_downloadImage.Name = "panel_downloadImage";
            this.panel_downloadImage.RowCount = 3;
            this.panel_downloadImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel_downloadImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.panel_downloadImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panel_downloadImage.Size = new System.Drawing.Size(1154, 706);
            this.panel_downloadImage.TabIndex = 3;
            // 
            // button_DeleteRow
            // 
            this.button_DeleteRow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_DeleteRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button_DeleteRow.Location = new System.Drawing.Point(328, 627);
            this.button_DeleteRow.Name = "button_DeleteRow";
            this.button_DeleteRow.Size = new System.Drawing.Size(150, 50);
            this.button_DeleteRow.TabIndex = 7;
            this.button_DeleteRow.Text = "Удалить";
            this.button_DeleteRow.UseVisualStyleBackColor = true;
            this.button_DeleteRow.Click += new System.EventHandler(this.button_DeleteRow_Click);
            // 
            // button_Search
            // 
            this.button_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button_Search.Location = new System.Drawing.Point(818, 627);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(150, 50);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Показать";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_download
            // 
            this.button_download.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_download.Location = new System.Drawing.Point(992, 627);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(150, 50);
            this.button_download.TabIndex = 1;
            this.button_download.Text = "Скачать изображение";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // pictureBox_downloadImage
            // 
            this.pictureBox_downloadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_downloadImage.BackColor = System.Drawing.Color.White;
            this.panel_downloadImage.SetColumnSpan(this.pictureBox_downloadImage, 2);
            this.pictureBox_downloadImage.Location = new System.Drawing.Point(807, 70);
            this.pictureBox_downloadImage.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pictureBox_downloadImage.Name = "pictureBox_downloadImage";
            this.pictureBox_downloadImage.Size = new System.Drawing.Size(337, 529);
            this.pictureBox_downloadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_downloadImage.TabIndex = 0;
            this.pictureBox_downloadImage.TabStop = false;
            // 
            // dataGridView_DB
            // 
            this.dataGridView_DB.AllowUserToAddRows = false;
            this.dataGridView_DB.AllowUserToDeleteRows = false;
            this.dataGridView_DB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Period,
            this.WorkCenter,
            this.Pressform,
            this.Color,
            this.BoxNumber,
            this.Shift,
            this.NestNumber,
            this.HasDefect});
            this.dataGridView_DB.Location = new System.Drawing.Point(3, 73);
            this.dataGridView_DB.Name = "dataGridView_DB";
            this.dataGridView_DB.ReadOnly = true;
            this.dataGridView_DB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DB.Size = new System.Drawing.Size(801, 523);
            this.dataGridView_DB.TabIndex = 3;
            this.dataGridView_DB.SelectionChanged += new System.EventHandler(this.dataGridView_DB_SelectionChanged);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            // 
            // Period
            // 
            this.Period.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Period.DataPropertyName = "Period";
            this.Period.HeaderText = "Период";
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            this.Period.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Period.Width = 70;
            // 
            // WorkCenter
            // 
            this.WorkCenter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WorkCenter.DataPropertyName = "WorkCenter";
            this.WorkCenter.HeaderText = "Рабочий центр";
            this.WorkCenter.Name = "WorkCenter";
            this.WorkCenter.ReadOnly = true;
            this.WorkCenter.Width = 97;
            // 
            // Pressform
            // 
            this.Pressform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pressform.DataPropertyName = "Pressform";
            this.Pressform.HeaderText = "Пресс-форма";
            this.Pressform.Name = "Pressform";
            this.Pressform.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Цвет";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // BoxNumber
            // 
            this.BoxNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BoxNumber.DataPropertyName = "BoxNumber";
            this.BoxNumber.HeaderText = "№ ящика";
            this.BoxNumber.Name = "BoxNumber";
            this.BoxNumber.ReadOnly = true;
            this.BoxNumber.Width = 73;
            // 
            // Shift
            // 
            this.Shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Shift.DataPropertyName = "Shift";
            this.Shift.HeaderText = "Смена";
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            this.Shift.Width = 65;
            // 
            // NestNumber
            // 
            this.NestNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NestNumber.DataPropertyName = "NestNumber";
            this.NestNumber.HeaderText = "№ гнезда";
            this.NestNumber.Name = "NestNumber";
            this.NestNumber.ReadOnly = true;
            this.NestNumber.Width = 75;
            // 
            // HasDefect
            // 
            this.HasDefect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.HasDefect.DataPropertyName = "HasDefect";
            this.HasDefect.HeaderText = "Есть дефект";
            this.HasDefect.Name = "HasDefect";
            this.HasDefect.ReadOnly = true;
            this.HasDefect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HasDefect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HasDefect.Width = 88;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_FilterColor_Remove);
            this.panel1.Controls.Add(this.button_FilterPressform_Remove);
            this.panel1.Controls.Add(this.button_FilterWorkCenter_Remove);
            this.panel1.Controls.Add(this.comboBox_FilterColor);
            this.panel1.Controls.Add(this.comboBox_FilterPressform);
            this.panel1.Controls.Add(this.comboBox_FilterWorkCenter);
            this.panel1.Controls.Add(this.dateTimePicker_FilterFinishPeriod);
            this.panel1.Controls.Add(this.label__FilterFinishPeriod);
            this.panel1.Controls.Add(this.dateTimePicker_FilterStartPeriod);
            this.panel1.Controls.Add(this.label_FilterColor);
            this.panel1.Controls.Add(this.label_FilterPressform);
            this.panel1.Controls.Add(this.label_FilterWorkCenter);
            this.panel1.Controls.Add(this.label_FilterStartPeriod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 64);
            this.panel1.TabIndex = 6;
            // 
            // button_FilterColor_Remove
            // 
            this.button_FilterColor_Remove.Location = new System.Drawing.Point(736, 9);
            this.button_FilterColor_Remove.Name = "button_FilterColor_Remove";
            this.button_FilterColor_Remove.Size = new System.Drawing.Size(20, 21);
            this.button_FilterColor_Remove.TabIndex = 29;
            this.button_FilterColor_Remove.Text = "X";
            this.button_FilterColor_Remove.UseVisualStyleBackColor = true;
            this.button_FilterColor_Remove.Click += new System.EventHandler(this.button_FilterColor_Remove_Click);
            // 
            // button_FilterPressform_Remove
            // 
            this.button_FilterPressform_Remove.Location = new System.Drawing.Point(489, 34);
            this.button_FilterPressform_Remove.Name = "button_FilterPressform_Remove";
            this.button_FilterPressform_Remove.Size = new System.Drawing.Size(20, 21);
            this.button_FilterPressform_Remove.TabIndex = 28;
            this.button_FilterPressform_Remove.Text = "X";
            this.button_FilterPressform_Remove.UseVisualStyleBackColor = true;
            this.button_FilterPressform_Remove.Click += new System.EventHandler(this.button_FilterPressform_Remove_Click);
            // 
            // button_FilterWorkCenter_Remove
            // 
            this.button_FilterWorkCenter_Remove.Location = new System.Drawing.Point(489, 9);
            this.button_FilterWorkCenter_Remove.Name = "button_FilterWorkCenter_Remove";
            this.button_FilterWorkCenter_Remove.Size = new System.Drawing.Size(20, 21);
            this.button_FilterWorkCenter_Remove.TabIndex = 27;
            this.button_FilterWorkCenter_Remove.Text = "X";
            this.button_FilterWorkCenter_Remove.UseVisualStyleBackColor = true;
            this.button_FilterWorkCenter_Remove.Click += new System.EventHandler(this.button_FilterWorkCenter_Remove_Click);
            // 
            // comboBox_FilterColor
            // 
            this.comboBox_FilterColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_FilterColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_FilterColor.DisplayMember = "Name";
            this.comboBox_FilterColor.FormattingEnabled = true;
            this.comboBox_FilterColor.Location = new System.Drawing.Point(583, 9);
            this.comboBox_FilterColor.Name = "comboBox_FilterColor";
            this.comboBox_FilterColor.Size = new System.Drawing.Size(153, 21);
            this.comboBox_FilterColor.TabIndex = 26;
            this.comboBox_FilterColor.ValueMember = "Id";
            this.comboBox_FilterColor.DropDown += new System.EventHandler(this.comboBox_FilterColor_DropDown);
            this.comboBox_FilterColor.SelectedIndexChanged += new System.EventHandler(this.comboBox_FilterColor_SelectedIndexChanged);
            this.comboBox_FilterColor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_FilterColor_KeyUp);
            // 
            // comboBox_FilterPressform
            // 
            this.comboBox_FilterPressform.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_FilterPressform.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_FilterPressform.DisplayMember = "Name";
            this.comboBox_FilterPressform.FormattingEnabled = true;
            this.comboBox_FilterPressform.Location = new System.Drawing.Point(336, 34);
            this.comboBox_FilterPressform.Name = "comboBox_FilterPressform";
            this.comboBox_FilterPressform.Size = new System.Drawing.Size(153, 21);
            this.comboBox_FilterPressform.TabIndex = 25;
            this.comboBox_FilterPressform.ValueMember = "Id";
            this.comboBox_FilterPressform.DropDown += new System.EventHandler(this.comboBox_FilterPressform_DropDown);
            this.comboBox_FilterPressform.SelectedIndexChanged += new System.EventHandler(this.comboBox_FilterPressform_SelectedIndexChanged);
            this.comboBox_FilterPressform.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_FilterPressform_KeyUp);
            // 
            // comboBox_FilterWorkCenter
            // 
            this.comboBox_FilterWorkCenter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_FilterWorkCenter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_FilterWorkCenter.DisplayMember = "Name";
            this.comboBox_FilterWorkCenter.FormattingEnabled = true;
            this.comboBox_FilterWorkCenter.Location = new System.Drawing.Point(336, 9);
            this.comboBox_FilterWorkCenter.Name = "comboBox_FilterWorkCenter";
            this.comboBox_FilterWorkCenter.Size = new System.Drawing.Size(153, 21);
            this.comboBox_FilterWorkCenter.TabIndex = 24;
            this.comboBox_FilterWorkCenter.ValueMember = "Id";
            this.comboBox_FilterWorkCenter.DropDown += new System.EventHandler(this.comboBox_FilterWorkCenter_DropDown);
            this.comboBox_FilterWorkCenter.SelectedIndexChanged += new System.EventHandler(this.comboBox_FilterWorkCenter_SelectedIndexChanged);
            this.comboBox_FilterWorkCenter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_FilterWorkCenter_KeyUp);
            // 
            // dateTimePicker_FilterFinishPeriod
            // 
            this.dateTimePicker_FilterFinishPeriod.Location = new System.Drawing.Point(90, 35);
            this.dateTimePicker_FilterFinishPeriod.Name = "dateTimePicker_FilterFinishPeriod";
            this.dateTimePicker_FilterFinishPeriod.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker_FilterFinishPeriod.TabIndex = 23;
            this.dateTimePicker_FilterFinishPeriod.ValueChanged += new System.EventHandler(this.dateTimePicker_FilterFinishPeriod_ValueChanged);
            this.dateTimePicker_FilterFinishPeriod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_FilterFinishPeriod_KeyUp);
            // 
            // label__FilterFinishPeriod
            // 
            this.label__FilterFinishPeriod.AutoSize = true;
            this.label__FilterFinishPeriod.Location = new System.Drawing.Point(3, 38);
            this.label__FilterFinishPeriod.Name = "label__FilterFinishPeriod";
            this.label__FilterFinishPeriod.Size = new System.Drawing.Size(63, 13);
            this.label__FilterFinishPeriod.TabIndex = 22;
            this.label__FilterFinishPeriod.Text = "Дата (кон.)";
            // 
            // dateTimePicker_FilterStartPeriod
            // 
            this.dateTimePicker_FilterStartPeriod.Location = new System.Drawing.Point(90, 9);
            this.dateTimePicker_FilterStartPeriod.Name = "dateTimePicker_FilterStartPeriod";
            this.dateTimePicker_FilterStartPeriod.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker_FilterStartPeriod.TabIndex = 21;
            this.dateTimePicker_FilterStartPeriod.ValueChanged += new System.EventHandler(this.dateTimePicker_FilterStartPeriod_ValueChanged);
            this.dateTimePicker_FilterStartPeriod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_FilterStartPeriod_KeyUp);
            // 
            // label_FilterColor
            // 
            this.label_FilterColor.AutoSize = true;
            this.label_FilterColor.Location = new System.Drawing.Point(512, 12);
            this.label_FilterColor.Name = "label_FilterColor";
            this.label_FilterColor.Size = new System.Drawing.Size(32, 13);
            this.label_FilterColor.TabIndex = 11;
            this.label_FilterColor.Text = "Цвет";
            // 
            // label_FilterPressform
            // 
            this.label_FilterPressform.AutoSize = true;
            this.label_FilterPressform.Location = new System.Drawing.Point(249, 39);
            this.label_FilterPressform.Name = "label_FilterPressform";
            this.label_FilterPressform.Size = new System.Drawing.Size(76, 13);
            this.label_FilterPressform.TabIndex = 9;
            this.label_FilterPressform.Text = "Пресс-форма";
            // 
            // label_FilterWorkCenter
            // 
            this.label_FilterWorkCenter.AutoSize = true;
            this.label_FilterWorkCenter.Location = new System.Drawing.Point(249, 12);
            this.label_FilterWorkCenter.Name = "label_FilterWorkCenter";
            this.label_FilterWorkCenter.Size = new System.Drawing.Size(81, 13);
            this.label_FilterWorkCenter.TabIndex = 7;
            this.label_FilterWorkCenter.Text = "Рабочий центр";
            // 
            // label_FilterStartPeriod
            // 
            this.label_FilterStartPeriod.AutoSize = true;
            this.label_FilterStartPeriod.Location = new System.Drawing.Point(3, 12);
            this.label_FilterStartPeriod.Name = "label_FilterStartPeriod";
            this.label_FilterStartPeriod.Size = new System.Drawing.Size(62, 13);
            this.label_FilterStartPeriod.TabIndex = 5;
            this.label_FilterStartPeriod.Text = "Дата (нач.)";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox_FilterBoxNumber);
            this.panel5.Controls.Add(this.label_FilterBoxNumber);
            this.panel5.Controls.Add(this.label_FilterWorkingShift);
            this.panel5.Controls.Add(this.textBox_FilterShift);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(810, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 64);
            this.panel5.TabIndex = 8;
            // 
            // textBox_FilterBoxNumber
            // 
            this.textBox_FilterBoxNumber.Location = new System.Drawing.Point(75, 9);
            this.textBox_FilterBoxNumber.Name = "textBox_FilterBoxNumber";
            this.textBox_FilterBoxNumber.Size = new System.Drawing.Size(83, 20);
            this.textBox_FilterBoxNumber.TabIndex = 12;
            this.textBox_FilterBoxNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FilterBoxNumber_KeyUp);
            this.textBox_FilterBoxNumber.Leave += new System.EventHandler(this.textBox_FilterBoxNumber_Leave);
            // 
            // label_FilterBoxNumber
            // 
            this.label_FilterBoxNumber.AutoSize = true;
            this.label_FilterBoxNumber.Location = new System.Drawing.Point(15, 12);
            this.label_FilterBoxNumber.Name = "label_FilterBoxNumber";
            this.label_FilterBoxNumber.Size = new System.Drawing.Size(54, 13);
            this.label_FilterBoxNumber.TabIndex = 13;
            this.label_FilterBoxNumber.Text = "№ ящика";
            // 
            // label_FilterWorkingShift
            // 
            this.label_FilterWorkingShift.AutoSize = true;
            this.label_FilterWorkingShift.Location = new System.Drawing.Point(15, 38);
            this.label_FilterWorkingShift.Name = "label_FilterWorkingShift";
            this.label_FilterWorkingShift.Size = new System.Drawing.Size(40, 13);
            this.label_FilterWorkingShift.TabIndex = 15;
            this.label_FilterWorkingShift.Text = "Смена";
            // 
            // textBox_FilterShift
            // 
            this.textBox_FilterShift.Location = new System.Drawing.Point(75, 35);
            this.textBox_FilterShift.Name = "textBox_FilterShift";
            this.textBox_FilterShift.Size = new System.Drawing.Size(83, 20);
            this.textBox_FilterShift.TabIndex = 14;
            this.textBox_FilterShift.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FilterShift_KeyUp);
            this.textBox_FilterShift.Leave += new System.EventHandler(this.textBox_FilterShift_Leave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label_FilterNestNumber);
            this.panel6.Controls.Add(this.checkBox_FilterHasDefect);
            this.panel6.Controls.Add(this.textBox_FilterNestNumber);
            this.panel6.Controls.Add(this.label_FilterHasDefect);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(983, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(168, 64);
            this.panel6.TabIndex = 9;
            // 
            // label_FilterNestNumber
            // 
            this.label_FilterNestNumber.AutoSize = true;
            this.label_FilterNestNumber.Location = new System.Drawing.Point(6, 12);
            this.label_FilterNestNumber.Name = "label_FilterNestNumber";
            this.label_FilterNestNumber.Size = new System.Drawing.Size(56, 13);
            this.label_FilterNestNumber.TabIndex = 17;
            this.label_FilterNestNumber.Text = "№ гнезда";
            // 
            // checkBox_FilterHasDefect
            // 
            this.checkBox_FilterHasDefect.AutoSize = true;
            this.checkBox_FilterHasDefect.Checked = true;
            this.checkBox_FilterHasDefect.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBox_FilterHasDefect.Location = new System.Drawing.Point(83, 38);
            this.checkBox_FilterHasDefect.Name = "checkBox_FilterHasDefect";
            this.checkBox_FilterHasDefect.Size = new System.Drawing.Size(15, 14);
            this.checkBox_FilterHasDefect.TabIndex = 20;
            this.checkBox_FilterHasDefect.ThreeState = true;
            this.checkBox_FilterHasDefect.UseVisualStyleBackColor = true;
            this.checkBox_FilterHasDefect.CheckStateChanged += new System.EventHandler(this.checkBox_FilterHasDefect_CheckStateChanged);
            this.checkBox_FilterHasDefect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkBox_FilterHasDefect_KeyUp);
            // 
            // textBox_FilterNestNumber
            // 
            this.textBox_FilterNestNumber.Location = new System.Drawing.Point(83, 9);
            this.textBox_FilterNestNumber.Name = "textBox_FilterNestNumber";
            this.textBox_FilterNestNumber.Size = new System.Drawing.Size(76, 20);
            this.textBox_FilterNestNumber.TabIndex = 16;
            this.textBox_FilterNestNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FilterNestNumber_KeyUp);
            this.textBox_FilterNestNumber.Leave += new System.EventHandler(this.textBox_FilterNestNumber_Leave);
            // 
            // label_FilterHasDefect
            // 
            this.label_FilterHasDefect.AutoSize = true;
            this.label_FilterHasDefect.Location = new System.Drawing.Point(6, 38);
            this.label_FilterHasDefect.Name = "label_FilterHasDefect";
            this.label_FilterHasDefect.Size = new System.Drawing.Size(71, 13);
            this.label_FilterHasDefect.TabIndex = 19;
            this.label_FilterHasDefect.Text = "Есть дефект";
            // 
            // tabPage_Photo
            // 
            this.tabPage_Photo.BackColor = System.Drawing.Color.Silver;
            this.tabPage_Photo.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_Photo.Controls.Add(this.tableLayoutPanel_Photo);
            this.tabPage_Photo.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Photo.Name = "tabPage_Photo";
            this.tabPage_Photo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Photo.Size = new System.Drawing.Size(1160, 712);
            this.tabPage_Photo.TabIndex = 0;
            this.tabPage_Photo.Text = "Фото";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel1.Controls.Add(this.panel_WorkCenters, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel_Press_Forms, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel_Defects, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel_ClosedCells, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel_Colors, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_BoxNumber, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(878, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 683);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // panel_WorkCenters
            // 
            this.panel_WorkCenters.Controls.Add(this.button_RemoveWorkCenter);
            this.panel_WorkCenters.Controls.Add(this.comboBox_WorkCenter);
            this.panel_WorkCenters.Controls.Add(this.button_AddWorkCenter);
            this.panel_WorkCenters.Controls.Add(this.label2);
            this.panel_WorkCenters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_WorkCenters.Location = new System.Drawing.Point(3, 3);
            this.panel_WorkCenters.Name = "panel_WorkCenters";
            this.panel_WorkCenters.Size = new System.Drawing.Size(270, 44);
            this.panel_WorkCenters.TabIndex = 31;
            // 
            // button_RemoveWorkCenter
            // 
            this.button_RemoveWorkCenter.Location = new System.Drawing.Point(234, 18);
            this.button_RemoveWorkCenter.Name = "button_RemoveWorkCenter";
            this.button_RemoveWorkCenter.Size = new System.Drawing.Size(34, 23);
            this.button_RemoveWorkCenter.TabIndex = 24;
            this.button_RemoveWorkCenter.Text = "Del";
            this.button_RemoveWorkCenter.UseVisualStyleBackColor = true;
            this.button_RemoveWorkCenter.Click += new System.EventHandler(this.button_RemoveWorkCenter_Click);
            // 
            // comboBox_WorkCenter
            // 
            this.comboBox_WorkCenter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_WorkCenter.DisplayMember = "Name";
            this.comboBox_WorkCenter.FormattingEnabled = true;
            this.comboBox_WorkCenter.Location = new System.Drawing.Point(5, 20);
            this.comboBox_WorkCenter.Name = "comboBox_WorkCenter";
            this.comboBox_WorkCenter.Size = new System.Drawing.Size(160, 21);
            this.comboBox_WorkCenter.TabIndex = 17;
            this.comboBox_WorkCenter.ValueMember = "Id";
            this.comboBox_WorkCenter.DropDown += new System.EventHandler(this.comboBox_WorkCenter_DropDown);
            this.comboBox_WorkCenter.SelectedIndexChanged += new System.EventHandler(this.comboBox_WorkCenter_SelectedIndexChanged);
            // 
            // button_AddWorkCenter
            // 
            this.button_AddWorkCenter.Location = new System.Drawing.Point(167, 19);
            this.button_AddWorkCenter.Name = "button_AddWorkCenter";
            this.button_AddWorkCenter.Size = new System.Drawing.Size(65, 22);
            this.button_AddWorkCenter.TabIndex = 16;
            this.button_AddWorkCenter.Text = "Добавить";
            this.button_AddWorkCenter.UseVisualStyleBackColor = true;
            this.button_AddWorkCenter.Click += new System.EventHandler(this.button_AddWorkCenter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите рабочий центр";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button_send);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 636);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 44);
            this.panel7.TabIndex = 42;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(3, 0);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(271, 45);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "Отправить";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // panel_Press_Forms
            // 
            this.panel_Press_Forms.Controls.Add(this.button_RemovePressform);
            this.panel_Press_Forms.Controls.Add(this.comboBox_Pressform);
            this.panel_Press_Forms.Controls.Add(this.button_AddPressform);
            this.panel_Press_Forms.Controls.Add(this.label4);
            this.panel_Press_Forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Press_Forms.Location = new System.Drawing.Point(3, 53);
            this.panel_Press_Forms.Name = "panel_Press_Forms";
            this.panel_Press_Forms.Size = new System.Drawing.Size(270, 44);
            this.panel_Press_Forms.TabIndex = 32;
            // 
            // button_RemovePressform
            // 
            this.button_RemovePressform.Location = new System.Drawing.Point(234, 18);
            this.button_RemovePressform.Name = "button_RemovePressform";
            this.button_RemovePressform.Size = new System.Drawing.Size(34, 23);
            this.button_RemovePressform.TabIndex = 24;
            this.button_RemovePressform.Text = "Del";
            this.button_RemovePressform.UseVisualStyleBackColor = true;
            this.button_RemovePressform.Click += new System.EventHandler(this.button_RemovePressform_Click);
            // 
            // comboBox_Pressform
            // 
            this.comboBox_Pressform.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Pressform.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Pressform.DisplayMember = "Name";
            this.comboBox_Pressform.FormattingEnabled = true;
            this.comboBox_Pressform.Location = new System.Drawing.Point(5, 20);
            this.comboBox_Pressform.Name = "comboBox_Pressform";
            this.comboBox_Pressform.Size = new System.Drawing.Size(160, 21);
            this.comboBox_Pressform.TabIndex = 21;
            this.comboBox_Pressform.ValueMember = "Id";
            this.comboBox_Pressform.DropDown += new System.EventHandler(this.comboBox_Pressform_DropDown);
            this.comboBox_Pressform.SelectedIndexChanged += new System.EventHandler(this.comboBox_Pressform_SelectedIndexChanged);
            // 
            // button_AddPressform
            // 
            this.button_AddPressform.Location = new System.Drawing.Point(167, 19);
            this.button_AddPressform.Name = "button_AddPressform";
            this.button_AddPressform.Size = new System.Drawing.Size(65, 22);
            this.button_AddPressform.TabIndex = 20;
            this.button_AddPressform.Text = "Добавить";
            this.button_AddPressform.UseVisualStyleBackColor = true;
            this.button_AddPressform.Click += new System.EventHandler(this.button_AddPressform_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Номер пресс-формы";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_Comments);
            this.panel4.Controls.Add(this.textBox_Comments);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 323);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 307);
            this.panel4.TabIndex = 14;
            // 
            // label_Comments
            // 
            this.label_Comments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Comments.AutoSize = true;
            this.label_Comments.Location = new System.Drawing.Point(5, 4);
            this.label_Comments.Name = "label_Comments";
            this.label_Comments.Size = new System.Drawing.Size(209, 13);
            this.label_Comments.TabIndex = 10;
            this.label_Comments.Text = "Комментарии*  ( необязательное поле )";
            // 
            // textBox_Comments
            // 
            this.textBox_Comments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Comments.Location = new System.Drawing.Point(5, 22);
            this.textBox_Comments.Multiline = true;
            this.textBox_Comments.Name = "textBox_Comments";
            this.textBox_Comments.Size = new System.Drawing.Size(263, 282);
            this.textBox_Comments.TabIndex = 9;
            // 
            // panel_Defects
            // 
            this.panel_Defects.Controls.Add(this.button_ClearDefect);
            this.panel_Defects.Controls.Add(this.comboBox_Defect);
            this.panel_Defects.Controls.Add(this.label7);
            this.panel_Defects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Defects.Location = new System.Drawing.Point(3, 203);
            this.panel_Defects.Name = "panel_Defects";
            this.panel_Defects.Size = new System.Drawing.Size(270, 44);
            this.panel_Defects.TabIndex = 21;
            // 
            // button_ClearDefect
            // 
            this.button_ClearDefect.Location = new System.Drawing.Point(234, 21);
            this.button_ClearDefect.Margin = new System.Windows.Forms.Padding(0);
            this.button_ClearDefect.Name = "button_ClearDefect";
            this.button_ClearDefect.Size = new System.Drawing.Size(33, 21);
            this.button_ClearDefect.TabIndex = 30;
            this.button_ClearDefect.Text = "X";
            this.button_ClearDefect.UseVisualStyleBackColor = true;
            this.button_ClearDefect.Click += new System.EventHandler(this.button_ClearDefect_Click);
            // 
            // comboBox_Defect
            // 
            this.comboBox_Defect.DisplayMember = "Name";
            this.comboBox_Defect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Defect.FormattingEnabled = true;
            this.comboBox_Defect.Location = new System.Drawing.Point(5, 21);
            this.comboBox_Defect.Name = "comboBox_Defect";
            this.comboBox_Defect.Size = new System.Drawing.Size(226, 21);
            this.comboBox_Defect.TabIndex = 29;
            this.comboBox_Defect.ValueMember = "Id";
            this.comboBox_Defect.DropDown += new System.EventHandler(this.comboBox_Defect_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Вид дефекта";
            // 
            // panel_ClosedCells
            // 
            this.panel_ClosedCells.Controls.Add(this.label_numbClCells);
            this.panel_ClosedCells.Controls.Add(this.button_closedCells);
            this.panel_ClosedCells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ClosedCells.Location = new System.Drawing.Point(3, 253);
            this.panel_ClosedCells.Name = "panel_ClosedCells";
            this.panel_ClosedCells.Size = new System.Drawing.Size(270, 64);
            this.panel_ClosedCells.TabIndex = 13;
            // 
            // label_numbClCells
            // 
            this.label_numbClCells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_numbClCells.AutoSize = true;
            this.label_numbClCells.Location = new System.Drawing.Point(5, 40);
            this.label_numbClCells.Name = "label_numbClCells";
            this.label_numbClCells.Size = new System.Drawing.Size(0, 13);
            this.label_numbClCells.TabIndex = 14;
            // 
            // button_closedCells
            // 
            this.button_closedCells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_closedCells.BackColor = System.Drawing.Color.White;
            this.button_closedCells.Location = new System.Drawing.Point(5, 3);
            this.button_closedCells.Name = "button_closedCells";
            this.button_closedCells.Size = new System.Drawing.Size(262, 30);
            this.button_closedCells.TabIndex = 4;
            this.button_closedCells.Text = "Закрытые гнёзда";
            this.button_closedCells.UseVisualStyleBackColor = false;
            this.button_closedCells.Click += new System.EventHandler(this.button_closedCells_Click);
            // 
            // panel_Colors
            // 
            this.panel_Colors.Controls.Add(this.button_RemoveColor);
            this.panel_Colors.Controls.Add(this.comboBox_Color);
            this.panel_Colors.Controls.Add(this.button_AddColor);
            this.panel_Colors.Controls.Add(this.label5);
            this.panel_Colors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Colors.Location = new System.Drawing.Point(3, 103);
            this.panel_Colors.Name = "panel_Colors";
            this.panel_Colors.Size = new System.Drawing.Size(270, 44);
            this.panel_Colors.TabIndex = 33;
            // 
            // button_RemoveColor
            // 
            this.button_RemoveColor.Location = new System.Drawing.Point(234, 18);
            this.button_RemoveColor.Name = "button_RemoveColor";
            this.button_RemoveColor.Size = new System.Drawing.Size(34, 23);
            this.button_RemoveColor.TabIndex = 23;
            this.button_RemoveColor.Text = "Del";
            this.button_RemoveColor.UseVisualStyleBackColor = true;
            this.button_RemoveColor.Click += new System.EventHandler(this.button_RemoveColor_Click);
            // 
            // comboBox_Color
            // 
            this.comboBox_Color.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Color.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Color.DisplayMember = "Name";
            this.comboBox_Color.FormattingEnabled = true;
            this.comboBox_Color.Location = new System.Drawing.Point(5, 20);
            this.comboBox_Color.Name = "comboBox_Color";
            this.comboBox_Color.Size = new System.Drawing.Size(160, 21);
            this.comboBox_Color.TabIndex = 22;
            this.comboBox_Color.ValueMember = "Id";
            this.comboBox_Color.DropDown += new System.EventHandler(this.comboBox_Color_DropDown);
            this.comboBox_Color.SelectedIndexChanged += new System.EventHandler(this.comboBox_Color_SelectedIndexChanged);
            // 
            // button_AddColor
            // 
            this.button_AddColor.Location = new System.Drawing.Point(167, 19);
            this.button_AddColor.Name = "button_AddColor";
            this.button_AddColor.Size = new System.Drawing.Size(65, 22);
            this.button_AddColor.TabIndex = 21;
            this.button_AddColor.Text = "Добавить";
            this.button_AddColor.UseVisualStyleBackColor = true;
            this.button_AddColor.Click += new System.EventHandler(this.button_AddColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Цвет";
            // 
            // panel_BoxNumber
            // 
            this.panel_BoxNumber.Controls.Add(this.label6);
            this.panel_BoxNumber.Controls.Add(this.textBox_boxNumber);
            this.panel_BoxNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BoxNumber.Location = new System.Drawing.Point(3, 153);
            this.panel_BoxNumber.Name = "panel_BoxNumber";
            this.panel_BoxNumber.Size = new System.Drawing.Size(270, 44);
            this.panel_BoxNumber.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Номер короба";
            // 
            // textBox_boxNumber
            // 
            this.textBox_boxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_boxNumber.Location = new System.Drawing.Point(5, 20);
            this.textBox_boxNumber.Name = "textBox_boxNumber";
            this.textBox_boxNumber.Size = new System.Drawing.Size(262, 20);
            this.textBox_boxNumber.TabIndex = 8;
            // 
            // tableLayoutPanel_Photo
            // 
            this.tableLayoutPanel_Photo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Photo.ColumnCount = 1;
            this.tableLayoutPanel_Photo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Photo.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel_Photo.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel_Photo.Controls.Add(this.panel_Photo, 0, 1);
            this.tableLayoutPanel_Photo.Location = new System.Drawing.Point(32, 0);
            this.tableLayoutPanel_Photo.Name = "tableLayoutPanel_Photo";
            this.tableLayoutPanel_Photo.RowCount = 3;
            this.tableLayoutPanel_Photo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Photo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Photo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_Photo.Size = new System.Drawing.Size(810, 683);
            this.tableLayoutPanel_Photo.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDown_Nest);
            this.panel2.Controls.Add(this.comboBox_User);
            this.panel2.Controls.Add(this.label_Nest);
            this.panel2.Controls.Add(this.label_User);
            this.panel2.Controls.Add(this.labelShift);
            this.panel2.Controls.Add(this.textBox_Shift);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 44);
            this.panel2.TabIndex = 0;
            // 
            // numericUpDown_Nest
            // 
            this.numericUpDown_Nest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_Nest.Location = new System.Drawing.Point(731, 18);
            this.numericUpDown_Nest.Name = "numericUpDown_Nest";
            this.numericUpDown_Nest.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_Nest.TabIndex = 39;
            // 
            // comboBox_User
            // 
            this.comboBox_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_User.DisplayMember = "FullName";
            this.comboBox_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_User.Enabled = false;
            this.comboBox_User.FormattingEnabled = true;
            this.comboBox_User.Location = new System.Drawing.Point(134, 18);
            this.comboBox_User.Name = "comboBox_User";
            this.comboBox_User.Size = new System.Drawing.Size(207, 21);
            this.comboBox_User.TabIndex = 40;
            this.comboBox_User.ValueMember = "Id";
            // 
            // label_Nest
            // 
            this.label_Nest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Nest.AutoSize = true;
            this.label_Nest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Nest.Location = new System.Drawing.Point(638, 18);
            this.label_Nest.Name = "label_Nest";
            this.label_Nest.Size = new System.Drawing.Size(87, 20);
            this.label_Nest.TabIndex = 35;
            this.label_Nest.Text = "Гнездо № ";
            // 
            // label_User
            // 
            this.label_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_User.AutoSize = true;
            this.label_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_User.Location = new System.Drawing.Point(3, 19);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(125, 20);
            this.label_User.TabIndex = 5;
            this.label_User.Text = "Пользователь:";
            // 
            // labelShift
            // 
            this.labelShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShift.Location = new System.Drawing.Point(347, 19);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(62, 20);
            this.labelShift.TabIndex = 34;
            this.labelShift.Text = "Смена:";
            // 
            // textBox_Shift
            // 
            this.textBox_Shift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Shift.Location = new System.Drawing.Point(415, 19);
            this.textBox_Shift.Name = "textBox_Shift";
            this.textBox_Shift.Size = new System.Drawing.Size(88, 20);
            this.textBox_Shift.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_TurnOnCamera);
            this.panel3.Controls.Add(this.button_Replacement);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 636);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 44);
            this.panel3.TabIndex = 1;
            // 
            // button_TurnOnCamera
            // 
            this.button_TurnOnCamera.BackColor = System.Drawing.Color.White;
            this.button_TurnOnCamera.Location = new System.Drawing.Point(-3, 0);
            this.button_TurnOnCamera.Name = "button_TurnOnCamera";
            this.button_TurnOnCamera.Size = new System.Drawing.Size(153, 48);
            this.button_TurnOnCamera.TabIndex = 23;
            this.button_TurnOnCamera.Text = "Включить камеру";
            this.button_TurnOnCamera.UseVisualStyleBackColor = false;
            this.button_TurnOnCamera.Click += new System.EventHandler(this.button_TurnOnCamera_Click);
            // 
            // button_Replacement
            // 
            this.button_Replacement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Replacement.BackColor = System.Drawing.Color.White;
            this.button_Replacement.Location = new System.Drawing.Point(651, -1);
            this.button_Replacement.Name = "button_Replacement";
            this.button_Replacement.Size = new System.Drawing.Size(156, 46);
            this.button_Replacement.TabIndex = 3;
            this.button_Replacement.Text = "Поменять фото";
            this.button_Replacement.UseVisualStyleBackColor = false;
            this.button_Replacement.Click += new System.EventHandler(this.button_replacement_Click);
            // 
            // panel_Photo
            // 
            this.panel_Photo.Controls.Add(this.pictureBox_Photo);
            this.panel_Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Photo.Location = new System.Drawing.Point(3, 53);
            this.panel_Photo.Name = "panel_Photo";
            this.panel_Photo.Size = new System.Drawing.Size(804, 577);
            this.panel_Photo.TabIndex = 2;
            // 
            // pictureBox_Photo
            // 
            this.pictureBox_Photo.BackColor = System.Drawing.Color.White;
            this.pictureBox_Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Photo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Photo.Name = "pictureBox_Photo";
            this.pictureBox_Photo.Size = new System.Drawing.Size(804, 577);
            this.pictureBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Photo.TabIndex = 0;
            this.pictureBox_Photo.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_Photo);
            this.tabControl.Controls.Add(this.tabPage_Search);
            this.tabControl.Location = new System.Drawing.Point(-1, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1168, 738);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1161, 731);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.Text = "Microscop 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.tabPage_Search.ResumeLayout(false);
            this.panel_downloadImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_downloadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage_Photo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_WorkCenters.ResumeLayout(false);
            this.panel_WorkCenters.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel_Press_Forms.ResumeLayout(false);
            this.panel_Press_Forms.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_Defects.ResumeLayout(false);
            this.panel_Defects.PerformLayout();
            this.panel_ClosedCells.ResumeLayout(false);
            this.panel_ClosedCells.PerformLayout();
            this.panel_Colors.ResumeLayout(false);
            this.panel_Colors.PerformLayout();
            this.panel_BoxNumber.ResumeLayout(false);
            this.panel_BoxNumber.PerformLayout();
            this.tableLayoutPanel_Photo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Nest)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel_Photo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesdbDataSetBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_Search;
        private System.Windows.Forms.TabPage tabPage_Photo;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Button button_closedCells;
        private System.Windows.Forms.Button button_Replacement;
        private System.Windows.Forms.PictureBox pictureBox_Photo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel panel_ClosedCells;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label_Comments;
        private System.Windows.Forms.TextBox textBox_Comments;
        private System.Windows.Forms.TextBox textBox_boxNumber;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.PictureBox pictureBox_downloadImage;
        private System.Windows.Forms.BindingSource imagesdbDataSetBindingSource;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_TurnOnCamera;
        private System.Windows.Forms.DataGridView dataGridView_DB;
        private System.Windows.Forms.Panel panel_Defects;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_BoxNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Colors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_Press_Forms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_WorkCenters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel panel_downloadImage;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.Label label_FilterStartPeriod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_FilterShift;
        private System.Windows.Forms.Label label_FilterWorkingShift;
        private System.Windows.Forms.TextBox textBox_FilterBoxNumber;
        private System.Windows.Forms.Label label_FilterBoxNumber;
        private System.Windows.Forms.Label label_FilterColor;
        private System.Windows.Forms.Label label_FilterPressform;
        private System.Windows.Forms.Label label_FilterWorkCenter;
        private System.Windows.Forms.Label label_FilterHasDefect;
        private System.Windows.Forms.TextBox textBox_FilterNestNumber;
        private System.Windows.Forms.Label label_FilterNestNumber;
        private System.Windows.Forms.TextBox textBox_Shift;
        private System.Windows.Forms.Label label_Nest;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.NumericUpDown numericUpDown_Nest;
        private System.Windows.Forms.ComboBox comboBox_User;
        private System.Windows.Forms.CheckBox checkBox_FilterHasDefect;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FilterStartPeriod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Photo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_Photo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_AddWorkCenter;
        private System.Windows.Forms.Button button_AddColor;
        private System.Windows.Forms.Button button_AddPressform;
        private System.Windows.Forms.ComboBox comboBox_Defect;
        private System.Windows.Forms.Button button_ClearDefect;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FilterFinishPeriod;
        private System.Windows.Forms.Label label__FilterFinishPeriod;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBox_Color;
        private System.Windows.Forms.ComboBox comboBox_Pressform;
        private System.Windows.Forms.ComboBox comboBox_WorkCenter;
        private System.Windows.Forms.ComboBox comboBox_FilterColor;
        private System.Windows.Forms.ComboBox comboBox_FilterPressform;
        private System.Windows.Forms.ComboBox comboBox_FilterWorkCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pressform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn NestNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HasDefect;
        private System.Windows.Forms.Label label_numbClCells;
        private System.Windows.Forms.Button button_FilterColor_Remove;
        private System.Windows.Forms.Button button_FilterPressform_Remove;
        private System.Windows.Forms.Button button_FilterWorkCenter_Remove;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_DeleteRow;
        private System.Windows.Forms.Button button_RemoveWorkCenter;
        private System.Windows.Forms.Button button_RemovePressform;
        private System.Windows.Forms.Button button_RemoveColor;
    }
}

