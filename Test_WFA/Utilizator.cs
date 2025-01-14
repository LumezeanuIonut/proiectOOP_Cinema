using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WFA
{
    public class Utilizator
    {
        private char _tip;         // 'A' = Admin, 'C' = Client
        private string _user;
        private string _parola;
        private string _username;

        public char Tip
        {
            get { return _tip; }
            set { _tip = value; }
        }

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        public string Parola
        {
            get { return _parola; }
            set { _parola = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public Utilizator(char tip, string user, string parola, string username)
        {
            _tip = tip;
            _username = username;
            _parola = parola;
            _username = username;
        }

        public string CreareUser()
            {

                string firstThreeLetters = _username.Length >= 3 ? _username.Substring(0, 3) : _username;
                return $"{_tip}{firstThreeLetters}";

            }
    }
}
