namespace BankManagementApplication.PresentationLayer.TransactionForms
{
    partial class TransferMoneyForm
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
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(12, 12);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(100, 20);
            this.FromTextBox.TabIndex = 0;
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(118, 12);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(100, 20);
            this.ToTextBox.TabIndex = 1;
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(224, 12);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(100, 20);
            this.moneyTextBox.TabIndex = 2;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(40, 35);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 13);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(158, 35);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(259, 35);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(28, 13);
            this.moneyLabel.TabIndex = 5;
            this.moneyLabel.Text = "Sum";
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(130, 51);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(75, 23);
            this.transferButton.TabIndex = 6;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // TransferMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 84);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Name = "TransferMoneyForm";
            this.Text = "TransferMoneyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button transferButton;
    }
}