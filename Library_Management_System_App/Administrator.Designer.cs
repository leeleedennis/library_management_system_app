﻿namespace Library_Management_System_App
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodicalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.periodicalsToolStripMenuItem,
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.deleteAccountToolStripMenuItem,
            this.memberInformationToolStripMenuItem,
            this.resetPasswordToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.usersToolStripMenuItem.Text = "Members";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.booksToolStripMenuItem.Text = "Book";
            // 
            // periodicalsToolStripMenuItem
            // 
            this.periodicalsToolStripMenuItem.Name = "periodicalsToolStripMenuItem";
            this.periodicalsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.periodicalsToolStripMenuItem.Text = "Periodical";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkInToolStripMenuItem.Text = "Check-In";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.checkOutToolStripMenuItem.Text = "Check-Out";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            // 
            // memberInformationToolStripMenuItem
            // 
            this.memberInformationToolStripMenuItem.Name = "memberInformationToolStripMenuItem";
            this.memberInformationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.memberInformationToolStripMenuItem.Text = "Member Information";
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Administrator";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodicalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}


