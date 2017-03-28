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
    public partial class InsertClientForm : Form
    {
        public InsertClientForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            Repository<ClientGateway, Client> repository = new Repository<ClientGateway, Client>();
            Client client = repository.Insert(new Client(cnpTextBox.Text, nameTextBox.Text, accountIdTextBox.Text, typeTextBox.Text, addressTextBox.Text, dateTextBox.Text));

            if(client.Equals(null))
            {
                MessageBox.Show("Error!");
            }
            else
            {
                MessageBox.Show("Clientul cu CNP: " + client.Cnp + " a fost creat");
                this.Close();
            }
        }
    }
}
