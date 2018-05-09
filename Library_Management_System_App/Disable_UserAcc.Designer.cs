namespace Library_Management_System_App
{
    partial class Disable_UserAcc
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
            this.SearchLbl = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disableBtn = new System.Windows.Forms.Button();
            this.userdeletebtn = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage User";
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchLbl.Location = new System.Drawing.Point(50, 120);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(71, 20);
            this.SearchLbl.TabIndex = 0;
            this.SearchLbl.Text = "Search:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(127, 114);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(410, 31);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AllowUserToAddRows = false;
            this.UserDataGridView.AllowUserToDeleteRows = false;
            this.UserDataGridView.AutoGenerateColumns = false;
            this.UserDataGridView.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.type,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn,
            this.createdby,
            this.typeDataGridViewTextBoxColumn,
            this.username,
            this.datecreated,
            this.password});
            this.UserDataGridView.DataSource = this.userBindingSource;
            this.UserDataGridView.Location = new System.Drawing.Point(49, 162);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.Size = new System.Drawing.Size(618, 258);
            this.UserDataGridView.TabIndex = 2;
            this.UserDataGridView.SelectionChanged += new System.EventHandler(this.UserDataGridView_SelectionChanged);
            this.UserDataGridView.DoubleClick += new System.EventHandler(this.UserDataGridView_DoubleClick);
            // 
            // userid
            // 
            this.userid.DataPropertyName = "Id";
            this.userid.HeaderText = "Id";
            this.userid.Name = "userid";
            this.userid.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 20;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 200;
            // 
            // type
            // 
            this.type.DataPropertyName = "Type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.Visible = false;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "Date_Created";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.Width = 120;
            // 
            // createdbyDataGridViewTextBoxColumn
            // 
            this.createdbyDataGridViewTextBoxColumn.DataPropertyName = "Created_by";
            this.createdbyDataGridViewTextBoxColumn.HeaderText = "Created By";
            this.createdbyDataGridViewTextBoxColumn.Name = "createdbyDataGridViewTextBoxColumn";
            this.createdbyDataGridViewTextBoxColumn.Width = 110;
            // 
            // createdby
            // 
            this.createdby.DataPropertyName = "Created_by";
            this.createdby.HeaderText = "Created By";
            this.createdby.Name = "createdby";
            this.createdby.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // username
            // 
            this.username.DataPropertyName = "User_Name";
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            this.username.Visible = false;
            this.username.Width = 177;
            // 
            // datecreated
            // 
            this.datecreated.DataPropertyName = "Date_Created";
            this.datecreated.HeaderText = "Date Created";
            this.datecreated.Name = "datecreated";
            this.datecreated.Visible = false;
            this.datecreated.Width = 150;
            // 
            // password
            // 
            this.password.DataPropertyName = "Password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.Visible = false;
            this.password.Width = 150;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Library_Management_System_App.User);
            // 
            // disableBtn
            // 
            this.disableBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.disableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.disableBtn.Location = new System.Drawing.Point(49, 426);
            this.disableBtn.Name = "disableBtn";
            this.disableBtn.Size = new System.Drawing.Size(95, 33);
            this.disableBtn.TabIndex = 3;
            this.disableBtn.Text = "Reset";
            this.disableBtn.UseVisualStyleBackColor = false;
            this.disableBtn.Click += new System.EventHandler(this.disableBtn_Click);
            // 
            // userdeletebtn
            // 
            this.userdeletebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.userdeletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userdeletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userdeletebtn.Location = new System.Drawing.Point(313, 426);
            this.userdeletebtn.Name = "userdeletebtn";
            this.userdeletebtn.Size = new System.Drawing.Size(95, 33);
            this.userdeletebtn.TabIndex = 3;
            this.userdeletebtn.Text = "Delete";
            this.userdeletebtn.UseVisualStyleBackColor = false;
            this.userdeletebtn.Click += new System.EventHandler(this.userdeletebtn_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelbutton.Location = new System.Drawing.Point(572, 426);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(95, 33);
            this.Cancelbutton.TabIndex = 4;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Searchbutton.Location = new System.Drawing.Point(572, 114);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(95, 33);
            this.Searchbutton.TabIndex = 5;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            // 
            // Disable_UserAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(735, 471);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.userdeletebtn);
            this.Controls.Add(this.disableBtn);
            this.Controls.Add(this.UserDataGridView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.label1);
            this.Name = "Disable_UserAcc";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.Disable_UserAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.Button disableBtn;
        private System.Windows.Forms.Button userdeletebtn;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdby;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}