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
            this.createAccbutton = new System.Windows.Forms.Button();
            this.TypeusernameLbl = new System.Windows.Forms.Label();
            this.typepasswordLbl = new System.Windows.Forms.Label();
            this.typeconfirmpasswordLbl = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.confirmpasstextBox = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.typetb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titleLabl
            // 
            this.titleLabl.AutoSize = true;
            this.titleLabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabl.Location = new System.Drawing.Point(46, 40);
            this.titleLabl.Name = "titleLabl";
            this.titleLabl.Size = new System.Drawing.Size(282, 31);
            this.titleLabl.TabIndex = 0;
            this.titleLabl.Text = "Create New Account";
            // 
            // usertypeLb
            // 
            this.usertypeLb.AutoSize = true;
            this.usertypeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.usertypeLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usertypeLb.Location = new System.Drawing.Point(48, 115);
            this.usertypeLb.Name = "usertypeLb";
            this.usertypeLb.Size = new System.Drawing.Size(113, 20);
            this.usertypeLb.TabIndex = 0;
            this.usertypeLb.Text = "Type of user:";
            // 
            // createAccbutton
            // 
            this.createAccbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.createAccbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.createAccbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createAccbutton.Location = new System.Drawing.Point(217, 295);
            this.createAccbutton.Name = "createAccbutton";
            this.createAccbutton.Size = new System.Drawing.Size(84, 33);
            this.createAccbutton.TabIndex = 4;
            this.createAccbutton.Text = "Create";
            this.createAccbutton.UseVisualStyleBackColor = false;
            this.createAccbutton.Click += new System.EventHandler(this.createAccbutton_Click);
            // 
            // TypeusernameLbl
            // 
            this.TypeusernameLbl.AutoSize = true;
            this.TypeusernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TypeusernameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TypeusernameLbl.Location = new System.Drawing.Point(48, 154);
            this.TypeusernameLbl.Name = "TypeusernameLbl";
            this.TypeusernameLbl.Size = new System.Drawing.Size(96, 20);
            this.TypeusernameLbl.TabIndex = 0;
            this.TypeusernameLbl.Text = "Username:";
            // 
            // typepasswordLbl
            // 
            this.typepasswordLbl.AutoSize = true;
            this.typepasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.typepasswordLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.typepasswordLbl.Location = new System.Drawing.Point(48, 195);
            this.typepasswordLbl.Name = "typepasswordLbl";
            this.typepasswordLbl.Size = new System.Drawing.Size(91, 20);
            this.typepasswordLbl.TabIndex = 0;
            this.typepasswordLbl.Text = "Password:";
            // 
            // typeconfirmpasswordLbl
            // 
            this.typeconfirmpasswordLbl.AutoSize = true;
            this.typeconfirmpasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.typeconfirmpasswordLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.typeconfirmpasswordLbl.Location = new System.Drawing.Point(48, 237);
            this.typeconfirmpasswordLbl.Name = "typeconfirmpasswordLbl";
            this.typeconfirmpasswordLbl.Size = new System.Drawing.Size(158, 20);
            this.typeconfirmpasswordLbl.TabIndex = 0;
            this.typeconfirmpasswordLbl.Text = "Confirm Password:";
            // 
            // UserBox
            // 
            this.UserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserBox.Location = new System.Drawing.Point(217, 151);
            this.UserBox.Multiline = true;
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(191, 30);
            this.UserBox.TabIndex = 1;
            this.UserBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordtextBox.Location = new System.Drawing.Point(217, 192);
            this.PasswordtextBox.Multiline = true;
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.PasswordChar = '*';
            this.PasswordtextBox.Size = new System.Drawing.Size(191, 30);
            this.PasswordtextBox.TabIndex = 2;
            // 
            // confirmpasstextBox
            // 
            this.confirmpasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmpasstextBox.Location = new System.Drawing.Point(217, 234);
            this.confirmpasstextBox.Multiline = true;
            this.confirmpasstextBox.Name = "confirmpasstextBox";
            this.confirmpasstextBox.PasswordChar = '*';
            this.confirmpasstextBox.Size = new System.Drawing.Size(191, 30);
            this.confirmpasstextBox.TabIndex = 3;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbutton.Location = new System.Drawing.Point(217, 363);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(84, 33);
            this.backbutton.TabIndex = 5;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbutton.Location = new System.Drawing.Point(327, 295);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(81, 33);
            this.cancelbutton.TabIndex = 6;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // typetb
            // 
            this.typetb.BackColor = System.Drawing.Color.White;
            this.typetb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typetb.ForeColor = System.Drawing.Color.Black;
            this.typetb.FormattingEnabled = true;
            this.typetb.ItemHeight = 20;
            this.typetb.Items.AddRange(new object[] {
            "Admin",
            "Teacher"});
            this.typetb.Location = new System.Drawing.Point(217, 112);
            this.typetb.Name = "typetb";
            this.typetb.Size = new System.Drawing.Size(191, 28);
            this.typetb.TabIndex = 0;
            // 
            // Create_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(518, 472);
            this.Controls.Add(this.typetb);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.confirmpasstextBox);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.typeconfirmpasswordLbl);
            this.Controls.Add(this.typepasswordLbl);
            this.Controls.Add(this.TypeusernameLbl);
            this.Controls.Add(this.createAccbutton);
            this.Controls.Add(this.usertypeLb);
            this.Controls.Add(this.titleLabl);
            this.Name = "Create_Account";
            this.Text = "Create New Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabl;
        private System.Windows.Forms.Label usertypeLb;
        private System.Windows.Forms.Button createAccbutton;
        private System.Windows.Forms.Label TypeusernameLbl;
        private System.Windows.Forms.Label typepasswordLbl;
        private System.Windows.Forms.Label typeconfirmpasswordLbl;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox confirmpasstextBox;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.ComboBox typetb;
    }
}