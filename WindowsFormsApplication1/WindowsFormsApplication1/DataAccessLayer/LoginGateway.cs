using BusinessLayer.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace BusinessLayer.DataAccesLayer
{
    public class LoginGateway : GenericDataGateway<LoginUser>
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public override LoginUser Insert(LoginUser entity)
        {
            throw new NotImplementedException();
        }

        public override LoginUser Select(LoginUser entity)
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

            command = new MySqlCommand("SELECT * FROM login_accounts WHERE user = @user", connection);
            command.Parameters.AddWithValue("@user", entity.User);

            MySqlDataReader dataReader = command.ExecuteReader();

           
            if (!dataReader.Read())
            {
                return null;
            }
            return new LoginUser(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2));
        }

        public override LoginUser Update(LoginUser entity)
        {
            throw new NotImplementedException();
        }

        public override LoginUser Delete(LoginUser entity)
        {
            throw new NotImplementedException();
        }

        public override DataTable Find(LoginUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
