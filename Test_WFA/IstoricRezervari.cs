using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WFA
{
    class IstoricRezervari
    {
        public enum StareRezervare
        {
            Finalizata, Modificata, Anulata
        }
        private Film _filmRez;
        private DateTime _inceputRez;
        private DateTime _sfarsitRez;
        private StareRezervare _stareRez;

        public Film FilmRez
        {
            get
            {
                return _filmRez;
            }
            set
            {
                _filmRez = value;
            }
        }

        public DateTime InceputRez
        {
            get
            {
                return _inceputRez;
            }
            set
            {
                _inceputRez = value;
            }
        }

        public DateTime SfarsitRez
        {
            get
            {
                return _sfarsitRez;
            }
            set
            {
                _sfarsitRez = value;
            }
        }

        public StareRezervare StareRez
        {
            get
            {
                return _stareRez;
            }
            set
            {
                _stareRez = value;
            }
        }

        public IstoricRezervari(Film FilmRez, DateTime InceputRez, DateTime SfarsitRez, StareRezervare StareRez)
        {
            if (FilmRez == null)
                throw new ArgumentNullException("Filmul nu poate fi null");
            if (SfarsitRez == DateTime.MinValue)
                throw new ArgumentNullException("Data de sfarsit este invalida");
            if (InceputRez == DateTime.MinValue)
                throw new ArgumentNullException("Data de inceput este invalida");
            if (StareRez == null)
                throw new ArgumentNullException("Starea rezervarii este invalida");
            this.FilmRez = FilmRez;
            this.InceputRez = InceputRez;
            this.SfarsitRez = SfarsitRez;
            this.StareRez = StareRez;

        }
    }
}

