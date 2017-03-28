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
    public partial class FindClientForm : Form
    {
        public FindClientForm()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Repository<ClientGateway, Client> repository = new Repository<ClientGateway, Client>();
            DataTable client = repository.Find(new Client(textBox1.Text));
            dataGridView1.DataSource = client;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
