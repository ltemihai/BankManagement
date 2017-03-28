using BusinessLayer.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataAccesLayer
{
    public class ClientGateway : GenericDataGateway<Client>
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public override Client Insert(Client entity)
        {
            connection = new MySqlConnection("server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");
            try
            {
                connection.Open();
            }
            catch { 
                connection.Close();
                return null;
            }
            command = new MySqlCommand("INSERT INTO clients(cnp,name,account_id,type,address,date_creation) VALUES (@cnp, @name, @account_id, @type, @address, @date_creation)", connection);
            command.Parameters.AddWithValue("@cnp", entity.Cnp);
            command.Parameters.AddWithValue("@name", entity.Name);
            command.Parameters.AddWithValue("@account_id", entity.AccountId);
            command.Parameters.AddWithValue("@type", entity.Type);
            command.Parameters.AddWithValue("@address", entity.Address);
            command.Parameters.AddWithValue("@date_creation", entity.CreationDate);
            command.ExecuteNonQuery();
            connection.Close();

            return entity;

        }

        public override Client Select(Client entity)
        {
            return null;
        }

        public override Client Update(Client entity)
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
            command = new MySqlCommand("UPDATE clients SET name=@name,account_id=@account_id,type=@type,address=@address,date_creation=@date_creation WHERE cnp = @cnp", connection);
            command.Parameters.AddWithValue("@cnp", entity.Cnp);
            command.Parameters.AddWithValue("@name", entity.Name);
            command.Parameters.AddWithValue("@account_id", entity.AccountId);
            command.Parameters.AddWithValue("@type", entity.Type);
            command.Parameters.AddWithValue("@address", entity.Address);
            command.Parameters.AddWithValue("@date_creation", entity.CreationDate);
            command.ExecuteNonQuery();
            connection.Close();

            return entity;
        }

        public override Client Delete(Client entity)
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

            command = new MySqlCommand("DELETE FROM clients WHERE cnp = @cnp",connection);
            command.Parameters.AddWithValue("@cnp", entity.Cnp);
            command.ExecuteNonQuery();
            connection.Close();
            return entity;

        }

        public override DataTable Find(Client entity)
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
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM clients WHERE cnp = '" + entity.Cnp + "'", "server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
