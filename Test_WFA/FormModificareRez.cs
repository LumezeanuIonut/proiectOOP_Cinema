using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;
namespace Test_WFA
{
    public partial class FormModificareRez : Form
    {
        string rezervariPath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\Rezervari.txt";
        string filmPath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\Filme.txt";
        private string curentPath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\LogareCurenta.txt";

        StringCollection rezervariCollection = new StringCollection();
        public FormModificareRez()
        {
            InitializeComponent();
            SetUpAutoCompleterez(rezervariPath);
            SetUpAutoCompletefilm(filmPath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modRez_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetUpAutoCompleterez(string rezervariPath)
        {

            var linesrez = File.ReadLines(rezervariPath);

            AutoCompleteStringCollection autoCompleteDatarez = new AutoCompleteStringCollection();
            autoCompleteDatarez.AddRange(linesrez.ToArray());

            modRez_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            modRez_tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            modRez_tb.AutoCompleteCustomSource = autoCompleteDatarez;

        }

        private void SetUpAutoCompletefilm(string filmPath)
        {

            var linesfilm = File.ReadLines(filmPath);

            AutoCompleteStringCollection autoCompleteDatafilm = new AutoCompleteStringCollection();
            autoCompleteDatafilm.AddRange(linesfilm.ToArray());

            modif_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            modif_tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            modif_tb.AutoCompleteCustomSource = autoCompleteDatafilm;
        }
        private void FormModificareRez_Load(object sender, EventArgs e)
        {
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string titlu = "";
            string gen = "";
            string regizor = "";
            string anLansare = "";  
            string durata = "";

            var splitLine = modif_tb.Text.Split(',');
            if (splitLine.Length == 5)
            {
                titlu = splitLine[0];
                regizor = splitLine[1];
                gen = splitLine[2];
                anLansare = splitLine[3];
                durata = splitLine[4];
            }
            if (File.Exists(rezervariPath))
            {
                //aici se citesc toate rezervarile si se modifica cea selectata
                string rezervariText = File.ReadAllText(rezervariPath);
                //se inroduce intr-o variabila userul curent 

                string logCurent = File.ReadAllText(curentPath);
                string rezervareNoua = titlu + ',' + gen + ',' + modrez_dtp1.Text +',' + modrez_dtp2.Text + ',' + durata + ',' + logCurent;
                Rezervari rezervare1 = new Rezervari(titlu, gen, modrez_dtp1.Text, modrez_dtp2.Text, Convert.ToInt32(durata));
                if (rezervariText.Contains(modRez_tb.Text))
                {
                    rezervariText = rezervariText.Replace(modRez_tb.Text, rezervareNoua);
                    MessageBox.Show("Rezervarea a fost modificata cu succes!");
                }
                    
                else 
                    MessageBox.Show("Rezervarea nu a putut fi modificata!");
                File.WriteAllText(rezervariPath, rezervariText);

            }
        }
    }
}
