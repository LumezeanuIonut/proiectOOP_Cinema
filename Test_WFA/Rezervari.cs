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
    class Rezervari : IRezervari
    {

        //dupa ce este facuta clasa Film trebuie modificat tipul variabilei
        private const int TAX_ACTIUNE = 20;
        private const int TAX_DRAMA = 15;
        private const int PRET_BAZA = 50;

        public string titlu { get; set; }
        public string gen { get; set; }
        public string inceputRezervare { get; set; }
        public string sfarsitRezervare { get; set; }
        public int durata { get; set; }
        private Utilizator _utilizator;
        private int _pretInitial;
        private int _pretFinal;

        public Utilizator Utilizator
        {
            get
            {
                return _utilizator;
            }
            set
            {
                _utilizator = value;
            }
        }

        public int PretInitial
        {
            get { return _pretInitial; }
            set { _pretInitial = value; }
        }

        public int PretFinal
        {
            get { return _pretFinal;}
            set { _pretFinal = value; }
        }
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
            MessageBox.Show("Titlu" + titlu + "Genul filmului: " + gen + "\nData inceput: " + inceputRezervare +
                            "\nData sfarsit: " + sfarsitRezervare + "\nDurata: " + durata + "\nTaxe: " +
                            Calculator_taxe() + "\nPret final: " + Pret_Final());

        }

        public int Calculator_taxe()
        {
            var x = 0;
            if (gen == "Actiune")
                PretInitial = TAX_ACTIUNE * durata;


            if (gen == "Drama")
                PretInitial = TAX_DRAMA * durata;

            return PretInitial;
        }

        public int Pret_Final()
        {
            PretFinal =PRET_BAZA * durata + Calculator_taxe();
            return PretFinal;
        }
        //Calculam suma totala a rezervarilor
        public void Calculator_Castiguri_totale()
        {

            string pathSumaTotala = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\SumaVenituriTotale.txt";
            int suma = Pret_Final();
            int sumaTxt = 0;

            try
            {
                if (File.Exists(pathSumaTotala))
                {
                    using (StreamReader sr = new StreamReader(pathSumaTotala))
                    {
                        string sumaTot = sr.ReadLine();
                        if (!string.IsNullOrEmpty(sumaTot) && int.TryParse(sumaTot, out int result))
                        {
                            sumaTxt = result;
                        }
                    }
                }
                else
                {
                    File.Create(pathSumaTotala).Close();
                }

                sumaTxt += suma;

                // Debugging information
                MessageBox.Show("Suma initiala: " + sumaTxt + "\nSuma adaugata: " + suma + "\nSuma finala: " + sumaTxt);

                using (StreamWriter sw = new StreamWriter(pathSumaTotala))
                {
                    sw.WriteLine(sumaTxt.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
