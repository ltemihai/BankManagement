using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class LoginUser : Entity
    {
        private string user;
        private string password;
        private string type;

        public LoginUser(string user, string password)
        {
            User = user;
            Password = password;
        }

        public LoginUser(string user, string password,string type)
        {
            User = user;
            Password = password;
            Type = type;
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
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
    }
}
