using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    class Client
    {
        private string cnp;
        private string name;
        private string accountId;
        private string type;
        private string address;
        private string creationDate;

        public Client(string cnp, string name, string accountId, string type, string address, string creationDate)
        {
            Cnp = cnp;
            Name = name;
            AccountId = accountId;
            Type = type;
            Address = address;
            CreationDate = creationDate;
        }

        public string Cnp
        {
            get
            {
                return cnp;
            }

            set
            {
                cnp = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string CreationDate
        {
            get
            {
                return creationDate;
            }

            set
            {
                creationDate = value;
            }
        }
    }
}
