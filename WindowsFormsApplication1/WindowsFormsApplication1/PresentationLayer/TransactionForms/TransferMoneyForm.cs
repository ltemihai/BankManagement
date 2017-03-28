using BankManagementApplication.DataAccessLayer;
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

namespace BankManagementApplication.PresentationLayer.TransactionForms
{
    public partial class TransferMoneyForm : Form
    {
        public TransferMoneyForm()
        {
            InitializeComponent();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            Repository<TransactionGateway, Transaction> repository = new Repository<TransactionGateway, Transaction>();
            Transaction transaction = new Transaction(float.Parse(moneyTextBox.Text), DateTime.Now.ToString("yyy-MM-dd"), FromTextBox.Text,ToTextBox.Text);

            repository.Update(transaction);
            repository.Insert(transaction);

            if(transaction == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show("Transaction completed!");
            }
        }
    }
}
