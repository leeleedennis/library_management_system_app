namespace Library_Management_System_App
{
    partial class Add_Book
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
            this.bookTitle = new System.Windows.Forms.Label();
            this.booksubLbl = new System.Windows.Forms.Label();
            this.bookTitleLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.isbnLbl = new System.Windows.Forms.Label();
            this.copiesLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shelfnumberLbl = new System.Windows.Forms.Label();
            this.yearTb = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelf_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.authorTb = new System.Windows.Forms.TextBox();
            this.booktitleTb = new System.Windows.Forms.TextBox();
            this.booksubjectTb = new System.Windows.Forms.TextBox();
            this.publisherTb = new System.Windows.Forms.TextBox();
            this.isbnTb = new System.Windows.Forms.TextBox();
            this.numcopiesTb = new System.Windows.Forms.TextBox();
            this.shelfnumberTb = new System.Windows.Forms.TextBox();
            this.pagesTb = new System.Windows.Forms.TextBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.searchbutton1 = new System.Windows.Forms.Button();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearReleasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numofCopiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.bookTitle.Location = new System.Drawing.Point(401, 9);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(198, 31);
            this.bookTitle.TabIndex = 0;
            this.bookTitle.Text = "Book Register";
            // 
            // booksubLbl
            // 
            this.booksubLbl.AutoSize = true;
            this.booksubLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.booksubLbl.Location = new System.Drawing.Point(69, 106);
            this.booksubLbl.Name = "booksubLbl";
            this.booksubLbl.Size = new System.Drawing.Size(118, 20);
            this.booksubLbl.TabIndex = 0;
            this.booksubLbl.Text = "Book Category:";
            this.booksubLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookTitleLbl
            // 
            this.bookTitleLbl.AutoSize = true;
            this.bookTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bookTitleLbl.Location = new System.Drawing.Point(69, 159);
            this.bookTitleLbl.Name = "bookTitleLbl";
            this.bookTitleLbl.Size = new System.Drawing.Size(83, 20);
            this.bookTitleLbl.TabIndex = 0;
            this.bookTitleLbl.Text = "Book Title:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.authorLbl.Location = new System.Drawing.Point(69, 215);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(79, 20);
            this.authorLbl.TabIndex = 0;
            this.authorLbl.Text = "Author(s):";
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.publisherLbl.Location = new System.Drawing.Point(69, 271);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(78, 20);
            this.publisherLbl.TabIndex = 3;
            this.publisherLbl.Text = "Publisher:";
            this.publisherLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearLbl.Location = new System.Drawing.Point(69, 321);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(47, 20);
            this.yearLbl.TabIndex = 0;
            this.yearLbl.Text = "Year:";
            // 
            // isbnLbl
            // 
            this.isbnLbl.AutoSize = true;
            this.isbnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.isbnLbl.Location = new System.Drawing.Point(69, 376);
            this.isbnLbl.Name = "isbnLbl";
            this.isbnLbl.Size = new System.Drawing.Size(51, 20);
            this.isbnLbl.TabIndex = 0;
            this.isbnLbl.Text = "ISBN:";
            // 
            // copiesLbl
            // 
            this.copiesLbl.AutoSize = true;
            this.copiesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.copiesLbl.Location = new System.Drawing.Point(69, 433);
            this.copiesLbl.Name = "copiesLbl";
            this.copiesLbl.Size = new System.Drawing.Size(137, 20);
            this.copiesLbl.TabIndex = 0;
            this.copiesLbl.Text = "Number of copies:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(69, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pages:";
            // 
            // shelfnumberLbl
            // 
            this.shelfnumberLbl.AutoSize = true;
            this.shelfnumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shelfnumberLbl.Location = new System.Drawing.Point(69, 546);
            this.shelfnumberLbl.Name = "shelfnumberLbl";
            this.shelfnumberLbl.Size = new System.Drawing.Size(110, 20);
            this.shelfnumberLbl.TabIndex = 0;
            this.shelfnumberLbl.Text = "Shelf Number:";
            // 
            // yearTb
            // 
            this.yearTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Year_Released", true));
            this.yearTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearTb.Location = new System.Drawing.Point(231, 324);
            this.yearTb.Multiline = true;
            this.yearTb.Name = "yearTb";
            this.yearTb.Size = new System.Drawing.Size(218, 27);
            this.yearTb.TabIndex = 4;
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addbutton.Location = new System.Drawing.Point(330, 600);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 32);
            this.addbutton.TabIndex = 9;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Isbn,
            this.title,
            this.author,
            this.publisher,
            this.category,
            this.year,
            this.pages,
            this.Num_copies,
            this.shelf_num,
            this.id,
            this.idDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.yearReleasedDataGridViewTextBoxColumn,
            this.pagesDataGridViewTextBoxColumn,
            this.numofCopiesDataGridViewTextBoxColumn,
            this.shelfNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(517, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(773, 418);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Isbn
            // 
            this.Isbn.DataPropertyName = "ISBN";
            this.Isbn.HeaderText = "ISBN";
            this.Isbn.Name = "Isbn";
            this.Isbn.ReadOnly = true;
            this.Isbn.Visible = false;
            this.Isbn.Width = 70;
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Visible = false;
            // 
            // author
            // 
            this.author.DataPropertyName = "Author";
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Visible = false;
            this.author.Width = 110;
            // 
            // publisher
            // 
            this.publisher.DataPropertyName = "Publisher";
            this.publisher.HeaderText = "Publisher";
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            this.publisher.Visible = false;
            // 
            // category
            // 
            this.category.DataPropertyName = "Category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Visible = false;
            // 
            // year
            // 
            this.year.DataPropertyName = "Year_Released";
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Visible = false;
            this.year.Width = 80;
            // 
            // pages
            // 
            this.pages.DataPropertyName = "Pages";
            this.pages.HeaderText = "Pages";
            this.pages.Name = "pages";
            this.pages.ReadOnly = true;
            this.pages.Visible = false;
            this.pages.Width = 60;
            // 
            // Num_copies
            // 
            this.Num_copies.DataPropertyName = "Num_of_Copies";
            this.Num_copies.HeaderText = "Number Of Copies";
            this.Num_copies.Name = "Num_copies";
            this.Num_copies.ReadOnly = true;
            this.Num_copies.Visible = false;
            this.Num_copies.Width = 160;
            // 
            // shelf_num
            // 
            this.shelf_num.DataPropertyName = "Shelf_Number";
            this.shelf_num.HeaderText = "Shelf Number";
            this.shelf_num.Name = "shelf_num";
            this.shelf_num.ReadOnly = true;
            this.shelf_num.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(487, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search:";
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(570, 106);
            this.searchTb.Multiline = true;
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(427, 30);
            this.searchTb.TabIndex = 13;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // authorTb
            // 
            this.authorTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.authorTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.authorTb.Location = new System.Drawing.Point(231, 217);
            this.authorTb.Multiline = true;
            this.authorTb.Name = "authorTb";
            this.authorTb.Size = new System.Drawing.Size(218, 27);
            this.authorTb.TabIndex = 2;
            // 
            // booktitleTb
            // 
            this.booktitleTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
            this.booktitleTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.booktitleTb.Location = new System.Drawing.Point(231, 161);
            this.booktitleTb.Multiline = true;
            this.booktitleTb.Name = "booktitleTb";
            this.booktitleTb.Size = new System.Drawing.Size(218, 27);
            this.booktitleTb.TabIndex = 1;
            // 
            // booksubjectTb
            // 
            this.booksubjectTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Category", true));
            this.booksubjectTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksubjectTb.Location = new System.Drawing.Point(231, 109);
            this.booksubjectTb.Multiline = true;
            this.booksubjectTb.Name = "booksubjectTb";
            this.booksubjectTb.Size = new System.Drawing.Size(218, 27);
            this.booksubjectTb.TabIndex = 0;
            // 
            // publisherTb
            // 
            this.publisherTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Publisher", true));
            this.publisherTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.publisherTb.Location = new System.Drawing.Point(231, 270);
            this.publisherTb.Multiline = true;
            this.publisherTb.Name = "publisherTb";
            this.publisherTb.Size = new System.Drawing.Size(218, 27);
            this.publisherTb.TabIndex = 3;
            // 
            // isbnTb
            // 
            this.isbnTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISBN", true));
            this.isbnTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.isbnTb.Location = new System.Drawing.Point(231, 378);
            this.isbnTb.Multiline = true;
            this.isbnTb.Name = "isbnTb";
            this.isbnTb.Size = new System.Drawing.Size(218, 27);
            this.isbnTb.TabIndex = 5;
            // 
            // numcopiesTb
            // 
            this.numcopiesTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Num_of_Copies", true));
            this.numcopiesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numcopiesTb.Location = new System.Drawing.Point(231, 435);
            this.numcopiesTb.Multiline = true;
            this.numcopiesTb.Name = "numcopiesTb";
            this.numcopiesTb.Size = new System.Drawing.Size(218, 27);
            this.numcopiesTb.TabIndex = 6;
            // 
            // shelfnumberTb
            // 
            this.shelfnumberTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Shelf_Number", true));
            this.shelfnumberTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shelfnumberTb.Location = new System.Drawing.Point(231, 548);
            this.shelfnumberTb.Multiline = true;
            this.shelfnumberTb.Name = "shelfnumberTb";
            this.shelfnumberTb.Size = new System.Drawing.Size(218, 27);
            this.shelfnumberTb.TabIndex = 8;
            // 
            // pagesTb
            // 
            this.pagesTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Pages", true));
            this.pagesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pagesTb.Location = new System.Drawing.Point(231, 494);
            this.pagesTb.Multiline = true;
            this.pagesTb.Name = "pagesTb";
            this.pagesTb.Size = new System.Drawing.Size(218, 27);
            this.pagesTb.TabIndex = 7;
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatebutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.updatebutton.Location = new System.Drawing.Point(491, 600);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 32);
            this.updatebutton.TabIndex = 10;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.deletebutton.Location = new System.Drawing.Point(656, 600);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 32);
            this.deletebutton.TabIndex = 11;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.clearbutton.Location = new System.Drawing.Point(805, 600);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 32);
            this.clearbutton.TabIndex = 12;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Cancelbutton.Location = new System.Drawing.Point(960, 600);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 32);
            this.Cancelbutton.TabIndex = 20;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // searchbutton1
            // 
            this.searchbutton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.searchbutton1.Location = new System.Drawing.Point(1022, 100);
            this.searchbutton1.Name = "searchbutton1";
            this.searchbutton1.Size = new System.Drawing.Size(75, 32);
            this.searchbutton1.TabIndex = 21;
            this.searchbutton1.Text = "View";
            this.searchbutton1.UseVisualStyleBackColor = false;
            this.searchbutton1.Click += new System.EventHandler(this.searchbutton1_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Library_Management_System_App.Book);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearReleasedDataGridViewTextBoxColumn
            // 
            this.yearReleasedDataGridViewTextBoxColumn.DataPropertyName = "Year_Released";
            this.yearReleasedDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearReleasedDataGridViewTextBoxColumn.Name = "yearReleasedDataGridViewTextBoxColumn";
            this.yearReleasedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            this.pagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numofCopiesDataGridViewTextBoxColumn
            // 
            this.numofCopiesDataGridViewTextBoxColumn.DataPropertyName = "Num_of_Copies";
            this.numofCopiesDataGridViewTextBoxColumn.HeaderText = "Number of Copies";
            this.numofCopiesDataGridViewTextBoxColumn.Name = "numofCopiesDataGridViewTextBoxColumn";
            this.numofCopiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shelfNumberDataGridViewTextBoxColumn
            // 
            this.shelfNumberDataGridViewTextBoxColumn.DataPropertyName = "Shelf_Number";
            this.shelfNumberDataGridViewTextBoxColumn.HeaderText = "Shelf Number";
            this.shelfNumberDataGridViewTextBoxColumn.Name = "shelfNumberDataGridViewTextBoxColumn";
            this.shelfNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Add_Book
            // 
            this.AcceptButton = this.updatebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1119, 703);
            this.Controls.Add(this.searchbutton1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.pagesTb);
            this.Controls.Add(this.shelfnumberTb);
            this.Controls.Add(this.numcopiesTb);
            this.Controls.Add(this.isbnTb);
            this.Controls.Add(this.publisherTb);
            this.Controls.Add(this.booksubjectTb);
            this.Controls.Add(this.booktitleTb);
            this.Controls.Add(this.authorTb);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.yearTb);
            this.Controls.Add(this.shelfnumberLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.copiesLbl);
            this.Controls.Add(this.isbnLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.bookTitleLbl);
            this.Controls.Add(this.booksubLbl);
            this.Controls.Add(this.bookTitle);
            this.Name = "Add_Book";
            this.Text = "Book Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Book_FormClosing);
            this.Load += new System.EventHandler(this.Add_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.Label booksubLbl;
        private System.Windows.Forms.Label bookTitleLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label isbnLbl;
        private System.Windows.Forms.Label copiesLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label shelfnumberLbl;
        private System.Windows.Forms.TextBox yearTb;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.TextBox authorTb;
        private System.Windows.Forms.TextBox booktitleTb;
        private System.Windows.Forms.TextBox booksubjectTb;
        private System.Windows.Forms.TextBox publisherTb;
        private System.Windows.Forms.TextBox isbnTb;
        private System.Windows.Forms.TextBox numcopiesTb;
        private System.Windows.Forms.TextBox shelfnumberTb;
        private System.Windows.Forms.TextBox pagesTb;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button searchbutton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_copies;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelf_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearReleasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numofCopiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfNumberDataGridViewTextBoxColumn;
    }
}