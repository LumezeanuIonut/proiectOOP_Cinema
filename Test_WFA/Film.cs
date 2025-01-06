using System;

namespace CinemaManagementSystem.Models
{
    public abstract class Film
    {
        // Câmpuri private
        private string _titlu;
        private string _regizor;
        private string _gen;
        private int _anLansare;
        private int _durata;
        private bool _esteDisponibil;

        // Proprietăți cu get public și set privat (read-only din exterior)
        public string Titlu => _titlu;
        public string Regizor => _regizor;
        public string Gen => _gen;
        public int AnLansare => _anLansare;
        public int Durata => _durata; // minute

        public bool EsteDisponibil
        {
            get => _esteDisponibil;
            set => _esteDisponibil = value;
        }


        protected Film(string titlu, string regizor, string gen, int anLansare, int durata)
        {
            if (string.IsNullOrWhiteSpace(titlu))
                throw new ArgumentException("Titlul nu poate fi gol.");

            if (string.IsNullOrWhiteSpace(regizor))
                throw new ArgumentException("Regizorul nu poate fi gol.");

            if (string.IsNullOrWhiteSpace(gen))
                throw new ArgumentException("Genul nu poate fi gol.");

            if (anLansare <= 0)
                throw new ArgumentException("Anul lansării trebuie să fie un număr pozitiv.");

            if (durata <= 0)
                throw new ArgumentException("Durata în minute trebuie să fie un număr pozitiv.");

            _titlu = titlu;
            _regizor = regizor;
            _gen = gen;
            _anLansare = anLansare;
            _durata = durata;

            // Implicit, considerăm filmul disponibil
            _esteDisponibil = true;
        }

        public abstract int GetNumarMaximZileRezervare();
    }
}