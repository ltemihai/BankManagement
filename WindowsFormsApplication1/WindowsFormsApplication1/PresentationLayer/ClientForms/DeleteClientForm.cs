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
    public partial class DeleteClientForm : Form
    {
        public DeleteClientForm()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Repository<ClientGateway, Client> repository = new Repository<ClientGateway, Client>();
            Client client = repository.Delete(new Client(idClientTextBox.Text));

            if (client.Equals(null))
            {
                MessageBox.Show("Error!");
            }
            else
            {
                MessageBox.Show("Clientul cu CNP " + client.Cnp + " a fost sters");
                this.Close();
            }
        }
    }
}
