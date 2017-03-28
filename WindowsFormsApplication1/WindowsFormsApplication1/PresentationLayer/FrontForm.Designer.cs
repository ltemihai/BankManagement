namespace BankManagementApplication.PresentationLayer
{
    partial class FrontForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cnpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankdbDataSet = new BankManagementApplication.bankdbDataSet();
            this.clientsTableAdapter = new BankManagementApplication.bankdbDataSetTableAdapters.clientsTableAdapter();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clientOperationLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idaccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankdbDataSet1 = new BankManagementApplication.bankdbDataSet1();
            this.accountsTableAdapter = new BankManagementApplication.bankdbDataSet1TableAdapters.accountsTableAdapter();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.updateAccountButton = new System.Windows.Forms.Button();
            this.removeAccountButton = new System.Windows.Forms.Button();
            this.findAccountButton = new System.Windows.Forms.Button();
            this.accountOperationsLabel = new System.Windows.Forms.Label();
            this.findClientButton = new System.Windows.Forms.Button();
            this.transferMoneyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnpDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.accountidDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.datecreationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(167, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // cnpDataGridViewTextBoxColumn
            // 
            this.cnpDataGridViewTextBoxColumn.DataPropertyName = "cnp";
            this.cnpDataGridViewTextBoxColumn.HeaderText = "cnp";
            this.cnpDataGridViewTextBoxColumn.Name = "cnpDataGridViewTextBoxColumn";
            this.cnpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountidDataGridViewTextBoxColumn
            // 
            this.accountidDataGridViewTextBoxColumn.DataPropertyName = "account_id";
            this.accountidDataGridViewTextBoxColumn.HeaderText = "account_id";
            this.accountidDataGridViewTextBoxColumn.Name = "accountidDataGridViewTextBoxColumn";
            this.accountidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datecreationDataGridViewTextBoxColumn
            // 
            this.datecreationDataGridViewTextBoxColumn.DataPropertyName = "date_creation";
            this.datecreationDataGridViewTextBoxColumn.HeaderText = "date_creation";
            this.datecreationDataGridViewTextBoxColumn.Name = "datecreationDataGridViewTextBoxColumn";
            this.datecreationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.bankdbDataSet;
            // 
            // bankdbDataSet
            // 
            this.bankdbDataSet.DataSetName = "bankdbDataSet";
            this.bankdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(48, 56);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(48, 85);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(48, 114);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clientOperationLabel
            // 
            this.clientOperationLabel.AutoSize = true;
            this.clientOperationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientOperationLabel.Location = new System.Drawing.Point(12, 23);
            this.clientOperationLabel.Name = "clientOperationLabel";
            this.clientOperationLabel.Size = new System.Drawing.Size(148, 20);
            this.clientOperationLabel.TabIndex = 4;
            this.clientOperationLabel.Text = "Client Operations";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idaccountDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.accountsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(224, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 150);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idaccountDataGridViewTextBoxColumn
            // 
            this.idaccountDataGridViewTextBoxColumn.DataPropertyName = "id_account";
            this.idaccountDataGridViewTextBoxColumn.HeaderText = "id_account";
            this.idaccountDataGridViewTextBoxColumn.Name = "idaccountDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "id_client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "accounts";
            this.accountsBindingSource.DataSource = this.bankdbDataSet1;
            // 
            // bankdbDataSet1
            // 
            this.bankdbDataSet1.DataSetName = "bankdbDataSet1";
            this.bankdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(81, 226);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(95, 23);
            this.addAccountButton.TabIndex = 6;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // updateAccountButton
            // 
            this.updateAccountButton.Location = new System.Drawing.Point(81, 255);
            this.updateAccountButton.Name = "updateAccountButton";
            this.updateAccountButton.Size = new System.Drawing.Size(95, 23);
            this.updateAccountButton.TabIndex = 7;
            this.updateAccountButton.Text = "Update ";
            this.updateAccountButton.UseVisualStyleBackColor = true;
            this.updateAccountButton.Click += new System.EventHandler(this.updateAccountButton_Click);
            // 
            // removeAccountButton
            // 
            this.removeAccountButton.Location = new System.Drawing.Point(81, 284);
            this.removeAccountButton.Name = "removeAccountButton";
            this.removeAccountButton.Size = new System.Drawing.Size(95, 23);
            this.removeAccountButton.TabIndex = 8;
            this.removeAccountButton.Text = "Remove";
            this.removeAccountButton.UseVisualStyleBackColor = true;
            this.removeAccountButton.Click += new System.EventHandler(this.removeAccountButton_Click);
            // 
            // findAccountButton
            // 
            this.findAccountButton.Location = new System.Drawing.Point(81, 313);
            this.findAccountButton.Name = "findAccountButton";
            this.findAccountButton.Size = new System.Drawing.Size(95, 23);
            this.findAccountButton.TabIndex = 9;
            this.findAccountButton.Text = "Find";
            this.findAccountButton.UseVisualStyleBackColor = true;
            this.findAccountButton.Click += new System.EventHandler(this.findAccountButton_Click);
            // 
            // accountOperationsLabel
            // 
            this.accountOperationsLabel.AutoSize = true;
            this.accountOperationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.accountOperationsLabel.Location = new System.Drawing.Point(50, 193);
            this.accountOperationsLabel.Name = "accountOperationsLabel";
            this.accountOperationsLabel.Size = new System.Drawing.Size(168, 20);
            this.accountOperationsLabel.TabIndex = 10;
            this.accountOperationsLabel.Text = "Account Operations";
            // 
            // findClientButton
            // 
            this.findClientButton.Location = new System.Drawing.Point(48, 143);
            this.findClientButton.Name = "findClientButton";
            this.findClientButton.Size = new System.Drawing.Size(75, 23);
            this.findClientButton.TabIndex = 11;
            this.findClientButton.Text = "Find";
            this.findClientButton.UseVisualStyleBackColor = true;
            this.findClientButton.Click += new System.EventHandler(this.findClientButton_Click);
            // 
            // transferMoneyButton
            // 
            this.transferMoneyButton.Location = new System.Drawing.Point(651, 208);
            this.transferMoneyButton.Name = "transferMoneyButton";
            this.transferMoneyButton.Size = new System.Drawing.Size(75, 23);
            this.transferMoneyButton.TabIndex = 12;
            this.transferMoneyButton.Text = "Transfer";
            this.transferMoneyButton.UseVisualStyleBackColor = true;
            this.transferMoneyButton.Click += new System.EventHandler(this.transferMoneyButton_Click);
            // 
            // FrontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 375);
            this.Controls.Add(this.transferMoneyButton);
            this.Controls.Add(this.findClientButton);
            this.Controls.Add(this.accountOperationsLabel);
            this.Controls.Add(this.findAccountButton);
            this.Controls.Add(this.removeAccountButton);
            this.Controls.Add(this.updateAccountButton);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.clientOperationLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrontForm";
            this.Text = "FrontForm";
            this.Load += new System.EventHandler(this.FrontForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankdbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bankdbDataSet bankdbDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private bankdbDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label clientOperationLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private bankdbDataSet1 bankdbDataSet1;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private bankdbDataSet1TableAdapters.accountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Button updateAccountButton;
        private System.Windows.Forms.Button removeAccountButton;
        private System.Windows.Forms.Button findAccountButton;
        private System.Windows.Forms.Label accountOperationsLabel;
        private System.Windows.Forms.Button findClientButton;
        private System.Windows.Forms.Button transferMoneyButton;
    }
}