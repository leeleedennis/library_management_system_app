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
    public partial class Create_Account : Form
    {
        LibraryManagementEntities ctx = new LibraryManagementEntities();

        public Create_Account()
        {
            InitializeComponent();
        }


        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAccbutton_Click(object sender, EventArgs e)
        {
            var username_box = UserBox.Text;
            var password_box = PasswordtextBox.Text;
            var type = typetb.Text;
            var datecreated = DateTime.Now;
            var createdby = ((Administrator)MdiParent).accountName;
            var confirmpass = confirmpasstextBox.Text;

            if (String.IsNullOrEmpty(username_box) || String.IsNullOrEmpty(password_box))
            {
                MessageBox.Show("Please Enter Valid Information");
            }
            else
            {
                try
                {

                    var user = new User

                    {
                        Type = type,
                        User_Name = username_box,
                        Password = EasyEncryption.SHA.ComputeSHA256Hash(password_box),
                        Date_Created = datecreated,
                        Created_by = createdby,
                    };

                    ctx.Users.Add(user);
                    ctx.SaveChanges();

                    if (password_box == confirmpass)
                    {
                        MessageBox.Show("Passwords Matched");
                        
                    }
                    else
                    {
                        MessageBox.Show("Password Error");
                    }

                    MessageBox.Show("New user account was created");
                   
                     this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString());
                    throw;
                }
            }

           



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
