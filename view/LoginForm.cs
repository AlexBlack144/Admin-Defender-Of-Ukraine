using Game_Kursak_Admin.controller;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Game_Kursak_Admin.view
{
    public partial class LoginForm : Form
    {
        Controller controller = new Controller();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            controller.AuthorizationCheck(textBox_login.Text, textBox_password.Text, this, formAdmin);
        }


        private void checkBox_See_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_See.Checked == true)
            {
                textBox_password.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '*';
            }
        }
    }
}
