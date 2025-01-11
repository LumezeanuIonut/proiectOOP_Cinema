using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_WFA
{
    public partial class FormRezervare : Form
    {
        private string curentPath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\LogareCurenta.txt";
        string rezervariPath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\Rezervari.txt";
        string filmPath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\Filme.txt";

        public FormRezervare()
        {
            InitializeComponent();
            SetUpAutoComplete(filmPath);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(rezervariPath, true)) 
            {
                if (File.Exists(filmPath))
                {
                    string titlu = "";
                    string gen = "";
                    string regizor = "";
                    string anLansare = "";
                    string durata = "";
                    var splitLine = film_tb.Text.Split(',');
                    if (splitLine.Length == 5)
                    {
                        titlu = splitLine[0];
                        gen = splitLine[1];
                        regizor = splitLine[2];
                        anLansare = splitLine[3];
                        durata = splitLine[4];
                    }

                    string dataIncep = dateTimePicker1.Text;
                    string dataSfarsit = dateTimePicker2.Text;
                    Film film = new Film(titlu, gen, regizor, Convert.ToInt32(anLansare), Convert.ToInt32(durata));
                    Rezervari rezervare1 = new Rezervari(film.Titlu, film.Gen, Convert.ToDateTime(dataIncep), Convert.ToDateTime(dataIncep), film.Durata);

                        string logCurent = File.ReadAllText(curentPath);
                    rezervare1.Afisare_rezervare();
                        sw.WriteLine(film.Titlu + ',' + film.Gen + ',' + Convert.ToString(rezervare1.inceputRezervare) + ',' + Convert.ToString(rezervare1.sfarsitRezervare) + ',' + Convert.ToString(film.Durata) + ',' + logCurent);
                    
                }
            }
        }

        private void SetUpAutoComplete(string filmPath)
        {
            var lines = File.ReadLines(filmPath);

            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            autoCompleteData.AddRange(lines.ToArray());

            film_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            film_tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            film_tb.AutoCompleteCustomSource = autoCompleteData;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormRezervare_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gb_DataRez_Enter(object sender, EventArgs e)
        {

        }
    }
}