using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WFA
{
    public partial class FormAdaugareFilm : Form
    {
        private string filmPath = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\Filme.txt";

        public FormAdaugareFilm()
        {
            InitializeComponent();
        }

        private void FormAdaugareFilm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            string filmName = textBoxFilmName.Text.Trim();
            string director = textBoxDirector.Text.Trim();
            string Tip = textBoxGenre.Text.Trim();
            string year = textBoxYear.Text.Trim();
            string price = textBoxPrice.Text.Trim();

            if (string.IsNullOrEmpty(filmName) || string.IsNullOrEmpty(director) || string.IsNullOrEmpty(Tip) || string.IsNullOrEmpty(year) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newFilm = $"\"{filmName}\"/\"{director}\"/\"{Tip}\"/{year}/{price}";

            try
            {
                File.AppendAllText(filmPath, newFilm + Environment.NewLine);
                MessageBox.Show("Filmul a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            textBoxFilmName.Clear();
            textBoxDirector.Clear();
            textBoxGenre.Clear();
            textBoxYear.Clear();
            textBoxPrice.Clear();
        }
    }
}