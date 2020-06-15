namespace Lab1
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
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblSentDate = new System.Windows.Forms.Label();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtSentDate = new System.Windows.Forms.TextBox();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(28, 68);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(67, 17);
            this.lblRecipient.TabIndex = 0;
            this.lblRecipient.Text = "Recipient";
            // 
            // lblSentDate
            // 
            this.lblSentDate.AutoSize = true;
            this.lblSentDate.Location = new System.Drawing.Point(28, 145);
            this.lblSentDate.Name = "lblSentDate";
            this.lblSentDate.Size = new System.Drawing.Size(71, 17);
            this.lblSentDate.TabIndex = 1;
            this.lblSentDate.Text = "Sent Date";
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Location = new System.Drawing.Point(12, 234);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(117, 17);
            this.lblTrackingNumber.TabIndex = 2;
            this.lblTrackingNumber.Text = "Tracking Number";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(28, 284);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(230, 17);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "(Additional Fee For Certified Letter)";
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(141, 65);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(100, 22);
            this.txtRecipient.TabIndex = 4;
            // 
            // txtSentDate
            // 
            this.txtSentDate.Location = new System.Drawing.Point(141, 145);
            this.txtSentDate.Name = "txtSentDate";
            this.txtSentDate.Size = new System.Drawing.Size(100, 22);
            this.txtSentDate.TabIndex = 5;
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Location = new System.Drawing.Point(141, 229);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(100, 22);
            this.txtTrackingNumber.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(297, 65);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(444, 42);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(296, 375);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.TabStop = false;
            this.lblOutput.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtTrackingNumber);
            this.Controls.Add(this.txtSentDate);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTrackingNumber);
            this.Controls.Add(this.lblSentDate);
            this.Controls.Add(this.lblRecipient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblSentDate;
        private System.Windows.Forms.Label lblTrackingNumber;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtSentDate;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox lblOutput;
    }
}

