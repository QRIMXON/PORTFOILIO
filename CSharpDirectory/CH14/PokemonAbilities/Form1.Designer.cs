namespace Lab4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnDark = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(62, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 232);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(354, 51);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(86, 44);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "Maximize";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Morph";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(359, 126);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(81, 49);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "Minimize";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnDark
            // 
            this.btnDark.Location = new System.Drawing.Point(361, 212);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(87, 45);
            this.btnDark.TabIndex = 4;
            this.btnDark.Text = "Dark";
            this.btnDark.UseVisualStyleBackColor = true;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // btnLight
            // 
            this.btnLight.Location = new System.Drawing.Point(361, 278);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(87, 52);
            this.btnLight.TabIndex = 5;
            this.btnLight.Text = "Light";
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.btnDark);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnDark;
        private System.Windows.Forms.Button btnLight;
    }
}

