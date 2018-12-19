using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveImage
{
    public partial class FormAutorization : Form
    {
        AuthentificationManager authManager = new AuthentificationManager();

        public FormAutorization()
        {
            InitializeComponent();
            FillLoginsList();
        }

        public void FillLoginsList()
        {
            comboBox_Login.DataSource = authManager.GetLoginsList();
            comboBox_Login.SelectedIndex = -1;
        }

        public void Authentificate()
        {
            AuthRequestInfo info = new AuthRequestInfo(comboBox_Login.Text, textBox_Password.Text);
            try
            {
                authManager.OnAuthRequest(info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (authManager.ActiveUser != null)
            {
                Close();
                Thread thread = new Thread(() => Application.Run(new FormMain(authManager.ActiveUser)));                
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        protected override bool ProcessTabKey(bool forward)
        {
            return forward ? textBox_Password.Focus() : comboBox_Login.Focus();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            //comboBox_Login.Text = "admin";
            //textBox_Password.Text = "123456";

            if (comboBox_Login.Text == String.Empty)
            {
                MessageBox.Show("Заполните логин", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Authentificate();
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = !textBox_Password.UseSystemPasswordChar;
        }

        private void comboBox_Login_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                textBox_Password.Select();
            }
        }
    }
}
