using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class Transaction : Entity
    {
        private string transactionId;
        private float amount;
        private string date;
        private string accountId;
        private string toTransferId;

        public Transaction(string transactionId, float amount, string date, string accountId, string toTransferId)
        {
            TransactionId = transactionId;
            Amount = amount;
            Date = date;
            AccountId = accountId;
            ToTransferId = toTransferId;
        }

        public Transaction(float amount, string date, string accountId, string toTransferId)
        {
            Amount = amount;
            Date = date;
            AccountId = accountId;
            ToTransferId = toTransferId;
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

        public string ToTransferId
        {
            get
            {
                return toTransferId;
            }

            set
            {
                toTransferId = value;
            }
        }
    }
}
