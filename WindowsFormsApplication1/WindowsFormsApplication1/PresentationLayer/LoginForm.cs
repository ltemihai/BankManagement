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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Repository<LoginGateway, LoginUser> repository = new Repository<LoginGateway, LoginUser>();
            LoginUser result = repository.Select(new LoginUser(userTextBox.Text, passwordTextBox.Text));

            if (result == null)
            {
                MessageBox.Show("Connection error");
            }
            else if (result.Type == "admin")
            {
                AdminForm form = new AdminForm();
                this.Hide();
                form.Show();
                
            }
            else if (result.Type == "front")
            {
                FrontForm form = new FrontForm();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
