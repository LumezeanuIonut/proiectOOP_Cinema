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
    public partial class FormModificareIntervalRezervare : Form
    {
        string rezervariPath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\Rezervari.txt";
        StringCollection rezervariCollection = new StringCollection();
        public FormModificareIntervalRezervare()
        {
            InitializeComponent();
            SetUpAutoCompleterez(rezervariPath);
        }

        private void rezervare_tb_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetUpAutoCompleterez(string rezervariPath)
        {
            var linesrez = File.ReadLines(rezervariPath);

            AutoCompleteStringCollection autoCompleteDatarez = new AutoCompleteStringCollection();
            autoCompleteDatarez.AddRange(linesrez.ToArray());

            rezervare_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            rezervare_tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            rezervare_tb.AutoCompleteCustomSource = autoCompleteDatarez;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            var x = rezervare_tb.Text.Split('/');
            if (File.Exists(rezervariPath))
            {
                string rezervariText = File.ReadAllText(rezervariPath);
                var lines = rezervariText.Split('\n').ToList();
                bool found = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i] == rezervare_tb.Text)
                    {
                        var splitLine = lines[i].Split('/');
                        splitLine[4] = inceput_dtp.Text;
                        splitLine[5] = sf_dtp.Text;
                        lines[i] = string.Join("/", splitLine);
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    File.WriteAllText(rezervariPath, string.Join("\n", lines));
                    MessageBox.Show("Rezervare modificată cu succes!");
                }
                else
                {
                    MessageBox.Show("Rezervarea nu a fost găsită!");
                }
            }
            else
            {
                MessageBox.Show("Fisierul Rezervari.txt nu a putut fi deschis!");
            }
        }

        private void FormModificareIntervalRezervare_Load(object sender, EventArgs e)
        {

        }
    }
}