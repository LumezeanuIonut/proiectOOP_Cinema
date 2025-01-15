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

            try
            {
                if (!File.Exists(userpath))
                {
                    MessageBox.Show("Fișierul de utilizatori nu există!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var utilizatori = File.ReadLines(userpath);
                bool userFound = utilizatori.Any(line => line.Split('/')[0] == user);

                if (!userFound)
                {
                    MessageBox.Show("Utilizatorul nu a fost găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!File.Exists(rezervariPath))
                {
                    MessageBox.Show("Fișierul de rezervări nu există!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var rezervari = File.ReadLines(rezervariPath);
                foreach (var line in rezervari)
                {
                    var splitLine = line.Split('/');
                    if (splitLine.Length >= 6 && splitLine[5] == user)
                    {
                        string reservation = $"Film: {splitLine[0]}, Tip: {splitLine[1]}, Inceput rezervare: {splitLine[2]}, An: {splitLine[3]}";
                        listBoxReservations.Items.Add(reservation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetUpAutoComplete()
        {
            if (File.Exists(userpath))
            {
                var lines = File.ReadLines(userpath).Select(line => line.Split('/')[0]).ToArray();

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