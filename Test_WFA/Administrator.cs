using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WFA
{
    class Administrator : Utilizator
    {
        private List<Film> _film;
        public Administrator(string Tip, string User, string Parola, string Username) : base(Tip, User, Parola, Username)
        {
            if (Username == null)
                throw new ArgumentNullException("Username-ul nu poate fi null");
            if (Parola == null)
                throw new ArgumentNullException("Parola nu poate fi null");
            if (User == null)
                throw new ArgumentNullException("User-ul nu poate fi null");
            if (Tip == null)
                throw new ArgumentNullException("Tip-ul nu poate fi null");
            this.Tip = Tip;
            this.User = User;
            this.Username = Username;
            this.Parola = Parola;
            _film = new List<Film>();
        }
        public void AdaugareFilme(Film film)
        {
            if (film == null)
                throw new ArgumentNullException("Filmul nu poate fi null");
            if (_film.Contains(film))
            {
                Console.WriteLine("Filmul deja exista");
                return;
            }
            _film.Add(film);
            Console.WriteLine("Filmul:" + film.Titlu + " a fost adaugat");
        }

        public void StergereFilme(Film film)
        {
            if (film == null)
                throw new ArgumentNullException("Filmul nu poate fi null");
            if (!(_film.Contains(film)))
            {
                Console.WriteLine("Filmul nu exista");
                return;
            }
            _film.Remove(film);
            Console.WriteLine("Filmul:" + film.Titlu + " a fost sters");
        }

        public void IstoricClient(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException("Clientul nu poate fi null.");
            }

            var istoric = client.IstoricRezervare;

            if (istoric == null || istoric.Count == 0)
            {
                Console.WriteLine("Clientul nu are rezervari in istoric.");
                return;
            }

            Console.WriteLine("Istoricul clientului:" + client.Username + " este:");

            foreach (var rezervare in istoric)
            {
                Console.WriteLine(rezervare.FilmRez.Titlu + " " + rezervare.InceputRez + "-" + rezervare.SfarsitRez + " " + rezervare.StareRez);
            }
        }
    }
}

