using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
   public class Login
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Login()
        { }
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Login:\n" +
                "Username: {0}\n" +
                "Password: {1}\n" +
                "\n", Username, Password);
        }
    }
}
