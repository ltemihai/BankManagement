using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class Transaction
    {
        private string transactionId;
        private float amount;
        private string date;
        private string accountId;

        public Transaction(string transactionId, float amount, string date, string accountId)
        {
            TransactionId = transactionId;
            Amount = amount;
            Date = date;
            AccountId = accountId;
        }

        public string TransactionId
        {
            get
            {
                return transactionId;
            }

            set
            {
                transactionId = value;
            }
        }

        public float Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string AccountId
        {
            get
            {
                return accountId;
            }

            set
            {
                accountId = value;
            }
        }
    }
}
