namespace Library_Management_System_App
{
    partial class Check_In_Book
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
            this.checkInbookIdLbl = new System.Windows.Forms.Label();
            this.checkInMemberIDLbl = new System.Windows.Forms.Label();
            this.fineDateLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.finedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fineamountTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check-In Book";
            // 
            // checkInbookIdLbl
            // 
            this.checkInbookIdLbl.AutoSize = true;
            this.checkInbookIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkInbookIdLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkInbookIdLbl.Location = new System.Drawing.Point(29, 103);
            this.checkInbookIdLbl.Name = "checkInbookIdLbl";
            this.checkInbookIdLbl.Size = new System.Drawing.Size(79, 20);
            this.checkInbookIdLbl.TabIndex = 0;
            this.checkInbookIdLbl.Text = "Book ID:";
            // 
            // checkInMemberIDLbl
            // 
            this.checkInMemberIDLbl.AutoSize = true;
            this.checkInMemberIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkInMemberIDLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkInMemberIDLbl.Location = new System.Drawing.Point(29, 154);
            this.checkInMemberIDLbl.Name = "checkInMemberIDLbl";
            this.checkInMemberIDLbl.Size = new System.Drawing.Size(102, 20);
            this.checkInMemberIDLbl.TabIndex = 0;
            this.checkInMemberIDLbl.Text = "Member ID:";
            this.checkInMemberIDLbl.Click += new System.EventHandler(this.checkInMemberIDLbl_Click);
            // 
            // fineDateLbl
            // 
            this.fineDateLbl.AutoSize = true;
            this.fineDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.fineDateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fineDateLbl.Location = new System.Drawing.Point(29, 203);
            this.fineDateLbl.Name = "fineDateLbl";
            this.fineDateLbl.Size = new System.Drawing.Size(93, 20);
            this.fineDateLbl.TabIndex = 0;
            this.fineDateLbl.Text = "Fine Date:";
            this.fineDateLbl.Click += new System.EventHandler(this.fineDateLbl_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 2;
            // 
            // finedateTimePicker
            // 
            this.finedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finedateTimePicker.Location = new System.Drawing.Point(162, 203);
            this.finedateTimePicker.Name = "finedateTimePicker";
            this.finedateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.finedateTimePicker.TabIndex = 3;
            // 
            // returnbutton
            // 
            this.returnbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.returnbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.returnbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnbutton.Location = new System.Drawing.Point(162, 308);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(75, 30);
            this.returnbutton.TabIndex = 5;
            this.returnbutton.Text = "Return";
            this.returnbutton.UseVisualStyleBackColor = false;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbutton.Location = new System.Drawing.Point(255, 308);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 30);
            this.cancelbutton.TabIndex = 6;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fine Amount:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fineamountTb
            // 
            this.fineamountTb.Location = new System.Drawing.Point(162, 250);
            this.fineamountTb.Name = "fineamountTb";
            this.fineamountTb.Size = new System.Drawing.Size(168, 20);
            this.fineamountTb.TabIndex = 4;
            this.fineamountTb.TextChanged += new System.EventHandler(this.fineamountTb_TextChanged);
            // 
            // Check_In_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(442, 350);
            this.Controls.Add(this.fineamountTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.finedateTimePicker);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fineDateLbl);
            this.Controls.Add(this.checkInMemberIDLbl);
            this.Controls.Add(this.checkInbookIdLbl);
            this.Controls.Add(this.label1);
            this.Name = "Check_In_Book";
            this.Text = "Check-In Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label checkInbookIdLbl;
        private System.Windows.Forms.Label checkInMemberIDLbl;
        private System.Windows.Forms.Label fineDateLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker finedateTimePicker;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fineamountTb;
    }
}