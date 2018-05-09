namespace Library_Management_System_App
{
    partial class Member_Information
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
            this.sudentidLbl = new System.Windows.Forms.Label();
            this.LnameLbl = new System.Windows.Forms.Label();
            this.FnameLbl = new System.Windows.Forms.Label();
            this.classLbl = new System.Windows.Forms.Label();
            this.studentTb = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lnameTb = new System.Windows.Forms.TextBox();
            this.classTb = new System.Windows.Forms.TextBox();
            this.fnameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sudentidLbl
            // 
            this.sudentidLbl.AutoSize = true;
            this.sudentidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sudentidLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sudentidLbl.Location = new System.Drawing.Point(31, 158);
            this.sudentidLbl.Name = "sudentidLbl";
            this.sudentidLbl.Size = new System.Drawing.Size(102, 20);
            this.sudentidLbl.TabIndex = 0;
            this.sudentidLbl.Text = "Student ID:";
            this.sudentidLbl.Click += new System.EventHandler(this.sudentidLbl_Click);
            // 
            // LnameLbl
            // 
            this.LnameLbl.AutoSize = true;
            this.LnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LnameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LnameLbl.Location = new System.Drawing.Point(32, 197);
            this.LnameLbl.Name = "LnameLbl";
            this.LnameLbl.Size = new System.Drawing.Size(100, 20);
            this.LnameLbl.TabIndex = 0;
            this.LnameLbl.Text = "Last Name:";
            // 
            // FnameLbl
            // 
            this.FnameLbl.AutoSize = true;
            this.FnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FnameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FnameLbl.Location = new System.Drawing.Point(31, 238);
            this.FnameLbl.Name = "FnameLbl";
            this.FnameLbl.Size = new System.Drawing.Size(101, 20);
            this.FnameLbl.TabIndex = 0;
            this.FnameLbl.Text = "First Name:";
            // 
            // classLbl
            // 
            this.classLbl.AutoSize = true;
            this.classLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.classLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classLbl.Location = new System.Drawing.Point(32, 278);
            this.classLbl.Name = "classLbl";
            this.classLbl.Size = new System.Drawing.Size(58, 20);
            this.classLbl.TabIndex = 0;
            this.classLbl.Text = "Class:";
            // 
            // studentTb
            // 
            this.studentTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "StudentID", true));
            this.studentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.studentTb.Location = new System.Drawing.Point(138, 160);
            this.studentTb.Multiline = true;
            this.studentTb.Name = "studentTb";
            this.studentTb.Size = new System.Drawing.Size(205, 27);
            this.studentTb.TabIndex = 0;
            this.studentTb.TextChanged += new System.EventHandler(this.studentTb_TextChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Library_Management_System_App.Student);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataSource = typeof(Model.Student);
            // 
            // lnameTb
            // 
            this.lnameTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "L_Name", true));
            this.lnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lnameTb.Location = new System.Drawing.Point(138, 199);
            this.lnameTb.Multiline = true;
            this.lnameTb.Name = "lnameTb";
            this.lnameTb.Size = new System.Drawing.Size(205, 27);
            this.lnameTb.TabIndex = 1;
            // 
            // classTb
            // 
            this.classTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Class", true));
            this.classTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.classTb.Location = new System.Drawing.Point(138, 280);
            this.classTb.Multiline = true;
            this.classTb.Name = "classTb";
            this.classTb.Size = new System.Drawing.Size(205, 27);
            this.classTb.TabIndex = 3;
            // 
            // fnameTb
            // 
            this.fnameTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "F_Name", true));
            this.fnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fnameTb.Location = new System.Drawing.Point(138, 238);
            this.fnameTb.Multiline = true;
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(205, 27);
            this.fnameTb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(376, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search:";
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTb.Location = new System.Drawing.Point(465, 114);
            this.searchTb.Multiline = true;
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(387, 27);
            this.searchTb.TabIndex = 9;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.AutoGenerateColumns = false;
            this.StudentDataGridView.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.id,
            this.lastname,
            this.firstname,
            this.studentid,
            this.classid,
            this.address});
            this.StudentDataGridView.DataSource = this.studentBindingSource1;
            this.StudentDataGridView.Location = new System.Drawing.Point(380, 158);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.Size = new System.Drawing.Size(567, 303);
            this.StudentDataGridView.TabIndex = 8;
            this.StudentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellContentClick);
            this.StudentDataGridView.SelectionChanged += new System.EventHandler(this.StudentDataGridView_SelectionChanged);
            this.StudentDataGridView.DoubleClick += new System.EventHandler(this.StudentDataGridView_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 20;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "L_Name";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "F_Name";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "Fast Name";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 20;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "L_Name";
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            this.lastname.Visible = false;
            this.lastname.Width = 150;
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "F_Name";
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            this.firstname.Visible = false;
            this.firstname.Width = 150;
            // 
            // studentid
            // 
            this.studentid.DataPropertyName = "StudentID";
            this.studentid.HeaderText = "Student ID";
            this.studentid.Name = "studentid";
            this.studentid.Visible = false;
            // 
            // classid
            // 
            this.classid.DataPropertyName = "Class";
            this.classid.HeaderText = "Class";
            this.classid.Name = "classid";
            this.classid.Visible = false;
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.Visible = false;
            this.address.Width = 177;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Addbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbutton.Location = new System.Drawing.Point(380, 480);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(91, 35);
            this.Addbutton.TabIndex = 5;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Updatebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Updatebutton.Location = new System.Drawing.Point(543, 480);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(91, 35);
            this.Updatebutton.TabIndex = 6;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Deletebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Deletebutton.Location = new System.Drawing.Point(702, 480);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(91, 35);
            this.Deletebutton.TabIndex = 7;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Clearbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clearbutton.Location = new System.Drawing.Point(856, 480);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(91, 35);
            this.Clearbutton.TabIndex = 8;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.viewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.viewbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewbtn.Location = new System.Drawing.Point(874, 109);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(73, 37);
            this.viewbtn.TabIndex = 10;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // Member_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1097, 570);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.StudentDataGridView);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fnameTb);
            this.Controls.Add(this.classTb);
            this.Controls.Add(this.lnameTb);
            this.Controls.Add(this.studentTb);
            this.Controls.Add(this.classLbl);
            this.Controls.Add(this.FnameLbl);
            this.Controls.Add(this.LnameLbl);
            this.Controls.Add(this.sudentidLbl);
            this.Controls.Add(this.label1);
            this.Name = "Member_Information";
            this.Text = "Student Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Member_Information_FormClosing);
            this.Load += new System.EventHandler(this.Member_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sudentidLbl;
        private System.Windows.Forms.Label LnameLbl;
        private System.Windows.Forms.Label FnameLbl;
        private System.Windows.Forms.Label classLbl;
        private System.Windows.Forms.TextBox studentTb;
        private System.Windows.Forms.TextBox lnameTb;
        private System.Windows.Forms.TextBox classTb;
        private System.Windows.Forms.TextBox fnameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn classid;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.BindingSource studentBindingSource1;
    }
}