namespace Library_Management_System_App
{
    partial class Login_Form
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
            this.login_button = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.login_title = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login_button.Location = new System.Drawing.Point(45, 218);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(92, 32);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CancelButton.Location = new System.Drawing.Point(173, 218);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 32);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // login_title
            // 
            this.login_title.AutoSize = true;
            this.login_title.BackColor = System.Drawing.Color.Transparent;
            this.login_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.login_title.Location = new System.Drawing.Point(136, 9);
            this.login_title.Name = "login_title";
            this.login_title.Size = new System.Drawing.Size(87, 31);
            this.login_title.TabIndex = 2;
            this.login_title.Text = " Login";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usernameLbl.Location = new System.Drawing.Point(28, 82);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(97, 24);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.passwordLbl.Location = new System.Drawing.Point(28, 132);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(92, 24);
            this.passwordLbl.TabIndex = 0;
            this.passwordLbl.Text = "Password";
            // 
            // usernameTb
            // 
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameTb.Location = new System.Drawing.Point(141, 78);
            this.usernameTb.Multiline = true;
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(169, 28);
            this.usernameTb.TabIndex = 1;
            // 
            // passwordTb
            // 
            this.passwordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTb.Location = new System.Drawing.Point(141, 128);
            this.passwordTb.Multiline = true;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(169, 28);
            this.passwordTb.TabIndex = 2;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(355, 289);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.login_title);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.login_button);
            this.DoubleBuffered = true;
            this.Name = "Login_Form";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label login_title;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
    }
}

