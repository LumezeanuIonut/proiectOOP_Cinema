using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WFA
{
    public partial class FormCautareFilmeClient : Form
    {
        private string rezervariPath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\Rezervari.txt";
        private string userpath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\User.txt";

        public FormCautareFilmeClient()
        {
            InitializeComponent();
        }

        private void FormCautareFilmeClient_Load(object sender, EventArgs e)
        {
            SetUpAutoComplete();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text.Trim();
            listBoxReservations.Items.Clear();
            bool ok = false;

            if (File.Exists(userpath))
            {
                var utilizatori = File.ReadLines(userpath);
                foreach (var line in utilizatori)
                {
                    var splitLine = line.Split(',');
                    if (splitLine.Length == 3 && splitLine[0] == user)
                    {
                        ok = true;
                        break;
                    }
                }
            }

            if (ok)
            {
                if (File.Exists(rezervariPath))
                {
                    var rezervari = File.ReadLines(rezervariPath);
                    foreach (var line in rezervari)
                    {
                        var splitLine = line.Split(',');
                        if (splitLine.Length >= 1 && splitLine[9] == user)
                        {
                            string reservation = $"Film: {splitLine[0]}, Tip: {splitLine[1]}, Zi: {splitLine[2]},  Inceput rezervare: {splitLine[3]}, An: {splitLine[4]}";
                            listBoxReservations.Items.Add(reservation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fișierul de rezervări nu există!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Utilizatorul nu a fost găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetUpAutoComplete()
        {
            if (File.Exists(userpath))
            {
                var lines = File.ReadLines(userpath).Select(line => line.Split(',')[0]).ToArray();

                AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                autoCompleteData.AddRange(lines);

                textBoxUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBoxUsername.AutoCompleteCustomSource = autoCompleteData;
            }
            else
            {
                MessageBox.Show("Fișierul de utilizatori nu există!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}