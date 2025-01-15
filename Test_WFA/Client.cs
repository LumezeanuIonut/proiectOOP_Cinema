using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_WFA
{
    class Client : Utilizator,IClient
    {
        private string _cod;
        private static int _nrCod = 1;
        private Dictionary<Film, (DateTime InceputRezervare, DateTime SfarsitRezervare)> _rezervari;
        private List<IstoricRezervari> _istoricRezervari;
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
        //getter pentru istoricul clientilor
        public List<IstoricRezervari> IstoricRezervare
        {
            get
            {
                return _istoricRezervari;
            }
        }

        public Client(string Tip,string User, string Parola ,string Username) : base(Tip , User, Parola, Username)
        {
            if (Username == null)
                throw new ArgumentNullException("Username-ul nu poate fi null");
            if (Parola == null)
                throw new ArgumentNullException("Parola nu poate fi null");
            this.Tip = Tip;
            this.Username = Username;
            this.Parola = Parola;
            this.User = User;
            Cod = "C" + Username[1].ToString().ToUpper() + _nrCod++;
            _rezervari = new Dictionary<Film, (DateTime InceputRezervare, DateTime SfarsitRezervare)>();
            _istoricRezervari = new List<IstoricRezervari>();
        }

        public void CrRezervare(Film film, DateTime InceputRezervare, DateTime SfarsitRezervare)
        {
            if (film == null)
                throw new ArgumentNullException("Filmul nu poate fi null");
            if (_rezervari.ContainsKey(film))
            {
                Console.WriteLine("Deja aveti rezervare la acest film");
                return;
            }
            if (InceputRezervare == DateTime.MinValue)
                throw new ArgumentNullException("Data de inceput este invalida");
            if (SfarsitRezervare == DateTime.MinValue)
                throw new ArgumentNullException("Data de sfarsit este invalida");
            if (InceputRezervare >= SfarsitRezervare)
            {
                throw new ArgumentException("Data de inceput trebuie sa fie neaparat mai mica decat data de sfarsit");
            }
            if (film.EsteDisponibil == false)
            {
                Console.WriteLine("Filmul este indisponibil");
                return;
            }
            else
            {
                _rezervari.Add(film, (InceputRezervare, SfarsitRezervare)); ;
                Console.WriteLine("Rezervare creata pentru filmul:" + film.Titlu + " din data de:" + InceputRezervare + " pana in data de:" + SfarsitRezervare);
                var Istoric = new IstoricRezervari(film, InceputRezervare, SfarsitRezervare, IstoricRezervari.StareRezervare.Finalizata);
                _istoricRezervari.Add(Istoric);
            }
        }

        public void ModRezervare(Film film, DateTime InceputNouaRezervare, DateTime SfarsitNouaRezervare)
        {
            if (film == null)
                throw new ArgumentNullException("Filmul nu poate fi null");
            if (_rezervari.ContainsKey(film))
            {
                Console.WriteLine("Nu aveti rezervare pentru acest film");
                return;
            }
            if (InceputNouaRezervare == DateTime.MinValue)
                throw new ArgumentNullException("Data de inceput este invalida");
            if (SfarsitNouaRezervare == DateTime.MinValue)
                throw new ArgumentNullException("Data de sfarsit este invalida");
            if (InceputNouaRezervare >= SfarsitNouaRezervare)
            {
                throw new ArgumentException("Data de inceput trebuie sa fie neaparat mai mica decat data de sfarsit");
            }
            _rezervari[film] = (InceputNouaRezervare, SfarsitNouaRezervare);
            Console.WriteLine("Rezervarea dumneavoastra la filmul:" + film.Titlu + " a fost modificata");
            var Istoric = new IstoricRezervari(film, InceputNouaRezervare, SfarsitNouaRezervare, IstoricRezervari.StareRezervare.Modificata);
            _istoricRezervari.Add(Istoric);
        }

        public void DelRezervare(Film film, DateTime InceputRezervare, DateTime SfarsitRezervare)
        {
            if (film == null)
                throw new ArgumentNullException("Filmul nu poate fi null");
            if (_rezervari.ContainsKey(film))
            {
                Console.WriteLine("Nu aveti rezervare pentru acest film");
                return;
            }
            _rezervari.Remove(film);
            Console.WriteLine("Rezervarea dumneavostra la filmul:" + film.Titlu + " a fost anulata");
            var Istoric = new IstoricRezervari(film, InceputRezervare, SfarsitRezervare, IstoricRezervari.StareRezervare.Anulata);
            _istoricRezervari.Add(Istoric);
        }
    }
}
