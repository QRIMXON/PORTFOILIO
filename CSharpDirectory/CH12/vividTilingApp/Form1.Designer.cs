namespace Lab6
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
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRoomTotal = new System.Windows.Forms.Label();
            this.lblBoxesTotal = new System.Windows.Forms.Label();
            this.lblDisplay1 = new System.Windows.Forms.Label();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(110, 103);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 22);
            this.txtRoom.TabIndex = 0;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(268, 103);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 1;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(423, 103);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Length";
            // 
            // lblRoomTotal
            // 
            this.lblRoomTotal.AutoSize = true;
            this.lblRoomTotal.Location = new System.Drawing.Point(177, 212);
            this.lblRoomTotal.Name = "lblRoomTotal";
            this.lblRoomTotal.Size = new System.Drawing.Size(16, 17);
            this.lblRoomTotal.TabIndex = 7;
            this.lblRoomTotal.Text = "..";
            // 
            // lblBoxesTotal
            // 
            this.lblBoxesTotal.AutoSize = true;
            this.lblBoxesTotal.Location = new System.Drawing.Point(177, 254);
            this.lblBoxesTotal.Name = "lblBoxesTotal";
            this.lblBoxesTotal.Size = new System.Drawing.Size(16, 17);
            this.lblBoxesTotal.TabIndex = 8;
            this.lblBoxesTotal.Text = "..";
            // 
            // lblDisplay1
            // 
            this.lblDisplay1.AutoSize = true;
            this.lblDisplay1.Location = new System.Drawing.Point(83, 331);
            this.lblDisplay1.Name = "lblDisplay1";
            this.lblDisplay1.Size = new System.Drawing.Size(16, 17);
            this.lblDisplay1.TabIndex = 9;
            this.lblDisplay1.Text = "..";
            // 
            // lblDisplay2
            // 
            this.lblDisplay2.AutoSize = true;
            this.lblDisplay2.Location = new System.Drawing.Point(83, 366);
            this.lblDisplay2.Name = "lblDisplay2";
            this.lblDisplay2.Size = new System.Drawing.Size(16, 17);
            this.lblDisplay2.TabIndex = 10;
            this.lblDisplay2.Text = "..";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Rooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Boxes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDisplay2);
            this.Controls.Add(this.lblDisplay1);
            this.Controls.Add(this.lblBoxesTotal);
            this.Controls.Add(this.lblRoomTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtRoom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRoomTotal;
        private System.Windows.Forms.Label lblBoxesTotal;
        private System.Windows.Forms.Label lblDisplay1;
        private System.Windows.Forms.Label lblDisplay2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

