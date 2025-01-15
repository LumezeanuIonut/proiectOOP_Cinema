using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WFA
{
    public partial class FormCautareFilme_total_ : Form
    {
        private string rezervariPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\Rezervari.txt";

        public FormCautareFilme_total_()
        {
            InitializeComponent();
        }

        private void FormCautareFilme_total__Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxReservations.Items.Clear();

            if (File.Exists(rezervariPath))
            {
                var rezervari = File.ReadLines(rezervariPath);
                foreach (var line in rezervari)
                {
                    var splitLine = line.Split('/');
                    if (splitLine.Length >= 5)
                    {
                        string reservation = $"User: {splitLine[9]}, Film: {splitLine[0]}, Tip:{splitLine[1]}, Zi: {splitLine[2]}, Inceput: {splitLine[3]}, An: {splitLine[4]},Pret: {splitLine[8]} ";
                        listBoxReservations.Items.Add(reservation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fișierul de rezervări nu există!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}