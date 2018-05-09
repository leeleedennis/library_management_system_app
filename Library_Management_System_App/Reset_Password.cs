using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_App
{
    public partial class Reset_Password : Form
    {
        LibraryManagementEntities ctx = new LibraryManagementEntities();

        public Reset_Password()
        {
            InitializeComponent();
        }

        private void resetButtonresetButton_Click(object sender, EventArgs e)
        {
            var username_value = pusernameTb1.Text;
            var oldpass_value = oldpasstb.Text;
            var newpassword_value = newpasswordTb.Text;
            var confirmpass_value = confirmPasswordTb.Text;

            oldpass_value = EasyEncryption.SHA.ComputeSHA256Hash(oldpass_value);
            newpassword_value = EasyEncryption.SHA.ComputeSHA256Hash(newpassword_value);
            confirmpass_value = EasyEncryption.SHA.ComputeSHA256Hash(confirmpass_value);

            
             //u = ctx.Users.FirstOrDefault(q => q.Password == oldpass_value && q.User_Name == username_value);

            //User u = new User();
            
            if (username_value == null)
            {
                MessageBox.Show("username field empty");
            }
            else
            {
                var u = ctx.Users.FirstOrDefault(q => q.Password == oldpass_value && q.User_Name == username_value);

                if(u != null)
                {
                    try
                    {
                        u.Password = newpassword_value;
                        ctx.SaveChanges();
                        MessageBox.Show("Password Change Confirmed!"); 
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }
                else
                {
                    MessageBox.Show("username not found!");
                }
            }
            
        }

        private void cancelresetButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {
            
        }
    }
}
