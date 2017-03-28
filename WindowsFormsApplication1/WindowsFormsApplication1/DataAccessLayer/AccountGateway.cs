using BusinessLayer.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessLayer.Model;
using MySql.Data.MySqlClient;

namespace BankManagementApplication.DataAccessLayer
{
    class AccountGateway : GenericDataGateway<Account>
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public override Account Delete(Account entity)
        {
            connection = new MySqlConnection("server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return null;
            }

            command = new MySqlCommand("DELETE FROM accounts WHERE id_account = @idAccount", connection);
            command.Parameters.AddWithValue("@idAccount", entity.IdAccount);
            command.ExecuteNonQuery();
            connection.Close();
            return entity;
        }

        public override DataTable Find(Account entity)
        {
            connection = new MySqlConnection("server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return null;
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM accounts WHERE id_account = '" + entity.IdAccount + "'", "server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public override Account Insert(Account entity)
        {
            connection = new MySqlConnection("server = localhost; user id = mihai; password = mihai; persistsecurityinfo = True; database = bankdb");
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return null;
            }

            command = new MySqlCommand("INSERT INTO accounts(id_account,balance,id_client) VALUES (@idAccount,@balance,@idClient)", connection);
            command.Parameters.AddWithValue("@idAccount", entity.IdAccount);
            command.Parameters.AddWithValue("@balance", entity.Balance);
            command.Parameters.AddWithValue("@idClient", entity.IdClient);
            command.ExecuteNonQuery();
            connection.Close();

            return entity;
        }

        public override Account Select(Account entity)
        {
            throw new NotImplementedException();
        }

        public override Account Update(Account entity)
        {
            connection = new MySqlConnection("server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return null;
            }
            command = new MySqlCommand("UPDATE accounts SET balance=@balance,id_client=@idClient WHERE id_account = @idAccount", connection);
            command.Parameters.AddWithValue("@balance", entity.Balance);
            command.Parameters.AddWithValue("@idClient", entity.IdClient);
            command.Parameters.AddWithValue("@idAccount", entity.IdAccount);
            command.ExecuteNonQuery();
            connection.Close();

            return entity;
        }
    }
}
