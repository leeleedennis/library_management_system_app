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
            this.label1 = new System.Windows.Forms.Label();
            this.oldpassword_lbl = new System.Windows.Forms.Label();
            this.oldpasswordTb = new System.Windows.Forms.TextBox();
            this.resetButtonresetButton = new System.Windows.Forms.Button();
            this.newpassword_lbl = new System.Windows.Forms.Label();
            this.confirm_lbl = new System.Windows.Forms.Label();
            this.newpasswordTb = new System.Windows.Forms.TextBox();
            this.confirmPasswordTb = new System.Windows.Forms.TextBox();
            this.cancelresetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset Password";
            // 
            // oldpassword_lbl
            // 
            this.oldpassword_lbl.AutoSize = true;
            this.oldpassword_lbl.BackColor = System.Drawing.Color.PeachPuff;
            this.oldpassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.oldpassword_lbl.Location = new System.Drawing.Point(32, 79);
            this.oldpassword_lbl.Name = "oldpassword_lbl";
            this.oldpassword_lbl.Size = new System.Drawing.Size(106, 20);
            this.oldpassword_lbl.TabIndex = 0;
            this.oldpassword_lbl.Text = "Old Password";
            // 
            // oldpasswordTb
            // 
            this.oldpasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.oldpasswordTb.Location = new System.Drawing.Point(178, 79);
            this.oldpasswordTb.Multiline = true;
            this.oldpasswordTb.Name = "oldpasswordTb";
            this.oldpasswordTb.PasswordChar = '*';
            this.oldpasswordTb.Size = new System.Drawing.Size(167, 29);
            this.oldpasswordTb.TabIndex = 1;
            // 
            // resetButtonresetButton
            // 
            this.resetButtonresetButton.BackColor = System.Drawing.Color.BurlyWood;
            this.resetButtonresetButton.Location = new System.Drawing.Point(83, 274);
            this.resetButtonresetButton.Name = "resetButtonresetButton";
            this.resetButtonresetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButtonresetButton.TabIndex = 4;
            this.resetButtonresetButton.Text = "Reset";
            this.resetButtonresetButton.UseVisualStyleBackColor = false;
            this.resetButtonresetButton.Click += new System.EventHandler(this.resetButtonresetButton_Click);
            // 
            // newpassword_lbl
            // 
            this.newpassword_lbl.AutoSize = true;
            this.newpassword_lbl.BackColor = System.Drawing.Color.PeachPuff;
            this.newpassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newpassword_lbl.Location = new System.Drawing.Point(32, 136);
            this.newpassword_lbl.Name = "newpassword_lbl";
            this.newpassword_lbl.Size = new System.Drawing.Size(113, 20);
            this.newpassword_lbl.TabIndex = 0;
            this.newpassword_lbl.Text = "New Password";
            // 
            // confirm_lbl
            // 
            this.confirm_lbl.AutoSize = true;
            this.confirm_lbl.BackColor = System.Drawing.Color.PeachPuff;
            this.confirm_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirm_lbl.Location = new System.Drawing.Point(32, 194);
            this.confirm_lbl.Name = "confirm_lbl";
            this.confirm_lbl.Size = new System.Drawing.Size(137, 20);
            this.confirm_lbl.TabIndex = 0;
            this.confirm_lbl.Text = "Confirm Password";
            // 
            // newpasswordTb
            // 
            this.newpasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newpasswordTb.Location = new System.Drawing.Point(178, 136);
            this.newpasswordTb.Multiline = true;
            this.newpasswordTb.Name = "newpasswordTb";
            this.newpasswordTb.PasswordChar = '*';
            this.newpasswordTb.Size = new System.Drawing.Size(167, 29);
            this.newpasswordTb.TabIndex = 2;
            // 
            // confirmPasswordTb
            // 
            this.confirmPasswordTb.Location = new System.Drawing.Point(178, 194);
            this.confirmPasswordTb.Multiline = true;
            this.confirmPasswordTb.Name = "confirmPasswordTb";
            this.confirmPasswordTb.PasswordChar = '*';
            this.confirmPasswordTb.Size = new System.Drawing.Size(167, 29);
            this.confirmPasswordTb.TabIndex = 3;
            // 
            // cancelresetButton
            // 
            this.cancelresetButton.BackColor = System.Drawing.Color.BurlyWood;
            this.cancelresetButton.Location = new System.Drawing.Point(236, 273);
            this.cancelresetButton.Name = "cancelresetButton";
            this.cancelresetButton.Size = new System.Drawing.Size(75, 23);
            this.cancelresetButton.TabIndex = 5;
            this.cancelresetButton.Text = "Cancel";
            this.cancelresetButton.UseVisualStyleBackColor = false;
            this.cancelresetButton.Click += new System.EventHandler(this.cancelresetButton_Click);
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Management_System_App.Properties.Resources.Library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 326);
            this.Controls.Add(this.cancelresetButton);
            this.Controls.Add(this.confirmPasswordTb);
            this.Controls.Add(this.newpasswordTb);
            this.Controls.Add(this.confirm_lbl);
            this.Controls.Add(this.newpassword_lbl);
            this.Controls.Add(this.resetButtonresetButton);
            this.Controls.Add(this.oldpasswordTb);
            this.Controls.Add(this.oldpassword_lbl);
            this.Controls.Add(this.label1);
            this.Name = "Reset_Password";
            this.Text = "Reset_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oldpassword_lbl;
        private System.Windows.Forms.TextBox oldpasswordTb;
        private System.Windows.Forms.Button resetButtonresetButton;
        private System.Windows.Forms.Label newpassword_lbl;
        private System.Windows.Forms.Label confirm_lbl;
        private System.Windows.Forms.TextBox newpasswordTb;
        private System.Windows.Forms.TextBox confirmPasswordTb;
        private System.Windows.Forms.Button cancelresetButton;
    }
}