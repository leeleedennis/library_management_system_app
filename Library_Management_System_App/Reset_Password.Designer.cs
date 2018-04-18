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
            this.resetButtonresetButton = new System.Windows.Forms.Button();
            this.newpassword_lbl = new System.Windows.Forms.Label();
            this.confirm_lbl = new System.Windows.Forms.Label();
            this.newpasswordTb = new System.Windows.Forms.TextBox();
            this.confirmPasswordTb = new System.Windows.Forms.TextBox();
            this.cancelresetButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.oldpasstb = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            // usernamelb
            // 
            this.usernamelb.AutoSize = true;
            this.usernamelb.BackColor = System.Drawing.Color.Transparent;
            this.usernamelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernamelb.Location = new System.Drawing.Point(32, 79);
            this.usernamelb.Name = "usernamelb";
            this.usernamelb.Size = new System.Drawing.Size(89, 20);
            this.usernamelb.TabIndex = 0;
            this.usernamelb.Text = "User Name";
            // 
            // pusernameTb1
            // 
            this.pusernameTb1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Name", true));
            this.pusernameTb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pusernameTb1.Location = new System.Drawing.Point(178, 79);
            this.pusernameTb1.Multiline = true;
            this.pusernameTb1.Name = "pusernameTb1";
            this.pusernameTb1.Size = new System.Drawing.Size(167, 29);
            this.pusernameTb1.TabIndex = 0;
            // 
            // resetButtonresetButton
            // 
            this.resetButtonresetButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.resetButtonresetButton.Location = new System.Drawing.Point(93, 264);
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
            this.newpassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newpassword_lbl.Location = new System.Drawing.Point(32, 171);
            this.newpassword_lbl.Name = "newpassword_lbl";
            this.newpassword_lbl.Size = new System.Drawing.Size(113, 20);
            this.newpassword_lbl.TabIndex = 0;
            this.newpassword_lbl.Text = "New Password";
            // 
            // confirm_lbl
            // 
            this.confirm_lbl.AutoSize = true;
            this.confirm_lbl.BackColor = System.Drawing.Color.Transparent;
            this.confirm_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirm_lbl.Location = new System.Drawing.Point(32, 214);
            this.confirm_lbl.Name = "confirm_lbl";
            this.confirm_lbl.Size = new System.Drawing.Size(137, 20);
            this.confirm_lbl.TabIndex = 0;
            this.confirm_lbl.Text = "Confirm Password";
            // 
            // newpasswordTb
            // 
            this.newpasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newpasswordTb.Location = new System.Drawing.Point(178, 162);
            this.newpasswordTb.Multiline = true;
            this.newpasswordTb.Name = "newpasswordTb";
            this.newpasswordTb.PasswordChar = '*';
            this.newpasswordTb.Size = new System.Drawing.Size(167, 29);
            this.newpasswordTb.TabIndex = 2;
            // 
            // confirmPasswordTb
            // 
            this.confirmPasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTb.Location = new System.Drawing.Point(178, 205);
            this.confirmPasswordTb.Multiline = true;
            this.confirmPasswordTb.Name = "confirmPasswordTb";
            this.confirmPasswordTb.PasswordChar = '*';
            this.confirmPasswordTb.Size = new System.Drawing.Size(167, 29);
            this.confirmPasswordTb.TabIndex = 3;
            // 
            // cancelresetButton
            // 
            this.cancelresetButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancelresetButton.Location = new System.Drawing.Point(236, 264);
            this.cancelresetButton.Name = "cancelresetButton";
            this.cancelresetButton.Size = new System.Drawing.Size(76, 32);
            this.cancelresetButton.TabIndex = 5;
            this.cancelresetButton.Text = "Cancel";
            this.cancelresetButton.UseVisualStyleBackColor = false;
            this.cancelresetButton.Click += new System.EventHandler(this.cancelresetButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(178, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(167, 29);
            this.textBox1.TabIndex = 1;
            // 
            // oldpasstb
            // 
            this.oldpasstb.AutoSize = true;
            this.oldpasstb.BackColor = System.Drawing.Color.Transparent;
            this.oldpasstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.oldpasstb.Location = new System.Drawing.Point(32, 127);
            this.oldpasstb.Name = "oldpasstb";
            this.oldpasstb.Size = new System.Drawing.Size(106, 20);
            this.oldpasstb.TabIndex = 7;
            this.oldpasstb.Text = "Old Password";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Library_Management_System_App.User);
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 326);
            this.Controls.Add(this.oldpasstb);
            this.Controls.Add(this.textBox1);
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
            this.Text = "Reset Password";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label oldpasstb;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}