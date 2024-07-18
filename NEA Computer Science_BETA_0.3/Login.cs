using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Computer_Science_BETA_0._3
{
    public class Login
    {
        public int userid { get; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public Login() { }

        public Login(string username, string password, string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;
        }
    }

}
