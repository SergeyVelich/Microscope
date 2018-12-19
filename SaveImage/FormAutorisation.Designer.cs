namespace SaveImage
{
    partial class FormAutorization
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
            this.panel_Enter = new System.Windows.Forms.Panel();
            this.comboBox_Login = new System.Windows.Forms.ComboBox();
            this.button_Enter = new System.Windows.Forms.Button();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.panel_Enter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Enter
            // 
            this.panel_Enter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Enter.Controls.Add(this.comboBox_Login);
            this.panel_Enter.Controls.Add(this.button_Enter);
            this.panel_Enter.Controls.Add(this.checkBox_ShowPassword);
            this.panel_Enter.Controls.Add(this.label_Password);
            this.panel_Enter.Controls.Add(this.textBox_Password);
            this.panel_Enter.Controls.Add(this.label_Login);
            this.panel_Enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Enter.Location = new System.Drawing.Point(0, 0);
            this.panel_Enter.Name = "panel_Enter";
            this.panel_Enter.Size = new System.Drawing.Size(284, 261);
            this.panel_Enter.TabIndex = 1;
            // 
            // comboBox_Login
            // 
            this.comboBox_Login.FormattingEnabled = true;
            this.comboBox_Login.Location = new System.Drawing.Point(86, 60);
            this.comboBox_Login.Name = "comboBox_Login";
            this.comboBox_Login.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Login.TabIndex = 3;
            this.comboBox_Login.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.comboBox_Login_PreviewKeyDown);
            // 
            // button_Enter
            // 
            this.button_Enter.Location = new System.Drawing.Point(86, 164);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(101, 34);
            this.button_Enter.TabIndex = 1;
            this.button_Enter.Text = "Войти";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(86, 124);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(114, 17);
            this.checkBox_ShowPassword.TabIndex = 1;
            this.checkBox_ShowPassword.Text = "Показать пароль";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(35, 105);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(45, 13);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Пароль";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(86, 98);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(163, 20);
            this.textBox_Password.TabIndex = 1;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(35, 60);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(38, 13);
            this.label_Login.TabIndex = 1;
            this.label_Login.Text = "Логин";
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel_Enter);
            this.Name = "FormAutorization";
            this.Text = "Авторизация";
            this.panel_Enter.ResumeLayout(false);
            this.panel_Enter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Enter;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.ComboBox comboBox_Login;
    }
}