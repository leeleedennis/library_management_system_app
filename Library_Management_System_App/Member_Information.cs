using DataLayer;
using StudentLayer;
using Model;
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
        LibraryManagementEntities ctx = new LibraryManagementEntities();
            

        public Member_Information()
        {
            InitializeComponent();
            
            
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void Member_Information_Load(object sender, EventArgs e)
        {
        
            clear();
            ctx = new LibraryManagementEntities();
            
           
        }

        private void Member_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }


        void PopulateDataGridView()
        {
            using (LibraryManagementEntities ctx = new LibraryManagementEntities())
            {
                StudentDataGridView.DataSource = ctx.Students.ToList<Student>();
            }
        }

        void clear()
        {
            Student model1 = new Student();

            studentTb.Text = lnameTb.Text = fnameTb.Text = classTb.Text = "";
            model1.Id = 1;

        }

        private void studentTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            
            try
            {

                Student model1 = new Student
                {
                    StudentID = studentTb.Text.Trim(),
                    L_Name = lnameTb.Text.Trim(),
                    F_Name = fnameTb.Text.Trim(),
                    Class = classTb.Text.Trim(),
                    
                };

                ctx.Students.Add(model1);
                ctx.SaveChanges();

                clear();
                PopulateDataGridView();

                MessageBox.Show("New Student successfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           
        }

        private void StudentDataGridView_DoubleClick(object sender, EventArgs e)
        {
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

            Student stu = new Student();

             if (StudentDataGridView.CurrentRow.Index != -1)
             {
              stu.Id = Convert.ToInt32(StudentDataGridView.CurrentRow.Cells["Id"].Value);
                stu.StudentID = Convert.ToString(StudentDataGridView.CurrentRow.Cells["StudentID"].Value);


                stu = ctx.Students.Where(q => q.StudentID == stu.StudentID).FirstOrDefault();


                 stu.StudentID = studentTb.Text;
                 stu.L_Name = lnameTb.Text;
                 stu.F_Name = fnameTb.Text;
                 stu.Class = classTb.Text;
                 

                 try
                 {

                     
                      ctx.Entry(stu).State = System.Data.Entity.EntityState.Modified;
                      ctx.SaveChanges();

                     PopulateDataGridView();
                     clear();

                     MessageBox.Show("Book updated successfully");


                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message, "Error cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

             }
            

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            


           if (StudentDataGridView.CurrentRow.Index != -1)
           {
                   stu.Id = Convert.ToInt32(StudentDataGridView.CurrentRow.Cells["Id"].Value);
                stu.StudentID = Convert.ToString(StudentDataGridView.CurrentRow.Cells["StudentID"].Value);

                 stu = ctx.Students.Where(q => q.StudentID == stu.StudentID).FirstOrDefault();


                 studentTb.Text = stu.StudentID;
                 lnameTb.Text = stu.L_Name;
                 fnameTb.Text = stu.F_Name;
                 classTb.Text = stu.Class;
                

              try
             {

                 MessageBox.Show("Do you really want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                 ctx.Entry(stu).State = System.Data.Entity.EntityState.Deleted;
                 ctx.SaveChanges();

                 PopulateDataGridView();
                 clear();

                 MessageBox.Show("Record was deleted successfully");


              }
              catch (Exception ex)
              {
                 MessageBox.Show(ex.Message, "Error cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);

              }

           }
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            //StudentDataGridView.DataSource = ctx.Students.ToList();
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            StudentDataGridView.DataSource = ctx.Students.Where(q => q.F_Name.Contains(searchTb.Text) ||
                                                                q.L_Name.Contains(searchTb.Text)).ToList();
        }

        private void StudentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (StudentDataGridView.SelectedRows.Count > 0)
            {
                selectedRow = StudentDataGridView.SelectedRows[0];
            }

            if (selectedRow == null)
                return;

            try
            {
                Student model = new Student
                {
                    StudentID = studentTb.Text = selectedRow.Cells["studentid"].Value.ToString(),
                    L_Name = lnameTb.Text = selectedRow.Cells["lastname"].Value.ToString(),
                    F_Name = fnameTb.Text = selectedRow.Cells["firstname"].Value.ToString(),
                    Class = classTb.Text = selectedRow.Cells["classid"].Value.ToString(),
                   

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void sudentidLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
