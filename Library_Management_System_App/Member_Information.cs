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
    public partial class Member_Information : Form
    {
        public Member_Information()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            this.studentTb.Text = "";
            this.lnameTb.Text = "";
            this.fnameTb.Text = "";
            this.addressTb.Text = "";
            this.classTb.Text = "";
            this.studentTb.Text = "";
        }
    }
}
