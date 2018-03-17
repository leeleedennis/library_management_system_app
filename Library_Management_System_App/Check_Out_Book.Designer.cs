namespace Library_Management_System_App
{
    partial class Check_Out_Book
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
            this.boodIdLbl = new System.Windows.Forms.Label();
            this.memberIdLbl = new System.Windows.Forms.Label();
            this.currentDateLbl = new System.Windows.Forms.Label();
            this.returnDateLbl = new System.Windows.Forms.Label();
            this.checkoutboodidTb = new System.Windows.Forms.TextBox();
            this.checkoutmemberIdTB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.returndateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkoutborrowBtn = new System.Windows.Forms.Button();
            this.checkOutcancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(98, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue A Book";
            // 
            // boodIdLbl
            // 
            this.boodIdLbl.AutoSize = true;
            this.boodIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.boodIdLbl.Location = new System.Drawing.Point(29, 89);
            this.boodIdLbl.Name = "boodIdLbl";
            this.boodIdLbl.Size = new System.Drawing.Size(71, 20);
            this.boodIdLbl.TabIndex = 0;
            this.boodIdLbl.Text = "Book ID:";
            // 
            // memberIdLbl
            // 
            this.memberIdLbl.AutoSize = true;
            this.memberIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.memberIdLbl.Location = new System.Drawing.Point(29, 139);
            this.memberIdLbl.Name = "memberIdLbl";
            this.memberIdLbl.Size = new System.Drawing.Size(92, 20);
            this.memberIdLbl.TabIndex = 0;
            this.memberIdLbl.Text = "Member ID:";
            // 
            // currentDateLbl
            // 
            this.currentDateLbl.AutoSize = true;
            this.currentDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentDateLbl.Location = new System.Drawing.Point(29, 188);
            this.currentDateLbl.Name = "currentDateLbl";
            this.currentDateLbl.Size = new System.Drawing.Size(105, 20);
            this.currentDateLbl.TabIndex = 0;
            this.currentDateLbl.Text = "Current Date:";
            // 
            // returnDateLbl
            // 
            this.returnDateLbl.AutoSize = true;
            this.returnDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.returnDateLbl.Location = new System.Drawing.Point(29, 237);
            this.returnDateLbl.Name = "returnDateLbl";
            this.returnDateLbl.Size = new System.Drawing.Size(101, 20);
            this.returnDateLbl.TabIndex = 0;
            this.returnDateLbl.Text = "Return Date:";
            // 
            // checkoutboodidTb
            // 
            this.checkoutboodidTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkoutboodidTb.Location = new System.Drawing.Point(166, 89);
            this.checkoutboodidTb.Multiline = true;
            this.checkoutboodidTb.Name = "checkoutboodidTb";
            this.checkoutboodidTb.Size = new System.Drawing.Size(169, 29);
            this.checkoutboodidTb.TabIndex = 1;
            // 
            // checkoutmemberIdTB
            // 
            this.checkoutmemberIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkoutmemberIdTB.Location = new System.Drawing.Point(166, 141);
            this.checkoutmemberIdTB.Multiline = true;
            this.checkoutmemberIdTB.Name = "checkoutmemberIdTB";
            this.checkoutmemberIdTB.Size = new System.Drawing.Size(169, 29);
            this.checkoutmemberIdTB.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // returndateTimePicker
            // 
            this.returndateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.returndateTimePicker.Location = new System.Drawing.Point(166, 237);
            this.returndateTimePicker.Name = "returndateTimePicker";
            this.returndateTimePicker.Size = new System.Drawing.Size(169, 20);
            this.returndateTimePicker.TabIndex = 4;
            // 
            // checkoutborrowBtn
            // 
            this.checkoutborrowBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.checkoutborrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkoutborrowBtn.Location = new System.Drawing.Point(113, 289);
            this.checkoutborrowBtn.Name = "checkoutborrowBtn";
            this.checkoutborrowBtn.Size = new System.Drawing.Size(75, 34);
            this.checkoutborrowBtn.TabIndex = 5;
            this.checkoutborrowBtn.Text = "Borrow";
            this.checkoutborrowBtn.UseVisualStyleBackColor = false;
            this.checkoutborrowBtn.Click += new System.EventHandler(this.checkoutborrowBtn_Click);
            // 
            // checkOutcancelBtn
            // 
            this.checkOutcancelBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.checkOutcancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkOutcancelBtn.Location = new System.Drawing.Point(229, 289);
            this.checkOutcancelBtn.Name = "checkOutcancelBtn";
            this.checkOutcancelBtn.Size = new System.Drawing.Size(75, 34);
            this.checkOutcancelBtn.TabIndex = 6;
            this.checkOutcancelBtn.Text = "Cancel";
            this.checkOutcancelBtn.UseVisualStyleBackColor = false;
            this.checkOutcancelBtn.Click += new System.EventHandler(this.checkOutcancelBtn_Click);
            // 
            // Check_Out_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(402, 335);
            this.Controls.Add(this.checkOutcancelBtn);
            this.Controls.Add(this.checkoutborrowBtn);
            this.Controls.Add(this.returndateTimePicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkoutmemberIdTB);
            this.Controls.Add(this.checkoutboodidTb);
            this.Controls.Add(this.returnDateLbl);
            this.Controls.Add(this.currentDateLbl);
            this.Controls.Add(this.memberIdLbl);
            this.Controls.Add(this.boodIdLbl);
            this.Controls.Add(this.label1);
            this.Name = "Check_Out_Book";
            this.Text = "Issue Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label boodIdLbl;
        private System.Windows.Forms.Label memberIdLbl;
        private System.Windows.Forms.Label currentDateLbl;
        private System.Windows.Forms.Label returnDateLbl;
        private System.Windows.Forms.TextBox checkoutboodidTb;
        private System.Windows.Forms.TextBox checkoutmemberIdTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker returndateTimePicker;
        private System.Windows.Forms.Button checkoutborrowBtn;
        private System.Windows.Forms.Button checkOutcancelBtn;
    }
}