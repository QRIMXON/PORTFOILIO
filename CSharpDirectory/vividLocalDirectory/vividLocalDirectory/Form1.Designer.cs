namespace ex1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputVoid = new System.Windows.Forms.Label();
            this.output1 = new System.Windows.Forms.Label();
            this.output2 = new System.Windows.Forms.Label();
            this.output3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name or Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone #";
            // 
            // outputVoid
            // 
            this.outputVoid.AutoSize = true;
            this.outputVoid.Location = new System.Drawing.Point(272, 391);
            this.outputVoid.Name = "outputVoid";
            this.outputVoid.Size = new System.Drawing.Size(20, 17);
            this.outputVoid.TabIndex = 4;
            this.outputVoid.Text = "...";
            // 
            // output1
            // 
            this.output1.AutoSize = true;
            this.output1.Location = new System.Drawing.Point(272, 191);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(20, 17);
            this.output1.TabIndex = 5;
            this.output1.Text = "...";
            // 
            // output2
            // 
            this.output2.AutoSize = true;
            this.output2.Location = new System.Drawing.Point(272, 251);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(20, 17);
            this.output2.TabIndex = 6;
            this.output2.Text = "...";
            // 
            // output3
            // 
            this.output3.AutoSize = true;
            this.output3.Location = new System.Drawing.Point(272, 318);
            this.output3.Name = "output3";
            this.output3.Size = new System.Drawing.Size(20, 17);
            this.output3.TabIndex = 7;
            this.output3.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(275, 48);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(142, 22);
            this.input1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output3);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.outputVoid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputVoid;
        private System.Windows.Forms.Label output1;
        private System.Windows.Forms.Label output2;
        private System.Windows.Forms.Label output3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox input1;
    }
}

