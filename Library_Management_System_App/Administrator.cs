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

        public bool verified = false;

        public Administrator()
        {
            InitializeComponent();
        }
        public void hideItems()
        {
            menuStrip1.Items[0].Visible = false;
            menuStrip1.Items[1].Visible = false;
            menuStrip1.Items[2].Visible = false;
        }

        public void showItems()
        {
            menuStrip1.Items[0].Visible = true;
            menuStrip1.Items[1].Visible = true;
            menuStrip1.Items[2].Visible = true;
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
            hideItems();
            Login_Form login = new Login_Form();
            login.MdiParent = this;
            //login.WindowState = FormWindowState.Maximized;
            login.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verified = false;
            hideItems();
            Login_Form login = new Login_Form();
            login.MdiParent = this;
            //login.WindowState = FormWindowState.Maximized;
            login.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Book book = new Add_Book();
            book.MdiParent = this;
            //book.WindowState = FormWindowState.Maximized;
            book.Show();
        }

        private void periodicalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Periodical paper = new Periodical();
            paper.MdiParent = this;
            //paper.WindowState = FormWindowState.Maximized;
            paper.Show();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_In_Book returnBk = new Check_In_Book();
            returnBk.MdiParent = this;
            //returnBk.WindowState = FormWindowState.Maximized;
            returnBk.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_Out_Book borrowBk = new Check_Out_Book();
            borrowBk.MdiParent = this;
            //borrowBk.WindowState = FormWindowState.Maximized;
            borrowBk.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Account newAcc = new Create_Account();
            newAcc.MdiParent = this;
            //newAcc.WindowState = FormWindowState.Maximized;
            newAcc.Show();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disable_UserAcc disabled = new Disable_UserAcc();
            disabled.MdiParent = this;
            //disabled.WindowState = FormWindowState.Maximized;
            disabled.Show();
        }

        private void memberInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member_Information users = new Member_Information();
            users.MdiParent = this;
            //users.WindowState = FormWindowState.Maximized;
            users.Show();
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset_Password reset = new Reset_Password();
            reset.MdiParent = this;
            //reset.WindowState = FormWindowState.Maximized;
            reset.Show();
        }
    }
}
