using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_App
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private int status;
        public void setStatus(int num)
        {
            status = num;
        }
        public int getStatus()
        {
            return status;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var username = "admin";
            var password = "password";

            if (username == usernameTb.Text && password == passwordTb.Text)
            {
                this.Close();
                setStatus(1);
            }
            else
            {
                MessageBox.Show("Password or Username Incorrect.");
                this.usernameTb.Text = "";
                this.passwordTb.Text = "";
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void forgetLbl_Click(object sender, EventArgs e)
        {
            Reset_Password reset = new Reset_Password();
            reset.Show();
            this.Hide();

        }


        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
