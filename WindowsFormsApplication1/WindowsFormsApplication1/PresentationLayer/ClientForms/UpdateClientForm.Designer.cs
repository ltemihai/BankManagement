namespace BankManagementApplication.PresentationLayer
{
    partial class UpdateClientForm
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
            this.cnpTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.accountIdTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(58, 19);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(100, 20);
            this.cnpTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(58, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.Location = new System.Drawing.Point(58, 71);
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountIdTextBox.TabIndex = 2;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(58, 94);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(58, 120);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(58, 146);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(58, 183);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CNP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "IDCont";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data";
            // 
            // UpdateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 227);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.accountIdTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cnpTextBox);
            this.Name = "UpdateClientForm";
            this.Text = "InsertClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox accountIdTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}