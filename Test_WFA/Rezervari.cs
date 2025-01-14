using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;


namespace Test_WFA
{
    class Rezervari:IRezervari
    {

        //dupa ce este facuta clasa Film trebuie modificat tipul variabilei
        public string titlu { get; set; }
        public string gen { get; set; }
        public string inceputRezervare { get; set; }
        public string sfarsitRezervare { get; set; }
        public int durata { get; set; }
        public Rezervari(string _titlu , string _gen, string _inceputRezervare, string _sfarsitRezervare,int _durata)
        {   
            titlu=_titlu;
            gen = _gen;
            inceputRezervare = _inceputRezervare;
            sfarsitRezervare = _sfarsitRezervare;
            durata = _durata;
        }
       public void Afisare_rezervare()
       {
            MessageBox.Show("Titlu" + titlu + "Genul filmului: " + gen + "\nData inceput: " + inceputRezervare + "\nData sfarsit: " + sfarsitRezervare + "\nDurata: " + durata + "\nTaxe: " + Calculator_taxe() + "\nPret final: " + Pret_Final());
            
        }
        public int Calculator_taxe()
        {
            var x = 0;
            if (gen == "Actiune")
                x = 20 * durata;


            if (gen == "Drama")
                x = 15 * durata;

            return x;
        }
        public int Pret_Final()
        {
            return 50 * durata + Calculator_taxe();
        }

        public void Calculator_Castiguri_totale()
        {
                string pathSumaTotala = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\SumaVenituriTotale.txt";
                int suma = Pret_Final();
                if (File.Exists(pathSumaTotala))
                {
                    int sumaTxt = Convert.ToInt32(File.ReadAllText(pathSumaTotala));
                    sumaTxt += suma;
                File.WriteAllText(pathSumaTotala, Convert.ToString(sumaTxt));

                }
        }
    }
}
