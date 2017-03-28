namespace BankManagementApplication.PresentationLayer
{
    partial class AddAccountForm
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
            this.idAccountBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.idAccountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idAccountBox
            // 
            this.idAccountBox.Location = new System.Drawing.Point(73, 12);
            this.idAccountBox.Name = "idAccountBox";
            this.idAccountBox.Size = new System.Drawing.Size(100, 20);
            this.idAccountBox.TabIndex = 0;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(73, 38);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 1;
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.Location = new System.Drawing.Point(73, 64);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClientTextBox.TabIndex = 2;
            // 
            // idAccountLabel
            // 
            this.idAccountLabel.AutoSize = true;
            this.idAccountLabel.Location = new System.Drawing.Point(12, 15);
            this.idAccountLabel.Name = "idAccountLabel";
            this.idAccountLabel.Size = new System.Drawing.Size(55, 13);
            this.idAccountLabel.TabIndex = 3;
            this.idAccountLabel.Text = "idAccount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "idClient";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 135);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idAccountLabel);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.idAccountBox);
            this.Name = "AddAccountForm";
            this.Text = "AddAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idAccountBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.Label idAccountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}