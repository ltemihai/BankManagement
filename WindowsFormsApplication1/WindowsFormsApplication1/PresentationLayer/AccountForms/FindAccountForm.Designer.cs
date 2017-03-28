namespace BankManagementApplication.PresentationLayer
{
    partial class FindAccountForm
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
            this.findButton = new System.Windows.Forms.Button();
            this.findAccountIDTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(22, 38);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 0;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findAccountIDTextBox
            // 
            this.findAccountIDTextBox.Location = new System.Drawing.Point(12, 12);
            this.findAccountIDTextBox.Name = "findAccountIDTextBox";
            this.findAccountIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.findAccountIDTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 68);
            this.dataGridView1.TabIndex = 2;
            // 
            // FindAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 92);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.findAccountIDTextBox);
            this.Controls.Add(this.findButton);
            this.Name = "FindAccountForm";
            this.Text = "FindAccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox findAccountIDTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}