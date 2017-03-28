using BankManagementApplication.DataAccessLayer;
using BusinessLayer.Model;
using BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementApplication.PresentationLayer
{
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repository<AccountGateway, Account> repository = new Repository<AccountGateway, Account>();
            Account account = repository.Insert(new Account(idAccountBox.Text, float.Parse(balanceTextBox.Text, CultureInfo.InvariantCulture.NumberFormat), idClientTextBox.Text));

            if (account.Equals(null))
            {
                MessageBox.Show("Error!");
            }
            else
            {
                MessageBox.Show("Contul cu id-ul " + account.IdAccount + " a fost adaugat la utilizatorul cu id-ul " + account.IdClient);
            }
        }
    }
}
