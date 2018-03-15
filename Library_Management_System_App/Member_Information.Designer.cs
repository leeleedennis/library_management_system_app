namespace Library_Management_System_App
{
    partial class Member_Information
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
            this.sudentidLbl = new System.Windows.Forms.Label();
            this.LnameLbl = new System.Windows.Forms.Label();
            this.FnameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.classLbl = new System.Windows.Forms.Label();
            this.studentTb = new System.Windows.Forms.TextBox();
            this.lnameTb = new System.Windows.Forms.TextBox();
            this.classTb = new System.Windows.Forms.TextBox();
            this.fnameTb = new System.Windows.Forms.TextBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(325, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sudentidLbl
            // 
            this.sudentidLbl.AutoSize = true;
            this.sudentidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sudentidLbl.Location = new System.Drawing.Point(31, 117);
            this.sudentidLbl.Name = "sudentidLbl";
            this.sudentidLbl.Size = new System.Drawing.Size(91, 20);
            this.sudentidLbl.TabIndex = 0;
            this.sudentidLbl.Text = "Student ID:";
            // 
            // LnameLbl
            // 
            this.LnameLbl.AutoSize = true;
            this.LnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LnameLbl.Location = new System.Drawing.Point(32, 156);
            this.LnameLbl.Name = "LnameLbl";
            this.LnameLbl.Size = new System.Drawing.Size(90, 20);
            this.LnameLbl.TabIndex = 0;
            this.LnameLbl.Text = "Last Name:";
            // 
            // FnameLbl
            // 
            this.FnameLbl.AutoSize = true;
            this.FnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FnameLbl.Location = new System.Drawing.Point(31, 197);
            this.FnameLbl.Name = "FnameLbl";
            this.FnameLbl.Size = new System.Drawing.Size(90, 20);
            this.FnameLbl.TabIndex = 0;
            this.FnameLbl.Text = "First Name:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addressLbl.Location = new System.Drawing.Point(31, 277);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(72, 20);
            this.addressLbl.TabIndex = 0;
            this.addressLbl.Text = "Address:";
            // 
            // classLbl
            // 
            this.classLbl.AutoSize = true;
            this.classLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.classLbl.Location = new System.Drawing.Point(32, 237);
            this.classLbl.Name = "classLbl";
            this.classLbl.Size = new System.Drawing.Size(52, 20);
            this.classLbl.TabIndex = 0;
            this.classLbl.Text = "Class:";
            // 
            // studentTb
            // 
            this.studentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.studentTb.Location = new System.Drawing.Point(138, 119);
            this.studentTb.Multiline = true;
            this.studentTb.Name = "studentTb";
            this.studentTb.Size = new System.Drawing.Size(205, 27);
            this.studentTb.TabIndex = 1;
            // 
            // lnameTb
            // 
            this.lnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lnameTb.Location = new System.Drawing.Point(138, 158);
            this.lnameTb.Multiline = true;
            this.lnameTb.Name = "lnameTb";
            this.lnameTb.Size = new System.Drawing.Size(205, 27);
            this.lnameTb.TabIndex = 2;
            // 
            // classTb
            // 
            this.classTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.classTb.Location = new System.Drawing.Point(138, 239);
            this.classTb.Multiline = true;
            this.classTb.Name = "classTb";
            this.classTb.Size = new System.Drawing.Size(205, 27);
            this.classTb.TabIndex = 4;
            // 
            // fnameTb
            // 
            this.fnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fnameTb.Location = new System.Drawing.Point(138, 197);
            this.fnameTb.Multiline = true;
            this.fnameTb.Name = "fnameTb";
            this.fnameTb.Size = new System.Drawing.Size(205, 27);
            this.fnameTb.TabIndex = 3;
            // 
            // addressTb
            // 
            this.addressTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addressTb.Location = new System.Drawing.Point(138, 277);
            this.addressTb.Multiline = true;
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(205, 129);
            this.addressTb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(413, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search:";
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTb.Location = new System.Drawing.Point(529, 117);
            this.searchTb.Multiline = true;
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(387, 27);
            this.searchTb.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 248);
            this.dataGridView1.TabIndex = 8;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Addbutton.Location = new System.Drawing.Point(138, 480);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(91, 35);
            this.Addbutton.TabIndex = 7;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Updatebutton.Location = new System.Drawing.Point(309, 480);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(91, 35);
            this.Updatebutton.TabIndex = 8;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Deletebutton.Location = new System.Drawing.Point(484, 480);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(91, 35);
            this.Deletebutton.TabIndex = 9;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clearbutton.Location = new System.Drawing.Point(666, 480);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(91, 35);
            this.Clearbutton.TabIndex = 10;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Member_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(941, 570);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTb);
            this.Controls.Add(this.fnameTb);
            this.Controls.Add(this.classTb);
            this.Controls.Add(this.lnameTb);
            this.Controls.Add(this.studentTb);
            this.Controls.Add(this.classLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.FnameLbl);
            this.Controls.Add(this.LnameLbl);
            this.Controls.Add(this.sudentidLbl);
            this.Controls.Add(this.label1);
            this.Name = "Member_Information";
            this.Text = "Member_Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sudentidLbl;
        private System.Windows.Forms.Label LnameLbl;
        private System.Windows.Forms.Label FnameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label classLbl;
        private System.Windows.Forms.TextBox studentTb;
        private System.Windows.Forms.TextBox lnameTb;
        private System.Windows.Forms.TextBox classTb;
        private System.Windows.Forms.TextBox fnameTb;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Clearbutton;
    }
}