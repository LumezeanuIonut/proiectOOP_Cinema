namespace Test_WFA
{
    class Client : Utilizator
    {
        private string _cod;

        public string Cod
        {
            get
            {
                return _cod;
            }
            set
            {
                _cod = value;
            }
        }

        public Client(string Username,string Parola)
        {
            this.Tip = 'C';
            this.Username = Username;
            this.Parola = Parola;
        }
    }
}