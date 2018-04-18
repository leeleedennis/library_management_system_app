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
    public partial class Disable_UserAcc : Form
    {
        LibraryManagementEntities ctx = new LibraryManagementEntities();
        

        public Disable_UserAcc()
        {
            InitializeComponent();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserDataGridView_DoubleClick(object sender, EventArgs e)
        {
        }

        void UpdateDataViewGrid()
        {
            UserDataGridView.DataSource = ctx.Users.ToList<User>();
        }


        private void Disable_UserAcc_Load(object sender, EventArgs e)
        {
            UpdateDataViewGrid();
            ctx = new LibraryManagementEntities();

        }

        private void userdeletebtn_Click(object sender, EventArgs e)
        {
            User model3 = new User();

            if (UserDataGridView.CurrentRow.Index != -1)
            {
                model3.Id = Convert.ToInt32(UserDataGridView.CurrentRow.Cells["userid"].Value);
                model3.User_Name = Convert.ToString(UserDataGridView.CurrentRow.Cells["username"].Value);

                model3 = ctx.Users.Where(q => q.Id == model3.Id).FirstOrDefault();


                try
                {

                    MessageBox.Show("Do you really want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    ctx.Entry(model3).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();

                    UpdateDataViewGrid();
                  
                    MessageBox.Show("Record was deleted successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                
            }
        }

        private void disableBtn_Click(object sender, EventArgs e)
        {
            Reset_Password reset = new Reset_Password();
                        
            reset.Show();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            UserDataGridView.DataSource = ctx.Users.Where(q => q.User_Name.Contains(searchBox.Text)).ToList();
        }

        private void UserDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = null;

            if (UserDataGridView.SelectedRows.Count > 0)
            {
                selectedRow = UserDataGridView.SelectedRows[0];
            }

            if (selectedRow == null)
                return;

            try
            {
                User model3 = new User
                {
                    User_Name = selectedRow.Cells["username"].Value.ToString(),
                    Password = selectedRow.Cells["password"].Value.ToString(),
                    Type = selectedRow.Cells["type"].Value.ToString(),
                   

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
