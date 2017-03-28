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
    public partial class RemoveAccountForm : Form
    {
        public RemoveAccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repository<AccountGateway, Account> repository = new Repository<AccountGateway, Account>();
            Account account = repository.Delete(new Account(textBox1.Text));

            if (account.Equals(null))
            {
                MessageBox.Show("Error!");
            }
            else
            {
                MessageBox.Show("Contul cu ID-ul " + account.IdAccount + " a fost sters");
                this.Close();
            }
        }
    }
}
