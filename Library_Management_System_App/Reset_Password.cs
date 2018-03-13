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
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void resetButtonresetButton_Click(object sender, EventArgs e)
        {
            
            if (confirmPasswordTb.Text == newpasswordTb.Text)
            {
                MessageBox.Show("Password changed successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password does not match.");
                this.newpasswordTb.Text = "";
                this.confirmPasswordTb.Text = "";
                this.oldpasswordTb.Text = "";
            }
        }

        private void cancelresetButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
