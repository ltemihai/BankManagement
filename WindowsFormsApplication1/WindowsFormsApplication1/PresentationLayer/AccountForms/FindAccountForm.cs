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
    public partial class FindAccountForm : Form
    {
        public FindAccountForm()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Repository<AccountGateway, Account> repository = new Repository<AccountGateway, Account>();
            DataTable account = repository.Find(new Account(findAccountIDTextBox.Text));
            dataGridView1.DataSource = account;
        }
    }
}
