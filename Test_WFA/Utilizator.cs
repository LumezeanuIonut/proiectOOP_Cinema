using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WFA
{
    class Utilizator
    {
        private char _tip;
        private string _username;
        private string _parola;

        public char Tip
        {
            get
            {
                return _tip;
            }
            set
            {
                _tip = value;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Parola
        {
            get
            {
                return _parola;
            }
            set
            {
                _parola = value;
            }
        }
        public string CreareUtilizator(char Tip,String Username) 
        {
        }
    }
}
