using BankManagementApplication.PresentationLayer.TransactionForms;
using BusinessLayer.DataAccesLayer;
using BusinessLayer.Model;
using BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementApplication.PresentationLayer
{
    public partial class FrontForm : Form
    {
        public FrontForm()
        {
            InitializeComponent();
        }

        private void FrontForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankdbDataSet1.accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.bankdbDataSet1.accounts);
            // TODO: This line of code loads data into the 'bankdbDataSet.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.bankdbDataSet.clients);

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            InsertClientForm form = new InsertClientForm();
            form.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateClientForm form = new UpdateClientForm();
            form.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteClientForm form = new DeleteClientForm();
            form.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void findClientButton_Click(object sender, EventArgs e)
        {
            FindClientForm form = new FindClientForm();
            form.Show();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAccountForm form = new AddAccountForm();
            form.Show();
        }

        private void updateAccountButton_Click(object sender, EventArgs e)
        {
            UpdateAccountForm form = new UpdateAccountForm();
            form.Show();
        }

        private void removeAccountButton_Click(object sender, EventArgs e)
        {
            RemoveAccountForm form = new RemoveAccountForm();
            form.Show();
        }

        private void findAccountButton_Click(object sender, EventArgs e)
        {
            FindAccountForm form = new FindAccountForm();
            form.Show();
        }

        private void transferMoneyButton_Click(object sender, EventArgs e)
        {
            TransferMoneyForm form = new TransferMoneyForm();
            form.Show();
        }
    }
}
