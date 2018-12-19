namespace SaveImage
{
    partial class FormTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_closedCells = new System.Windows.Forms.DataGridView();
            this.label_titleCells = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_closedCells)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_closedCells
            // 
            this.dataGridView_closedCells.AllowUserToAddRows = false;
            this.dataGridView_closedCells.AllowUserToDeleteRows = false;
            this.dataGridView_closedCells.AllowUserToResizeColumns = false;
            this.dataGridView_closedCells.AllowUserToResizeRows = false;
            this.dataGridView_closedCells.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_closedCells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_closedCells.ColumnHeadersVisible = false;
            this.dataGridView_closedCells.Location = new System.Drawing.Point(246, 74);
            this.dataGridView_closedCells.Name = "dataGridView_closedCells";
            this.dataGridView_closedCells.RowHeadersVisible = false;
            this.dataGridView_closedCells.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_closedCells.Size = new System.Drawing.Size(693, 494);
            this.dataGridView_closedCells.TabIndex = 0;
            this.dataGridView_closedCells.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_closedCells_CellContentClick);
            // 
            // label_titleCells
            // 
            this.label_titleCells.AutoSize = true;
            this.label_titleCells.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_titleCells.Location = new System.Drawing.Point(426, 38);
            this.label_titleCells.Name = "label_titleCells";
            this.label_titleCells.Size = new System.Drawing.Size(258, 20);
            this.label_titleCells.TabIndex = 1;
            this.label_titleCells.Text = "Выберите \"закрытые гнёзда\"";
            // 
            // button_return
            // 
            this.button_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_return.Location = new System.Drawing.Point(919, 574);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(212, 54);
            this.button_return.TabIndex = 2;
            this.button_return.Text = "Вернуться";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Очистить гнезда";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1180, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.label_titleCells);
            this.Controls.Add(this.dataGridView_closedCells);
            this.Name = "FormTable";
            this.Text = "FormTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_closedCells)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_closedCells;
        private System.Windows.Forms.Label label_titleCells;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button1;
    }
}