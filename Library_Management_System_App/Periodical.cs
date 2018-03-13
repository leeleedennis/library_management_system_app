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
    public partial class Periodical : Form
    {
        public Periodical()
        {
            InitializeComponent();
        }

        private void clearperiodbutton_Click(object sender, EventArgs e)
        {
            this.categoryTb.Text = "";
            this.pagenumberTb.Text "";
            this.periodicalnameTb.Text = "";
            this.yearTb.Text = "";
            this.isbnTb.Text = "";
            this.shelfnumberTb.Text = "";
            this.volumenumberTb.Text = "";
            this.searchTb.Text = "";
        }
    }
}
