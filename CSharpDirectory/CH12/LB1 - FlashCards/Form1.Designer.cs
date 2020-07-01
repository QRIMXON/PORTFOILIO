namespace LB1___FlashCards
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
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDefine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(10, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "What item would you like to learn about?";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(15, 267);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(169, 22);
            this.txtTerm.TabIndex = 1;
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDefinition.Location = new System.Drawing.Point(11, 409);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(0, 20);
            this.lblDefinition.TabIndex = 2;
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(15, 310);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(169, 22);
            this.txtDefinition.TabIndex = 3;
            this.txtDefinition.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(231, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDefine
            // 
            this.btnDefine.Location = new System.Drawing.Point(231, 266);
            this.btnDefine.Name = "btnDefine";
            this.btnDefine.Size = new System.Drawing.Size(91, 23);
            this.btnDefine.TabIndex = 2;
            this.btnDefine.Text = "Search";
            this.btnDefine.UseVisualStyleBackColor = true;
            this.btnDefine.Click += new System.EventHandler(this.btnDefine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(247, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "St. Louis Cafe\'s Allergen Guide";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(136, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(546, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "A Server\'s And Cook\'s Best Friend For Keeping Customers Safe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(337, 272);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(12, 17);
            this.lblAdd.TabIndex = 8;
            this.lblAdd.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 469);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDefine);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ingredient Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDefine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAdd;
    }
}

