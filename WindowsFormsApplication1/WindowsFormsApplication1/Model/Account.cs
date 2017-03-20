using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    class Account
    {
        private string idAccount;
        private float balance;
        private string idClient;

        public Account(string idAccount, float balance, string idClient)
        {
            IdAccount = idAccount;
            Balance = balance;
            IdClient = idClient;
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
    }
}
