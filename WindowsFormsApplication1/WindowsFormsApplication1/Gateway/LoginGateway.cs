using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class LoginGateway
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public string Login(string user, string password)
        {
            connection = new MySqlConnection("server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Not connected");
                connection.Close();
            }
            command = new MySqlCommand("SELECT * FROM login_accounts WHERE user = @user", connection);
            command.Parameters.AddWithValue("@user", user);

            MySqlDataReader dataReader = command.ExecuteReader();

            if (!dataReader.Read())
            {
                MessageBox.Show("Invalid user or password");
                return null;
            }
            string accountPassword = dataReader.GetString(1);
            
            if(accountPassword == password)
            {
                if (dataReader.GetString(2) == "admin")
                {
                    return "admin";
                }
                else if (dataReader.GetString(2) == "front")
                {
                    return "front";
                }
                else return null;
            }
            else
            {
                MessageBox.Show("Invalid user or password");
                return null;
            }
        }
    }
}
