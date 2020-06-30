namespace Lab2
{
    partial class Form1
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
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtAttend = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtBegin = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRoomCount = new System.Windows.Forms.Label();
            this.lblAttendCount = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNameOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(86, 137);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(124, 28);
            this.txtGroup.TabIndex = 0;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(280, 137);
            this.txtStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(124, 28);
            this.txtStart.TabIndex = 1;
            // 
            // txtAttend
            // 
            this.txtAttend.Location = new System.Drawing.Point(468, 137);
            this.txtAttend.Margin = new System.Windows.Forms.Padding(4);
            this.txtAttend.Name = "txtAttend";
            this.txtAttend.Size = new System.Drawing.Size(124, 28);
            this.txtAttend.TabIndex = 2;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(650, 137);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(124, 28);
            this.txtRoom.TabIndex = 3;
            // 
            // txtBegin
            // 
            this.txtBegin.Location = new System.Drawing.Point(19, 364);
            this.txtBegin.Margin = new System.Windows.Forms.Padding(4);
            this.txtBegin.Name = "txtBegin";
            this.txtBegin.Size = new System.Drawing.Size(124, 28);
            this.txtBegin.TabIndex = 4;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(179, 364);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(124, 28);
            this.txtEnd.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(650, 188);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(334, 364);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 28);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Starting Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Earliest Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Latest Date";
            // 
            // lblRoomCount
            // 
            this.lblRoomCount.AutoSize = true;
            this.lblRoomCount.Location = new System.Drawing.Point(290, 197);
            this.lblRoomCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomCount.Name = "lblRoomCount";
            this.lblRoomCount.Size = new System.Drawing.Size(25, 24);
            this.lblRoomCount.TabIndex = 14;
            this.lblRoomCount.Text = "...";
            // 
            // lblAttendCount
            // 
            this.lblAttendCount.AutoSize = true;
            this.lblAttendCount.Location = new System.Drawing.Point(573, 197);
            this.lblAttendCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendCount.Name = "lblAttendCount";
            this.lblAttendCount.Size = new System.Drawing.Size(25, 24);
            this.lblAttendCount.TabIndex = 15;
            this.lblAttendCount.Text = "...";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOutput.Location = new System.Drawing.Point(202, 407);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(27, 25);
            this.lblOutput.TabIndex = 16;
            this.lblOutput.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 460);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(382, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "Project Database";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(55, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Scheduled Jobs This Month";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(401, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Monthly Sales";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(28, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(333, 29);
            this.label11.TabIndex = 22;
            this.label11.Text = "Search For Projects By Date";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(605, 364);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(139, 28);
            this.txtNameSearch.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(772, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 28);
            this.button2.TabIndex = 24;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(584, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(348, 29);
            this.label12.TabIndex = 25;
            this.label12.Text = "Search For Projects By Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(616, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "Enter Name";
            // 
            // lblNameOutput
            // 
            this.lblNameOutput.AutoSize = true;
            this.lblNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNameOutput.Location = new System.Drawing.Point(202, 432);
            this.lblNameOutput.Name = "lblNameOutput";
            this.lblNameOutput.Size = new System.Drawing.Size(27, 25);
            this.lblNameOutput.TabIndex = 27;
            this.lblNameOutput.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 551);
            this.Controls.Add(this.lblNameOutput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblAttendCount);
            this.Controls.Add(this.lblRoomCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtBegin);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtAttend);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Project Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtAttend;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtBegin;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRoomCount;
        private System.Windows.Forms.Label lblAttendCount;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNameOutput;
    }
}

