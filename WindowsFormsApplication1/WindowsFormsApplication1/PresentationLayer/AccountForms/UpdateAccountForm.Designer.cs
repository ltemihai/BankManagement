namespace BankManagementApplication.PresentationLayer
{
    partial class UpdateAccountForm
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
            this.idAccountLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.idClientLabel = new System.Windows.Forms.Label();
            this.idAccountTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idAccountLabel
            // 
            this.idAccountLabel.AutoSize = true;
            this.idAccountLabel.Location = new System.Drawing.Point(12, 9);
            this.idAccountLabel.Name = "idAccountLabel";
            this.idAccountLabel.Size = new System.Drawing.Size(55, 13);
            this.idAccountLabel.TabIndex = 0;
            this.idAccountLabel.Text = "idAccount";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(21, 35);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(46, 13);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "Balance";
            // 
            // idClientLabel
            // 
            this.idClientLabel.AutoSize = true;
            this.idClientLabel.Location = new System.Drawing.Point(26, 61);
            this.idClientLabel.Name = "idClientLabel";
            this.idClientLabel.Size = new System.Drawing.Size(41, 13);
            this.idClientLabel.TabIndex = 2;
            this.idClientLabel.Text = "idClient";
            // 
            // idAccountTextBox
            // 
            this.idAccountTextBox.Location = new System.Drawing.Point(73, 6);
            this.idAccountTextBox.Name = "idAccountTextBox";
            this.idAccountTextBox.Size = new System.Drawing.Size(100, 20);
            this.idAccountTextBox.TabIndex = 3;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(73, 32);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 4;
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.Location = new System.Drawing.Point(73, 58);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClientTextBox.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(57, 86);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 121);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.idAccountTextBox);
            this.Controls.Add(this.idClientLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.idAccountLabel);
            this.Name = "UpdateAccountForm";
            this.Text = "UpdateAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idAccountLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label idClientLabel;
        private System.Windows.Forms.TextBox idAccountTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.Button updateButton;
    }
}