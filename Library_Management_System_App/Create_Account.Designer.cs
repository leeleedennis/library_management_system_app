namespace Library_Management_System_App
{
    partial class Create_Account
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
            this.titleLabl = new System.Windows.Forms.Label();
            this.usertypeLb = new System.Windows.Forms.Label();
            this.selecttypecomboBox = new System.Windows.Forms.ComboBox();
            this.createAccbutton = new System.Windows.Forms.Button();
            this.TypeusernameLbl = new System.Windows.Forms.Label();
            this.typepasswordLbl = new System.Windows.Forms.Label();
            this.typeconfirmpasswordLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.typePasswordtextBox = new System.Windows.Forms.TextBox();
            this.typeconfirmpasstextBox = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabl
            // 
            this.titleLabl.AutoSize = true;
            this.titleLabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabl.Location = new System.Drawing.Point(131, 20);
            this.titleLabl.Name = "titleLabl";
            this.titleLabl.Size = new System.Drawing.Size(264, 31);
            this.titleLabl.TabIndex = 0;
            this.titleLabl.Text = "Create New Account";
            // 
            // usertypeLb
            // 
            this.usertypeLb.AutoSize = true;
            this.usertypeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usertypeLb.Location = new System.Drawing.Point(48, 95);
            this.usertypeLb.Name = "usertypeLb";
            this.usertypeLb.Size = new System.Drawing.Size(145, 20);
            this.usertypeLb.TabIndex = 0;
            this.usertypeLb.Text = "Select type of user:";
            // 
            // selecttypecomboBox
            // 
            this.selecttypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selecttypecomboBox.FormattingEnabled = true;
            this.selecttypecomboBox.Items.AddRange(new object[] {
            "ADMIN",
            "STUDENT",
            "TEACHER"});
            this.selecttypecomboBox.Location = new System.Drawing.Point(217, 95);
            this.selecttypecomboBox.Name = "selecttypecomboBox";
            this.selecttypecomboBox.Size = new System.Drawing.Size(136, 28);
            this.selecttypecomboBox.TabIndex = 1;
            this.selecttypecomboBox.Text = "(Select Item)";
            // 
            // createAccbutton
            // 
            this.createAccbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.createAccbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createAccbutton.Location = new System.Drawing.Point(193, 322);
            this.createAccbutton.Name = "createAccbutton";
            this.createAccbutton.Size = new System.Drawing.Size(160, 33);
            this.createAccbutton.TabIndex = 5;
            this.createAccbutton.Text = "Create Account";
            this.createAccbutton.UseVisualStyleBackColor = false;
            // 
            // TypeusernameLbl
            // 
            this.TypeusernameLbl.AutoSize = true;
            this.TypeusernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TypeusernameLbl.Location = new System.Drawing.Point(48, 151);
            this.TypeusernameLbl.Name = "TypeusernameLbl";
            this.TypeusernameLbl.Size = new System.Drawing.Size(87, 20);
            this.TypeusernameLbl.TabIndex = 0;
            this.TypeusernameLbl.Text = "Username:";
            // 
            // typepasswordLbl
            // 
            this.typepasswordLbl.AutoSize = true;
            this.typepasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typepasswordLbl.Location = new System.Drawing.Point(48, 195);
            this.typepasswordLbl.Name = "typepasswordLbl";
            this.typepasswordLbl.Size = new System.Drawing.Size(82, 20);
            this.typepasswordLbl.TabIndex = 0;
            this.typepasswordLbl.Text = "Password:";
            // 
            // typeconfirmpasswordLbl
            // 
            this.typeconfirmpasswordLbl.AutoSize = true;
            this.typeconfirmpasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeconfirmpasswordLbl.Location = new System.Drawing.Point(48, 237);
            this.typeconfirmpasswordLbl.Name = "typeconfirmpasswordLbl";
            this.typeconfirmpasswordLbl.Size = new System.Drawing.Size(141, 20);
            this.typeconfirmpasswordLbl.TabIndex = 0;
            this.typeconfirmpasswordLbl.Text = "Confirm Password:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(217, 151);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 30);
            this.textBox1.TabIndex = 3;
            // 
            // typePasswordtextBox
            // 
            this.typePasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typePasswordtextBox.Location = new System.Drawing.Point(217, 192);
            this.typePasswordtextBox.Multiline = true;
            this.typePasswordtextBox.Name = "typePasswordtextBox";
            this.typePasswordtextBox.PasswordChar = '*';
            this.typePasswordtextBox.Size = new System.Drawing.Size(178, 30);
            this.typePasswordtextBox.TabIndex = 3;
            // 
            // typeconfirmpasstextBox
            // 
            this.typeconfirmpasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeconfirmpasstextBox.Location = new System.Drawing.Point(217, 234);
            this.typeconfirmpasstextBox.Multiline = true;
            this.typeconfirmpasstextBox.Name = "typeconfirmpasstextBox";
            this.typeconfirmpasstextBox.PasswordChar = '*';
            this.typeconfirmpasstextBox.Size = new System.Drawing.Size(178, 30);
            this.typeconfirmpasstextBox.TabIndex = 4;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backbutton.Location = new System.Drawing.Point(52, 411);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(118, 33);
            this.backbutton.TabIndex = 6;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelbutton.Location = new System.Drawing.Point(377, 411);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(114, 33);
            this.cancelbutton.TabIndex = 7;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // Create_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(518, 472);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.typeconfirmpasstextBox);
            this.Controls.Add(this.typePasswordtextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.typeconfirmpasswordLbl);
            this.Controls.Add(this.typepasswordLbl);
            this.Controls.Add(this.TypeusernameLbl);
            this.Controls.Add(this.createAccbutton);
            this.Controls.Add(this.selecttypecomboBox);
            this.Controls.Add(this.usertypeLb);
            this.Controls.Add(this.titleLabl);
            this.Name = "Create_Account";
            this.Text = "Create_Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabl;
        private System.Windows.Forms.Label usertypeLb;
        private System.Windows.Forms.ComboBox selecttypecomboBox;
        private System.Windows.Forms.Button createAccbutton;
        private System.Windows.Forms.Label TypeusernameLbl;
        private System.Windows.Forms.Label typepasswordLbl;
        private System.Windows.Forms.Label typeconfirmpasswordLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox typePasswordtextBox;
        private System.Windows.Forms.TextBox typeconfirmpasstextBox;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}