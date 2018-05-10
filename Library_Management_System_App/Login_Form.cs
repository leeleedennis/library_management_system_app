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
        LibraryManagementEntities ctx = new LibraryManagementEntities();

        public String access;

        public Login_Form()
        {
            InitializeComponent();
        }

        public string username_text;
        public string password_text; 
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
            username_text = usernameTb.Text;
            password_text = passwordTb.Text;
            
            password_text = EasyEncryption.SHA.ComputeSHA256Hash(password_text);

            var IsAnyUser = ctx.Users.Any(q => q.User_Name == username_text && q.Password == password_text && q.Type != "Student");

            
            if (IsAnyUser)
            {
                
                var parent = (Administrator)MdiParent;
                parent.isAuth = true;
                
                this.Close();
                setStatus(1);

            }
            else
            {
                MessageBox.Show("Credentials provided are not valid");
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.usernameTb.Text = "";
            this.passwordTb.Text = "";
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
