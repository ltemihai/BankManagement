using BusinessLayer.DataAccesLayer;
using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace BankManagementApplication.DataAccessLayer
{
    

    class TransactionGateway : GenericDataGateway<Transaction>
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        public override Transaction Delete(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public override DataTable Find(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public override Transaction Insert(Transaction entity)
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
            command = new MySqlCommand("INSERT INTO transactions(amount,date,account_id,transfer_id) VALUES (@balance,@date,@idAccount,@idTransfer)", connection);
            command.Parameters.AddWithValue("@balance", entity.Amount);
            command.Parameters.AddWithValue("@date", entity.Date);
            command.Parameters.AddWithValue("@idAccount", entity.AccountId);
            command.Parameters.AddWithValue("@idTransfer", entity.ToTransferId);
            command.ExecuteNonQuery();
            connection.Close();

            return entity;
        }

        public override Transaction Select(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public override Transaction Update(Transaction entity)
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
            command = new MySqlCommand("UPDATE accounts SET balance=balance + @balance WHERE id_account = @idTransferAccount;UPDATE accounts SET balance = balance - @balance WHERE id_account = @idAccount AND balance > @balance", connection);
            command.Parameters.AddWithValue("@balance", entity.Amount);
            command.Parameters.AddWithValue("@idAccount", entity.AccountId);
            command.Parameters.AddWithValue("@idTransferAccount", entity.ToTransferId);
            command.ExecuteNonQuery();
            connection.Close();

            return entity;
        }
    }
}
