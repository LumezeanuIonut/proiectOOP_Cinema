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
        public string film { get; set; }
        public string genFilm { get; set; }
        public DateTime inceputRezervare { get; set; }
        public DateTime sfarsitRezervare { get; set; }
        public int durata { get; set; }

        public Rezervari(string _film, string _genFilm, DateTime _inceputRezervare, DateTime _sfarsitRezervare, int _durata)
        {   
            film = _film;
            genFilm = _genFilm;
            inceputRezervare = _inceputRezervare;
            sfarsitRezervare = _sfarsitRezervare;
            durata = _durata;

        }
       public void Afisare_rezervare()
       {
            MessageBox.Show("Genul filmului: " + film + "\nData inceput: " + inceputRezervare + "\nData sfarsit: " + sfarsitRezervare + "\nDurata: " + durata + "\nTaxe: " + Calculator_taxe() + "\nPret final: " + Pret_Final());
            
        }
        public int Calculator_taxe()
        {
            var x = 0;

            // trebuie modificat dupa ce este creeata clasa de film 
            if (film == "Actiune" && durata > 3)
            {
                MessageBox.Show("Rezervarile pentru filmele de actiune se pot face pe maxim 3 zile!");
                Console.WriteLine("Durata rezervare depasita!");
            }
            else
                x = 20 * durata;


            if (film == "Drama" && durata > 7)
            {
                MessageBox.Show("Rezervarile pentru filmele de drama se pot face pe maxim 7 zile!");
                Console.WriteLine("Durata rezervare depasita!");
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
