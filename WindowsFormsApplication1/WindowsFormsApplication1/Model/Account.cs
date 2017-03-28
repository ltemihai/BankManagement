using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class Account : Entity
    {
        private string idAccount;
        private float balance;
        private string idClient;
        private List<Transaction> transactions;

        public Account(string idAccount, float balance, string idClient)
        {
            IdAccount = idAccount;
            Balance = balance;
            IdClient = idClient;
        }

        public Account(string idAccount)
        {
            IdAccount = idAccount;
        }

        public string IdAccount
        {
            get
            {
                return idAccount;
            }

            set
            {
                idAccount = value;
            }
        }

        public float Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public string IdClient
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }

        public List<Transaction> Transactions
        {
            get
            {
                return transactions;
            }

            set
            {
                transactions = value;
            }
        }
    }
}
