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
    public partial class User_Account : Form
    {
        public User_Account()
        {
            InitializeComponent();
        }

        private void createuserbutton_Click(object sender, EventArgs e)
        {
            Create_Account create = new Create_Account();
            create.Show();
            this.Hide();
        }

        private void canceluserbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
