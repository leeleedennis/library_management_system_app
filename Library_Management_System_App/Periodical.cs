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
        LibraryManagementEntities ctx = new LibraryManagementEntities();
        

        public Periodical()
        {
            InitializeComponent();
        }

        private void clearperiodbutton_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            Period model2 = new Period();

            categoryTb.Text = pagenumberTb.Text = periodicalnameTb.Text = yearTb.Text = isbnTb.Text =
            shelfnumberTb.Text = volumenumberTb.Text = searchTb.Text = "";

            model2.Id = 1;
        }

        private void Periodical_Load(object sender, EventArgs e)
        {
            clear();
            ctx = new LibraryManagementEntities();
           
        }

        void UpdateDataViewGrid()
        {
            PeriodicalDataGridView.DataSource = ctx.Periods.ToList<Period>();
        }

        private void addperiodbutton_Click(object sender, EventArgs e)
        {

            Period pd = new Period();

            if (PeriodicalDataGridView.CurrentRow.Index != -1)
            {
                pd.Id = Convert.ToInt32(PeriodicalDataGridView.CurrentRow.Cells["Id"].Value);



                pd = ctx.Periods.Where(q => q.Id == pd.Id).FirstOrDefault();

                pd.P_Category = categoryTb.Text;
                pd.Name = periodicalnameTb.Text;
                pd.ISBN = isbnTb.Text;
                pd.Volume_Number = volumenumberTb.Text;
                pd.Year = yearTb.Text;
                pd.Page_Number = pagenumberTb.Text;
                pd.Shelf_Num = shelfnumberTb.Text;

                try
                {
                    ctx.Entry(pd).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();

                    clear();
                    UpdateDataViewGrid();

                    MessageBox.Show("Periodical added successfully");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error Please cancel ");
                }
            }
        }

        private void updateperiodbutton_Click(object sender, EventArgs e)
        {
            Period pd = new Period();

             if (PeriodicalDataGridView.CurrentRow.Index != -1)
             {
                 pd.Id = Convert.ToInt32(PeriodicalDataGridView.CurrentRow.Cells["Id"].Value);



                 pd = ctx.Periods.Where(q => q.Id == pd.Id).FirstOrDefault();

                 pd.P_Category = categoryTb.Text;
                 pd.Name = periodicalnameTb.Text;
                 pd.ISBN = isbnTb.Text;
                 pd.Volume_Number = volumenumberTb.Text;
                 pd.Year = yearTb.Text;
                 pd.Page_Number = pagenumberTb.Text;
                 pd.Shelf_Num = shelfnumberTb.Text;

                 try
                 {
                    
                     ctx.Entry(pd).State = System.Data.Entity.EntityState.Modified;
                     ctx.SaveChanges();

                     clear();
                     UpdateDataViewGrid();

                     MessageBox.Show("Periodical updated successfully");


                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.ToString(), "Error Please cancel ");
                 }
             }

        }

        private void PeriodicalDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Period model2 = new Period();

            if (PeriodicalDataGridView.CurrentRow.Index != -1)
            {
                model2.Id = Convert.ToInt32(PeriodicalDataGridView.CurrentRow.Cells["Id"].Value);

                model2 = ctx.Periods.Where(q => q.Id == model2.Id).FirstOrDefault();

                categoryTb.Text = model2.P_Category;
                periodicalnameTb.Text = model2.Name;
                isbnTb.Text = model2.ISBN;
                volumenumberTb.Text = model2.Volume_Number;
                yearTb.Text = model2.Year;
                pagenumberTb.Text = model2.Page_Number;
                shelfnumberTb.Text = model2.Shelf_Num;
            }

        }

        private void deleteperiodbutton_Click(object sender, EventArgs e)
        {
            Period pd = new Period();

            if (PeriodicalDataGridView.CurrentRow.Index != -1)
            {
                pd.Id = Convert.ToInt32(PeriodicalDataGridView.CurrentRow.Cells["Id"].Value);

                
                
                    pd = ctx.Periods.Where(q => q.Id == pd.Id).FirstOrDefault();

                    pd.P_Category = categoryTb.Text;
                    pd.Name = periodicalnameTb.Text;
                    pd.ISBN = isbnTb.Text;
                    pd.Volume_Number = volumenumberTb.Text;
                    pd.Year = yearTb.Text;
                    pd.Page_Number = pagenumberTb.Text;
                    pd.Shelf_Num = shelfnumberTb.Text;

                try
                {

                 MessageBox.Show("Do you really want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            

                 ctx.Entry(pd).State = System.Data.Entity.EntityState.Deleted;
                 ctx.SaveChanges();
                 clear();
                 UpdateDataViewGrid();

                 MessageBox.Show("Periodical deleted successfully");
                         
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.ToString(), "Error Please cancel ");
                }
            }
        }
                    

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            PeriodicalDataGridView.DataSource = ctx.Periods.ToList();
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            PeriodicalDataGridView.DataSource = ctx.Periods.Where(q => q.Name.Contains(searchTb.Text) ||
                                                         q.P_Category.Contains(searchTb.Text)).ToList();
        }

        private void PeriodicalDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void PeriodicalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
           
        }
    }
}
