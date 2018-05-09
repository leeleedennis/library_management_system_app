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
    public partial class Check_In_Book : Form
    {
        public Check_In_Book()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Successfully.");
        }

        private void fineamountTb_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fineDateLbl_Click(object sender, EventArgs e)
        {

        }

        private void checkInMemberIDLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
