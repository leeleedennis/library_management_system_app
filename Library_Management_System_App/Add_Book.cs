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
    public partial class Add_Book : Form
    {
        LibraryManagementEntities ctx = new LibraryManagementEntities();
       
        

        public Add_Book()
        {
            InitializeComponent();
            
        }


        private void Add_Book_Load(object sender, EventArgs e)
        {
            clear();
            
            ctx = new LibraryManagementEntities();
           // bookBindingSource.DataSource = ctx.Books.ToList();

            dataGridView1.Columns[0].Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void clearbutton_Click(object sender, EventArgs e)
        {

            clear();
        }

        private void Add_Book_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void PopulateDataGridView()
        {

            dataGridView1.DataSource = ctx.Books.ToList<Book>();

        }

        void clear()
        {
            Book model = new Book();

            booksubjectTb.Text = booktitleTb.Text = authorTb.Text = publisherTb.Text =
            yearTb.Text = isbnTb.Text = numcopiesTb.Text = pagesTb.Text = shelfnumberTb.Text = "";
            // deletebutton.Enabled = false;
            model.Id = 1;

        }


        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Book model = new Book
                {
                    Category = booksubjectTb.Text,
                    Title = booktitleTb.Text,
                    Author = authorTb.Text,
                    Publisher = publisherTb.Text,
                    Year_Released = yearTb.Text,
                    Pages = pagesTb.Text,
                    Shelf_Number = shelfnumberTb.Text,
                    Num_of_Copies = numcopiesTb.Text,
                    ISBN = isbnTb.Text,

                };

                ctx.Books.Add(model);
                ctx.SaveChanges();

                PopulateDataGridView();
                clear();

                MessageBox.Show("New Book was successfully added to database");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }   


        private void updatebutton_Click(object sender, EventArgs e)
        {
            
            Book bk = new Book();

           if (dataGridView1.CurrentRow.Index != -1)
            {
                bk.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);



                bk = ctx.Books.Where(q => q.Id == bk.Id).FirstOrDefault();

                bk.Category = booksubjectTb.Text;
                bk.Title = booktitleTb.Text;
                bk.Author = authorTb.Text;
                bk.Publisher = publisherTb.Text;
                bk.Year_Released = yearTb.Text;
                bk.ISBN = isbnTb.Text;
                bk.Num_of_Copies = numcopiesTb.Text;
                bk.Pages = pagesTb.Text;
                bk.Shelf_Number = shelfnumberTb.Text;

                try
                {
                    ctx.Entry(bk).State = System.Data.Entity.EntityState.Modified;
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


        private void deletebutton_Click(object sender, EventArgs e)
        {
                 Book model = new Book();

            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                try
                {
                    MessageBox.Show("Are you sure you want to delete this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    model = ctx.Books.Where(q => q.Id == model.Id).FirstOrDefault();

                    booksubjectTb.Text = model.Category;
                    booktitleTb.Text = model.Title;
                    authorTb.Text = model.Author;
                    publisherTb.Text = model.Publisher;
                    yearTb.Text = model.Year_Released;
                    isbnTb.Text = model.ISBN;
                    numcopiesTb.Text = model.Num_of_Copies;
                    pagesTb.Text = model.Pages;
                    shelfnumberTb.Text = model.Shelf_Number;

                    ctx.Books.Remove(model);
                    ctx.SaveChanges();

                    PopulateDataGridView();
                    clear();

                    MessageBox.Show("Record was deleted successfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    

       }   }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Book model = new Book();

            if (dataGridView1.CurrentRow.Index != -1)
            {
                model.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                {
                    model = ctx.Books.Where(q => q.Id == model.Id).FirstOrDefault();

                    booksubjectTb.Text = model.Category;
                    booktitleTb.Text = model.Title;
                    authorTb.Text = model.Author;
                    publisherTb.Text = model.Publisher;
                    yearTb.Text = model.Year_Released;
                    isbnTb.Text = model.ISBN;
                    numcopiesTb.Text = model.Num_of_Copies;
                    pagesTb.Text = model.Pages;
                    shelfnumberTb.Text = model.Shelf_Number;
                }
                // deletebutton.Enabled = true;
            }



        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchbutton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Books.ToList();
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Books.Where(q => q.Author.Contains(searchTb.Text)
                                                   || q.Title.Contains(searchTb.Text)).ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


            DataGridViewRow selectedRow = null;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView1.SelectedRows[0];
            }

            if (selectedRow == null)
                return;

            try
            {
                Book model = new Book
                {

                    Category = booksubjectTb.Text = selectedRow.Cells["Category"].Value.ToString(),
                    ISBN = isbnTb.Text = selectedRow.Cells["ISBN"].Value.ToString(),
                    Title = booktitleTb.Text = selectedRow.Cells["Title"].Value.ToString(),
                    Author = authorTb.Text = selectedRow.Cells["Author"].Value.ToString(),
                    Year_Released = yearTb.Text = selectedRow.Cells["Year"].Value.ToString(),
                    Publisher = publisherTb.Text = selectedRow.Cells["Publisher"].Value.ToString(),
                    Num_of_Copies = numcopiesTb.Text = selectedRow.Cells["Num_Copies"].Value.ToString(),
                    Shelf_Number = shelfnumberTb.Text = selectedRow.Cells["Shelf_Num"].Value.ToString(),
                    Pages = pagesTb.Text = selectedRow.Cells["pages"].Value.ToString()
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void memberInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updatebutton_Click_1(object sender, EventArgs e)
        {
            Book bk = new Book();

            if (dataGridView1.CurrentRow.Index != -1)
            {
                bk.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);



                bk = ctx.Books.Where(q => q.Id == bk.Id).FirstOrDefault();

                bk.Category = booksubjectTb.Text;
                bk.Title = booktitleTb.Text;
                bk.Author = authorTb.Text;
                bk.Publisher = publisherTb.Text;
                bk.Year_Released = yearTb.Text;
                bk.ISBN = isbnTb.Text;
                bk.Num_of_Copies = numcopiesTb.Text;
                bk.Pages = pagesTb.Text;
                bk.Shelf_Number = shelfnumberTb.Text;

                try
                {
                    ctx.Entry(bk).State = System.Data.Entity.EntityState.Modified;
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
    }
}