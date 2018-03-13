namespace Library_Management_System_App
{
    partial class User_Account
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
            this.loginuserbutton = new System.Windows.Forms.Button();
            this.createuserbutton = new System.Windows.Forms.Button();
            this.edituserbutton = new System.Windows.Forms.Button();
            this.deleteuserbutton = new System.Windows.Forms.Button();
            this.canceluserbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginuserbutton
            // 
            this.loginuserbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginuserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginuserbutton.Location = new System.Drawing.Point(107, 72);
            this.loginuserbutton.Name = "loginuserbutton";
            this.loginuserbutton.Size = new System.Drawing.Size(202, 42);
            this.loginuserbutton.TabIndex = 0;
            this.loginuserbutton.Text = "Logn";
            this.loginuserbutton.UseVisualStyleBackColor = false;
            // 
            // createuserbutton
            // 
            this.createuserbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.createuserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createuserbutton.Location = new System.Drawing.Point(107, 130);
            this.createuserbutton.Name = "createuserbutton";
            this.createuserbutton.Size = new System.Drawing.Size(202, 42);
            this.createuserbutton.TabIndex = 1;
            this.createuserbutton.Text = "Create New User";
            this.createuserbutton.UseVisualStyleBackColor = false;
            this.createuserbutton.Click += new System.EventHandler(this.createuserbutton_Click);
            // 
            // edituserbutton
            // 
            this.edituserbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.edituserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.edituserbutton.Location = new System.Drawing.Point(107, 194);
            this.edituserbutton.Name = "edituserbutton";
            this.edituserbutton.Size = new System.Drawing.Size(202, 42);
            this.edituserbutton.TabIndex = 2;
            this.edituserbutton.Text = "Edit User";
            this.edituserbutton.UseVisualStyleBackColor = false;
            // 
            // deleteuserbutton
            // 
            this.deleteuserbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteuserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteuserbutton.Location = new System.Drawing.Point(107, 253);
            this.deleteuserbutton.Name = "deleteuserbutton";
            this.deleteuserbutton.Size = new System.Drawing.Size(202, 42);
            this.deleteuserbutton.TabIndex = 3;
            this.deleteuserbutton.Text = "Delete User";
            this.deleteuserbutton.UseVisualStyleBackColor = false;
            // 
            // canceluserbutton
            // 
            this.canceluserbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.canceluserbutton.Location = new System.Drawing.Point(154, 322);
            this.canceluserbutton.Name = "canceluserbutton";
            this.canceluserbutton.Size = new System.Drawing.Size(75, 23);
            this.canceluserbutton.TabIndex = 4;
            this.canceluserbutton.Text = "Cancel";
            this.canceluserbutton.UseVisualStyleBackColor = false;
            this.canceluserbutton.Click += new System.EventHandler(this.canceluserbutton_Click);
            // 
            // User_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::Library_Management_System_App.Properties.Resources.Library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 371);
            this.Controls.Add(this.canceluserbutton);
            this.Controls.Add(this.deleteuserbutton);
            this.Controls.Add(this.edituserbutton);
            this.Controls.Add(this.createuserbutton);
            this.Controls.Add(this.loginuserbutton);
            this.Name = "User_Account";
            this.Text = "User_Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginuserbutton;
        private System.Windows.Forms.Button createuserbutton;
        private System.Windows.Forms.Button edituserbutton;
        private System.Windows.Forms.Button deleteuserbutton;
        private System.Windows.Forms.Button canceluserbutton;
    }
}