using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts
{
    internal class User
    {
        public int ID { get; set; }
        private string Login, Pass, Email;

        public string login {
            get { return Login; }
            set { Login = value; }
        }
        public string pass {
            get { return Pass; }
            set { Pass = value; }
        }
        public string email { 
            get { return Email; }
            set { Email = value; }
        }

        public User() { }

        public User(string login, string pass, string email) { 
            this.Login = login;
            this.Pass = pass;
            this.Email = email;
        }

        

    }
}
