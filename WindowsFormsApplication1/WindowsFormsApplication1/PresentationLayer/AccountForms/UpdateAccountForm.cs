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

namespace BankManagementApplication.PresentationLayer
{
    public partial class UpdateAccountForm : Form
    {
        public UpdateAccountForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Repository<AccountGateway, Account> repository = new Repository<AccountGateway, Account>();
            Account account = repository.Update(new Account(idAccountTextBox.Text, float.Parse(balanceTextBox.Text), idClientTextBox.Text));

            if (account.Equals(null))
            {
                MessageBox.Show("Error!");
            }
            else
            {
                MessageBox.Show("Contul cu id-ul " + account.IdAccount + " a fost updatat");
            }
        }
    }
}
