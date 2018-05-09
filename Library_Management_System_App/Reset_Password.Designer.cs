namespace Library_Management_System_App
{
    partial class Reset_Password
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
            this.usernamelb = new System.Windows.Forms.Label();
            this.pusernameTb1 = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resetButtonresetButton = new System.Windows.Forms.Button();
            this.newpassword_lbl = new System.Windows.Forms.Label();
            this.confirm_lbl = new System.Windows.Forms.Label();
            this.newpasswordTb = new System.Windows.Forms.TextBox();
            this.confirmPasswordTb = new System.Windows.Forms.TextBox();
            this.cancelresetButton = new System.Windows.Forms.Button();
            this.oldpasstb = new System.Windows.Forms.TextBox();
            this.oldpasslbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // usernamelb
            // 
            this.usernamelb.AutoSize = true;
            this.usernamelb.BackColor = System.Drawing.Color.Transparent;
            this.usernamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.usernamelb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernamelb.Location = new System.Drawing.Point(32, 79);
            this.usernamelb.Name = "usernamelb";
            this.usernamelb.Size = new System.Drawing.Size(85, 18);
            this.usernamelb.TabIndex = 0;
            this.usernamelb.Text = "Username";
            // 
            // pusernameTb1
            // 
            this.pusernameTb1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Name", true));
            this.pusernameTb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pusernameTb1.Location = new System.Drawing.Point(191, 79);
            this.pusernameTb1.Multiline = true;
            this.pusernameTb1.Name = "pusernameTb1";
            this.pusernameTb1.Size = new System.Drawing.Size(167, 29);
            this.pusernameTb1.TabIndex = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Library_Management_System_App.User);
            // 
            // resetButtonresetButton
            // 
            this.resetButtonresetButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.resetButtonresetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButtonresetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetButtonresetButton.Location = new System.Drawing.Point(191, 263);
            this.resetButtonresetButton.Name = "resetButtonresetButton";
            this.resetButtonresetButton.Size = new System.Drawing.Size(76, 33);
            this.resetButtonresetButton.TabIndex = 4;
            this.resetButtonresetButton.Text = "Reset";
            this.resetButtonresetButton.UseVisualStyleBackColor = false;
            this.resetButtonresetButton.Click += new System.EventHandler(this.resetButtonresetButton_Click);
            // 
            // newpassword_lbl
            // 
            this.newpassword_lbl.AutoSize = true;
            this.newpassword_lbl.BackColor = System.Drawing.Color.Transparent;
            this.newpassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.newpassword_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newpassword_lbl.Location = new System.Drawing.Point(32, 171);
            this.newpassword_lbl.Name = "newpassword_lbl";
            this.newpassword_lbl.Size = new System.Drawing.Size(121, 18);
            this.newpassword_lbl.TabIndex = 0;
            this.newpassword_lbl.Text = "New Password";
            // 
            // confirm_lbl
            // 
            this.confirm_lbl.AutoSize = true;
            this.confirm_lbl.BackColor = System.Drawing.Color.Transparent;
            this.confirm_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.confirm_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirm_lbl.Location = new System.Drawing.Point(32, 214);
            this.confirm_lbl.Name = "confirm_lbl";
            this.confirm_lbl.Size = new System.Drawing.Size(148, 18);
            this.confirm_lbl.TabIndex = 0;
            this.confirm_lbl.Text = "Confirm Password";
            // 
            // newpasswordTb
            // 
            this.newpasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newpasswordTb.Location = new System.Drawing.Point(191, 162);
            this.newpasswordTb.Multiline = true;
            this.newpasswordTb.Name = "newpasswordTb";
            this.newpasswordTb.PasswordChar = '*';
            this.newpasswordTb.Size = new System.Drawing.Size(167, 29);
            this.newpasswordTb.TabIndex = 2;
            // 
            // confirmPasswordTb
            // 
            this.confirmPasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTb.Location = new System.Drawing.Point(191, 205);
            this.confirmPasswordTb.Multiline = true;
            this.confirmPasswordTb.Name = "confirmPasswordTb";
            this.confirmPasswordTb.PasswordChar = '*';
            this.confirmPasswordTb.Size = new System.Drawing.Size(167, 29);
            this.confirmPasswordTb.TabIndex = 3;
            // 
            // cancelresetButton
            // 
            this.cancelresetButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancelresetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelresetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelresetButton.Location = new System.Drawing.Point(282, 264);
            this.cancelresetButton.Name = "cancelresetButton";
            this.cancelresetButton.Size = new System.Drawing.Size(76, 32);
            this.cancelresetButton.TabIndex = 5;
            this.cancelresetButton.Text = "Cancel";
            this.cancelresetButton.UseVisualStyleBackColor = false;
            this.cancelresetButton.Click += new System.EventHandler(this.cancelresetButton_Click);
            // 
            // oldpasstb
            // 
            this.oldpasstb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.oldpasstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.oldpasstb.Location = new System.Drawing.Point(191, 118);
            this.oldpasstb.Multiline = true;
            this.oldpasstb.Name = "oldpasstb";
            this.oldpasstb.PasswordChar = '*';
            this.oldpasstb.Size = new System.Drawing.Size(167, 29);
            this.oldpasstb.TabIndex = 1;
            // 
            // oldpasslbl
            // 
            this.oldpasslbl.AutoSize = true;
            this.oldpasslbl.BackColor = System.Drawing.Color.Transparent;
            this.oldpasslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.oldpasslbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oldpasslbl.Location = new System.Drawing.Point(32, 127);
            this.oldpasslbl.Name = "oldpasslbl";
            this.oldpasslbl.Size = new System.Drawing.Size(114, 18);
            this.oldpasslbl.TabIndex = 7;
            this.oldpasslbl.Text = "Old Password";
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 326);
            this.Controls.Add(this.oldpasslbl);
            this.Controls.Add(this.oldpasstb);
            this.Controls.Add(this.cancelresetButton);
            this.Controls.Add(this.confirmPasswordTb);
            this.Controls.Add(this.newpasswordTb);
            this.Controls.Add(this.confirm_lbl);
            this.Controls.Add(this.newpassword_lbl);
            this.Controls.Add(this.resetButtonresetButton);
            this.Controls.Add(this.pusernameTb1);
            this.Controls.Add(this.usernamelb);
            this.Controls.Add(this.label1);
            this.Name = "Reset_Password";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Reset_Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernamelb;
        private System.Windows.Forms.TextBox pusernameTb1;
        private System.Windows.Forms.Button resetButtonresetButton;
        private System.Windows.Forms.Label newpassword_lbl;
        private System.Windows.Forms.Label confirm_lbl;
        private System.Windows.Forms.TextBox newpasswordTb;
        private System.Windows.Forms.TextBox confirmPasswordTb;
        private System.Windows.Forms.Button cancelresetButton;
        private System.Windows.Forms.TextBox oldpasstb;
        private System.Windows.Forms.Label oldpasslbl;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}