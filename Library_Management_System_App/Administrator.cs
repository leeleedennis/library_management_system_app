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
    public partial class Administrator : Form
    {
        private int childFormNumber = 0;

        Login_Form login = new Login_Form();

        public Administrator()
        {
            InitializeComponent();
        }

        public void showItems()
        {
            menuStrip1.Items[1].Visible = true;
            menuStrip1.Items[2].Visible = true;
            menuStrip1.Items[3].Visible = true;
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            if (login.getStatus() != 1)
            {
                menuStrip1.Items[1].Visible = false;
                menuStrip1.Items[2].Visible = false;
                menuStrip1.Items[3].Visible = false;
                menuStrip1.Items[4].Visible = false;
            }
            else
            {
                menuStrip1.Items[0].Visible = false;
                menuStrip1.Items[1].Visible = false;
                menuStrip1.Items[2].Visible = false;
                menuStrip1.Items[3].Visible = false;
                menuStrip1.Items[4].Visible = false;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Items[0].Visible = false;
            menuStrip1.Items[4].Visible = true;
            //Login_Form login = new Login_Form();
            login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
            login.Show();
        }


        private void enterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login.getStatus() == 1)
            {
                menuStrip1.Items[0].Visible = false;
                menuStrip1.Items[4].Visible = false;
                showItems();
            }
            else
            {
                menuStrip1.Items[0].Visible = true;
                MessageBox.Show("You must Login before entering the Library");
            }
        }
    }
}
/