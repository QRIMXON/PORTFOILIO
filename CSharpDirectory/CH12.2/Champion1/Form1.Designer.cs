namespace Lab3
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
            this.txtPaladin = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPaladin
            // 
            this.txtPaladin.Location = new System.Drawing.Point(27, 29);
            this.txtPaladin.Name = "txtPaladin";
            this.txtPaladin.Size = new System.Drawing.Size(163, 22);
            this.txtPaladin.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(196, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "...";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(24, 127);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(20, 17);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "...";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(24, 189);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(20, 17);
            this.lblLeft.TabIndex = 4;
            this.lblLeft.Text = "...";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(24, 225);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(20, 17);
            this.lblRight.TabIndex = 5;
            this.lblRight.Text = "...";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(24, 295);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(20, 17);
            this.lblQ.TabIndex = 6;
            this.lblQ.Text = "...";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(24, 337);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(20, 17);
            this.lblF.TabIndex = 7;
            this.lblF.Text = "...";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(24, 372);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(20, 17);
            this.lblE.TabIndex = 8;
            this.lblE.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPaladin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPaladin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblE;
    }
}

