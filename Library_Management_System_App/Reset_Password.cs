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
                User update = new User();
                var u = ctx.Users.Where(q => q.Password.Contains(oldpass_value) && q.User_Name.Contains(username_value));
 
                
                //u = ctx.Users.(q => q.Password == oldpass_value && q.User_Name == username_value);
                if (u == null)
                {
                    MessageBox.Show("username not found");
                }else
                //if
                //(username_value == u.User_Name && newpassword_value == confirmpass_value && oldpass_value == u.Password)
                {
                try
                {
                    //This is my connection string i have assigned the database file address path  
                    string MyConnection2 = "Data Source=SMNT92.SHAUN;Initial Catalog=LibraryManagement;Integrated Security=True";
                    //This is my update query in which i am taking input from the user through windows forms and update the record.  
                    string Query = "update LibraryManagement.User set Password= p2 where Password = oldpass_value";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                    SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                    //SqlDataReader MyReader2;
                    MyConn2.Open();
                    MyCommand2.Parameters.Contains(oldpass_value);
                    MyCommand2.Parameters.AddWithValue("p2", newpassword_value);
                    MyCommand2.ExecuteNonQuery();
                    MessageBox.Show("Password Change Confirmed!");
                    /*MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    while (MyReader2.Read())
                    {
                    }*/
                    MyConn2.Close();//Connection closed here  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                /*
                u.Password = newpassword_value;
                    ctx.Entry(u).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                    MessageBox.Show("Password Change Confirmed!");*/
                    this.Close();

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
