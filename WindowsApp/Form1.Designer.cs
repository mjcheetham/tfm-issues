namespace WindowsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.uptimeButton = new System.Windows.Forms.Button();
            this.uptimeLabel = new System.Windows.Forms.Label();
            this.baseUriTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uptimeButton
            // 
            this.uptimeButton.Location = new System.Drawing.Point(55, 45);
            this.uptimeButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.uptimeButton.Name = "uptimeButton";
            this.uptimeButton.Size = new System.Drawing.Size(69, 19);
            this.uptimeButton.TabIndex = 0;
            this.uptimeButton.Text = "Get Uptime";
            this.uptimeButton.UseVisualStyleBackColor = true;
            this.uptimeButton.Click += new System.EventHandler(this.uptimeButton_Click);
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.AutoSize = true;
            this.uptimeLabel.Location = new System.Drawing.Point(91, 81);
            this.uptimeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uptimeLabel.Name = "uptimeLabel";
            this.uptimeLabel.Size = new System.Drawing.Size(87, 13);
            this.uptimeLabel.TabIndex = 1;
            this.uptimeLabel.Text = "Unknown uptime";
            this.uptimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // baseUriTextBox
            // 
            this.baseUriTextBox.Location = new System.Drawing.Point(36, 11);
            this.baseUriTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.baseUriTextBox.Name = "baseUriTextBox";
            this.baseUriTextBox.Size = new System.Drawing.Size(196, 20);
            this.baseUriTextBox.TabIndex = 2;
            this.baseUriTextBox.Text = "http://localhost:5000";
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(149, 45);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 19);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 113);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.baseUriTextBox);
            this.Controls.Add(this.uptimeLabel);
            this.Controls.Add(this.uptimeButton);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button uptimeButton;
        private System.Windows.Forms.Label uptimeLabel;
        private System.Windows.Forms.TextBox baseUriTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}

