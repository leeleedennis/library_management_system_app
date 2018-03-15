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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.yearTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearTb.Location = new System.Drawing.Point(231, 324);
            this.yearTb.Multiline = true;
            this.yearTb.Name = "yearTb";
            this.yearTb.Size = new System.Drawing.Size(218, 27);
            this.yearTb.TabIndex = 5;
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addbutton.Location = new System.Drawing.Point(328, 632);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 32);
            this.addbutton.TabIndex = 10;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 418);
            this.dataGridView1.TabIndex = 18;
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
            this.searchTb.Size = new System.Drawing.Size(520, 30);
            this.searchTb.TabIndex = 0;
            // 
            // authorTb
            // 
            this.authorTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.authorTb.Location = new System.Drawing.Point(231, 217);
            this.authorTb.Multiline = true;
            this.authorTb.Name = "authorTb";
            this.authorTb.Size = new System.Drawing.Size(218, 27);
            this.authorTb.TabIndex = 3;
            // 
            // booktitleTb
            // 
            this.booktitleTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.booktitleTb.Location = new System.Drawing.Point(231, 161);
            this.booktitleTb.Multiline = true;
            this.booktitleTb.Name = "booktitleTb";
            this.booktitleTb.Size = new System.Drawing.Size(218, 27);
            this.booktitleTb.TabIndex = 2;
            // 
            // booksubjectTb
            // 
            this.booksubjectTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksubjectTb.Location = new System.Drawing.Point(231, 109);
            this.booksubjectTb.Multiline = true;
            this.booksubjectTb.Name = "booksubjectTb";
            this.booksubjectTb.Size = new System.Drawing.Size(218, 27);
            this.booksubjectTb.TabIndex = 1;
            // 
            // publisherTb
            // 
            this.publisherTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.publisherTb.Location = new System.Drawing.Point(231, 270);
            this.publisherTb.Multiline = true;
            this.publisherTb.Name = "publisherTb";
            this.publisherTb.Size = new System.Drawing.Size(218, 27);
            this.publisherTb.TabIndex = 4;
            // 
            // isbnTb
            // 
            this.isbnTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.isbnTb.Location = new System.Drawing.Point(231, 378);
            this.isbnTb.Multiline = true;
            this.isbnTb.Name = "isbnTb";
            this.isbnTb.Size = new System.Drawing.Size(218, 27);
            this.isbnTb.TabIndex = 6;
            // 
            // numcopiesTb
            // 
            this.numcopiesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numcopiesTb.Location = new System.Drawing.Point(231, 435);
            this.numcopiesTb.Multiline = true;
            this.numcopiesTb.Name = "numcopiesTb";
            this.numcopiesTb.Size = new System.Drawing.Size(218, 27);
            this.numcopiesTb.TabIndex = 7;
            // 
            // shelfnumberTb
            // 
            this.shelfnumberTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shelfnumberTb.Location = new System.Drawing.Point(231, 548);
            this.shelfnumberTb.Multiline = true;
            this.shelfnumberTb.Name = "shelfnumberTb";
            this.shelfnumberTb.Size = new System.Drawing.Size(218, 27);
            this.shelfnumberTb.TabIndex = 9;
            // 
            // pagesTb
            // 
            this.pagesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pagesTb.Location = new System.Drawing.Point(231, 494);
            this.pagesTb.Multiline = true;
            this.pagesTb.Name = "pagesTb";
            this.pagesTb.Size = new System.Drawing.Size(218, 27);
            this.pagesTb.TabIndex = 8;
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.updatebutton.Location = new System.Drawing.Point(491, 632);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 32);
            this.updatebutton.TabIndex = 11;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.deletebutton.Location = new System.Drawing.Point(654, 632);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 32);
            this.deletebutton.TabIndex = 12;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.clearbutton.Location = new System.Drawing.Point(808, 632);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 32);
            this.clearbutton.TabIndex = 13;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1119, 703);
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
            this.Text = "Add_Book";
            this.Load += new System.EventHandler(this.Add_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}