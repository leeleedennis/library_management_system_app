namespace Library_Management_System_App
{
    partial class Periodical
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.isbnlabel = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.paperNoLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryTb = new System.Windows.Forms.TextBox();
            this.periodicalnameTb = new System.Windows.Forms.TextBox();
            this.isbnTb = new System.Windows.Forms.TextBox();
            this.volumenumberTb = new System.Windows.Forms.TextBox();
            this.yearTb = new System.Windows.Forms.TextBox();
            this.pagenumberTb = new System.Windows.Forms.TextBox();
            this.shelfnumberTb = new System.Windows.Forms.TextBox();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchperiodicalLbl = new System.Windows.Forms.Label();
            this.PeriodicalDataGridView = new System.Windows.Forms.DataGridView();
            this.periodicalcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addperiodbutton = new System.Windows.Forms.Button();
            this.updateperiodbutton = new System.Windows.Forms.Button();
            this.deleteperiodbutton = new System.Windows.Forms.Button();
            this.clearperiodbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodical";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.titleLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLbl.Location = new System.Drawing.Point(30, 122);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(169, 20);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Periodical Category:";
            // 
            // isbnlabel
            // 
            this.isbnlabel.AutoSize = true;
            this.isbnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.isbnlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isbnlabel.Location = new System.Drawing.Point(30, 208);
            this.isbnlabel.Name = "isbnlabel";
            this.isbnlabel.Size = new System.Drawing.Size(56, 20);
            this.isbnlabel.TabIndex = 0;
            this.isbnlabel.Text = "ISBN:";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yearLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yearLbl.Location = new System.Drawing.Point(30, 301);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(52, 20);
            this.yearLbl.TabIndex = 0;
            this.yearLbl.Text = "Year:";
            // 
            // volumeLbl
            // 
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.volumeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.volumeLbl.Location = new System.Drawing.Point(28, 255);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(146, 20);
            this.volumeLbl.TabIndex = 0;
            this.volumeLbl.Text = " Volume Number:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLbl.Location = new System.Drawing.Point(28, 165);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(164, 20);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Name of Periodical:";
            // 
            // paperNoLbl
            // 
            this.paperNoLbl.AutoSize = true;
            this.paperNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.paperNoLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paperNoLbl.Location = new System.Drawing.Point(30, 347);
            this.paperNoLbl.Name = "paperNoLbl";
            this.paperNoLbl.Size = new System.Drawing.Size(122, 20);
            this.paperNoLbl.TabIndex = 0;
            this.paperNoLbl.Text = "Page Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Shelf Number:";
            // 
            // categoryTb
            // 
            this.categoryTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodBindingSource, "P_Category", true));
            this.categoryTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.categoryTb.Location = new System.Drawing.Point(205, 119);
            this.categoryTb.Multiline = true;
            this.categoryTb.Name = "categoryTb";
            this.categoryTb.Size = new System.Drawing.Size(232, 28);
            this.categoryTb.TabIndex = 0;
            // 
            // periodicalnameTb
            // 
            this.periodicalnameTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodBindingSource, "Name", true));
            this.periodicalnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.periodicalnameTb.Location = new System.Drawing.Point(205, 162);
            this.periodicalnameTb.Multiline = true;
            this.periodicalnameTb.Name = "periodicalnameTb";
            this.periodicalnameTb.Size = new System.Drawing.Size(232, 28);
            this.periodicalnameTb.TabIndex = 1;
            // 
            // isbnTb
            // 
            this.isbnTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodBindingSource, "ISBN", true));
            this.isbnTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.isbnTb.Location = new System.Drawing.Point(205, 205);
            this.isbnTb.Multiline = true;
            this.isbnTb.Name = "isbnTb";
            this.isbnTb.Size = new System.Drawing.Size(232, 28);
            this.isbnTb.TabIndex = 2;
            // 
            // volumenumberTb
            // 
            this.volumenumberTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodBindingSource, "Volume_Number", true));
            this.volumenumberTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.volumenumberTb.Location = new System.Drawing.Point(205, 252);
            this.volumenumberTb.Multiline = true;
            this.volumenumberTb.Name = "volumenumberTb";
            this.volumenumberTb.Size = new System.Drawing.Size(232, 28);
            this.volumenumberTb.TabIndex = 3;
            // 
            // yearTb
            // 
            this.yearTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodBindingSource, "Year", true));
            this.yearTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearTb.Location = new System.Drawing.Point(205, 298);
            this.yearTb.Multiline = true;
            this.yearTb.Name = "yearTb";
            this.yearTb.Size = new System.Drawing.Size(232, 28);
            this.yearTb.TabIndex = 4;
            // 
            // pagenumberTb
            // 
            this.pagenumberTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodBindingSource, "Page_Number", true));
            this.pagenumberTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pagenumberTb.Location = new System.Drawing.Point(205, 344);
            this.pagenumberTb.Multiline = true;
            this.pagenumberTb.Name = "pagenumberTb";
            this.pagenumberTb.Size = new System.Drawing.Size(232, 28);
            this.pagenumberTb.TabIndex = 5;
            // 
            // shelfnumberTb
            // 
            this.shelfnumberTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodBindingSource, "Shelf_Num", true));
            this.shelfnumberTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shelfnumberTb.Location = new System.Drawing.Point(205, 388);
            this.shelfnumberTb.Multiline = true;
            this.shelfnumberTb.Name = "shelfnumberTb";
            this.shelfnumberTb.Size = new System.Drawing.Size(232, 28);
            this.shelfnumberTb.TabIndex = 6;
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTb.Location = new System.Drawing.Point(536, 77);
            this.searchTb.Multiline = true;
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(441, 28);
            this.searchTb.TabIndex = 11;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // searchperiodicalLbl
            // 
            this.searchperiodicalLbl.AutoSize = true;
            this.searchperiodicalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.searchperiodicalLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchperiodicalLbl.Location = new System.Drawing.Point(459, 80);
            this.searchperiodicalLbl.Name = "searchperiodicalLbl";
            this.searchperiodicalLbl.Size = new System.Drawing.Size(71, 20);
            this.searchperiodicalLbl.TabIndex = 17;
            this.searchperiodicalLbl.Text = "Search:";
            // 
            // PeriodicalDataGridView
            // 
            this.PeriodicalDataGridView.AllowUserToAddRows = false;
            this.PeriodicalDataGridView.AllowUserToDeleteRows = false;
            this.PeriodicalDataGridView.AutoGenerateColumns = false;
            this.PeriodicalDataGridView.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.PeriodicalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeriodicalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pCategoryDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.volumeNumberDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.pageNumberDataGridViewTextBoxColumn,
            this.shelfNumDataGridViewTextBoxColumn,
            this.periodicalcategory,
            this.volumenumber,
            this.year,
            this.isbn,
            this.id,
            this.shelfnumber,
            this.name,
            this.pagenumber});
            this.PeriodicalDataGridView.DataSource = this.periodBindingSource;
            this.PeriodicalDataGridView.Location = new System.Drawing.Point(463, 119);
            this.PeriodicalDataGridView.Name = "PeriodicalDataGridView";
            this.PeriodicalDataGridView.Size = new System.Drawing.Size(868, 384);
            this.PeriodicalDataGridView.TabIndex = 18;
            this.PeriodicalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeriodicalDataGridView_CellContentClick);
            this.PeriodicalDataGridView.SelectionChanged += new System.EventHandler(this.PeriodicalDataGridView_SelectionChanged);
            this.PeriodicalDataGridView.DoubleClick += new System.EventHandler(this.PeriodicalDataGridView_DoubleClick);
            // 
            // periodicalcategory
            // 
            this.periodicalcategory.DataPropertyName = "P_Category";
            this.periodicalcategory.HeaderText = "Periodical Category";
            this.periodicalcategory.Name = "periodicalcategory";
            this.periodicalcategory.Visible = false;
            this.periodicalcategory.Width = 140;
            // 
            // volumenumber
            // 
            this.volumenumber.DataPropertyName = "Volume Number";
            this.volumenumber.HeaderText = "Volume Number";
            this.volumenumber.Name = "volumenumber";
            this.volumenumber.Visible = false;
            this.volumenumber.Width = 200;
            // 
            // year
            // 
            this.year.DataPropertyName = "Year";
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.Visible = false;
            this.year.Width = 70;
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "ISBN";
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.Visible = false;
            this.isbn.Width = 70;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 20;
            // 
            // shelfnumber
            // 
            this.shelfnumber.DataPropertyName = "Shelf_Num";
            this.shelfnumber.HeaderText = "Shelf Number";
            this.shelfnumber.Name = "shelfnumber";
            this.shelfnumber.Visible = false;
            this.shelfnumber.Width = 95;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Visible = false;
            this.name.Width = 120;
            // 
            // pagenumber
            // 
            this.pagenumber.DataPropertyName = "Page_Number";
            this.pagenumber.HeaderText = "Page Number";
            this.pagenumber.Name = "pagenumber";
            this.pagenumber.Visible = false;
            this.pagenumber.Width = 95;
            // 
            // addperiodbutton
            // 
            this.addperiodbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addperiodbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addperiodbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addperiodbutton.Location = new System.Drawing.Point(463, 523);
            this.addperiodbutton.Name = "addperiodbutton";
            this.addperiodbutton.Size = new System.Drawing.Size(88, 38);
            this.addperiodbutton.TabIndex = 7;
            this.addperiodbutton.Text = "Add";
            this.addperiodbutton.UseVisualStyleBackColor = false;
            this.addperiodbutton.Click += new System.EventHandler(this.addperiodbutton_Click);
            // 
            // updateperiodbutton
            // 
            this.updateperiodbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateperiodbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateperiodbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateperiodbutton.Location = new System.Drawing.Point(657, 523);
            this.updateperiodbutton.Name = "updateperiodbutton";
            this.updateperiodbutton.Size = new System.Drawing.Size(89, 38);
            this.updateperiodbutton.TabIndex = 8;
            this.updateperiodbutton.Text = "Update";
            this.updateperiodbutton.UseVisualStyleBackColor = false;
            this.updateperiodbutton.Click += new System.EventHandler(this.updateperiodbutton_Click);
            // 
            // deleteperiodbutton
            // 
            this.deleteperiodbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteperiodbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteperiodbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteperiodbutton.Location = new System.Drawing.Point(852, 523);
            this.deleteperiodbutton.Name = "deleteperiodbutton";
            this.deleteperiodbutton.Size = new System.Drawing.Size(88, 38);
            this.deleteperiodbutton.TabIndex = 9;
            this.deleteperiodbutton.Text = "Delete";
            this.deleteperiodbutton.UseVisualStyleBackColor = false;
            this.deleteperiodbutton.Click += new System.EventHandler(this.deleteperiodbutton_Click);
            // 
            // clearperiodbutton
            // 
            this.clearperiodbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.clearperiodbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearperiodbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearperiodbutton.Location = new System.Drawing.Point(1043, 523);
            this.clearperiodbutton.Name = "clearperiodbutton";
            this.clearperiodbutton.Size = new System.Drawing.Size(93, 38);
            this.clearperiodbutton.TabIndex = 10;
            this.clearperiodbutton.Text = "Clear";
            this.clearperiodbutton.UseVisualStyleBackColor = false;
            this.clearperiodbutton.Click += new System.EventHandler(this.clearperiodbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(1242, 523);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 38);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Searchbutton.Location = new System.Drawing.Point(1015, 74);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(84, 33);
            this.Searchbutton.TabIndex = 20;
            this.Searchbutton.Text = "View";
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 20;
            // 
            // pCategoryDataGridViewTextBoxColumn
            // 
            this.pCategoryDataGridViewTextBoxColumn.DataPropertyName = "P_Category";
            this.pCategoryDataGridViewTextBoxColumn.HeaderText = "Periodical Category";
            this.pCategoryDataGridViewTextBoxColumn.Name = "pCategoryDataGridViewTextBoxColumn";
            this.pCategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // volumeNumberDataGridViewTextBoxColumn
            // 
            this.volumeNumberDataGridViewTextBoxColumn.DataPropertyName = "Volume_Number";
            this.volumeNumberDataGridViewTextBoxColumn.HeaderText = "Volume Number";
            this.volumeNumberDataGridViewTextBoxColumn.Name = "volumeNumberDataGridViewTextBoxColumn";
            this.volumeNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // pageNumberDataGridViewTextBoxColumn
            // 
            this.pageNumberDataGridViewTextBoxColumn.DataPropertyName = "Page_Number";
            this.pageNumberDataGridViewTextBoxColumn.HeaderText = "Page Number";
            this.pageNumberDataGridViewTextBoxColumn.Name = "pageNumberDataGridViewTextBoxColumn";
            // 
            // shelfNumDataGridViewTextBoxColumn
            // 
            this.shelfNumDataGridViewTextBoxColumn.DataPropertyName = "Shelf_Num";
            this.shelfNumDataGridViewTextBoxColumn.HeaderText = "Shelf Number";
            this.shelfNumDataGridViewTextBoxColumn.Name = "shelfNumDataGridViewTextBoxColumn";
            // 
            // periodBindingSource
            // 
            this.periodBindingSource.DataSource = typeof(Library_Management_System_App.Period);
            // 
            // Periodical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1343, 600);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearperiodbutton);
            this.Controls.Add(this.deleteperiodbutton);
            this.Controls.Add(this.updateperiodbutton);
            this.Controls.Add(this.addperiodbutton);
            this.Controls.Add(this.PeriodicalDataGridView);
            this.Controls.Add(this.searchperiodicalLbl);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.shelfnumberTb);
            this.Controls.Add(this.pagenumberTb);
            this.Controls.Add(this.yearTb);
            this.Controls.Add(this.volumenumberTb);
            this.Controls.Add(this.isbnTb);
            this.Controls.Add(this.periodicalnameTb);
            this.Controls.Add(this.categoryTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paperNoLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.isbnlabel);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.label1);
            this.Name = "Periodical";
            this.Text = "Periodical";
            this.Load += new System.EventHandler(this.Periodical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeriodicalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label isbnlabel;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label paperNoLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categoryTb;
        private System.Windows.Forms.TextBox periodicalnameTb;
        private System.Windows.Forms.TextBox isbnTb;
        private System.Windows.Forms.TextBox volumenumberTb;
        private System.Windows.Forms.TextBox yearTb;
        private System.Windows.Forms.TextBox pagenumberTb;
        private System.Windows.Forms.TextBox shelfnumberTb;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Label searchperiodicalLbl;
        private System.Windows.Forms.DataGridView PeriodicalDataGridView;
        private System.Windows.Forms.Button addperiodbutton;
        private System.Windows.Forms.Button updateperiodbutton;
        private System.Windows.Forms.Button deleteperiodbutton;
        private System.Windows.Forms.Button clearperiodbutton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.BindingSource periodBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodicalcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagenumber;
    }
}