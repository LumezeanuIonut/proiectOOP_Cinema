using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WFA
{
    class Rezervari:IRezervari
    {

        //dupa ce este facuta clasa Film trebuie modificat tipul variabilei
        private string film { get; set; }
        private DateTime inceputRezervare { get; set; }
        private DateTime sfarsitRezervare { get; set; }
        private int durata { get; set; }

        public Rezervari(string _film, DateTime _inceputRezervare, DateTime _sfarsitRezervare, int _durata)
        {   
            film = _film;
            inceputRezervare = _inceputRezervare;
            sfarsitRezervare = _sfarsitRezervare;
            durata = _durata;

        }
       public void Afisare_rezervare()
       {
            Console.WriteLine("Genul filmului: " + film);
            Console.WriteLine("Data inceput: " + inceputRezervare);
            Console.WriteLine("Data sfarsit: " + sfarsitRezervare);
            Console.WriteLine("Durata: " + durata);
            Console.WriteLine("Taxe: " + Calculator_taxe());
            Console.WriteLine("Pret final: " + Pret_Final());
        }
        public int Calculator_taxe()
        {
            var x = 0;

            // trebuie modificat dupa ce este creeata clasa de film 
            if (film == "Actiune" && durata > 3)
            {
                MessageBox.Show("Rezervarile pentru filmele de actiune se pot face pe maxim 3 zile!");
                throw new Exception("Durata rezervare depasita!");
            }
            else
                x = 20 * durata;


            if (film == "Drama" && durata > 7)
            {
                MessageBox.Show("Rezervarile pentru filmele de drama se pot face pe maxim 7 zile!");
                throw new Exception("Durata rezervare depasita!");
            }
            else x = 15 * durata;

            return x;
        }
        public int Pret_Final()
        {
            return 50 * durata + Calculator_taxe();
        }
    }
}
