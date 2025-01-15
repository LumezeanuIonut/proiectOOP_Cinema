using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WFA
{
    public partial class FormStergereFilm : Form
    {
        private string filmPath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\Filme.txt";

        public FormStergereFilm()
        {
            InitializeComponent();
        }

        private void FormStergereFilm_Load(object sender, EventArgs e)
        {
            SetUpAutoComplete();
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            string filmToDelete = textBoxFilm.Text.Trim();

            if (File.Exists(filmPath))
            {
                var lines = File.ReadAllLines(filmPath).ToList();
                bool filmFound = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    var splitLine = lines[i].Split(',');
                    if (splitLine.Length > 0 && splitLine[0].Equals(filmToDelete, StringComparison.OrdinalIgnoreCase))
                    {
                        lines.RemoveAt(i);
                        filmFound = true;
                        break;
                    }
                }

                if (filmFound)
                {
                    File.WriteAllLines(filmPath, lines);
                    MessageBox.Show("Filmul a fost șters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Filmul nu a fost găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fișierul de filme nu există!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetUpAutoComplete()
        {
            if (File.Exists(filmPath))
            {
                var lines = File.ReadLines(filmPath).Select(line => line.Split(',')[0]).ToArray();

                AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                autoCompleteData.AddRange(lines);

                textBoxFilm.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxFilm.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBoxFilm.AutoCompleteCustomSource = autoCompleteData;
            }
            else
            {
                MessageBox.Show("Fișierul de filme nu există!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}