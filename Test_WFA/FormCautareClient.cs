using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WFA
{
    public partial class FormCautareClient : Form
    {
        private string curentPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\LogareCurenta.txt";
        string userPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\User.txt";
        string rezervariPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\Rezervari.txt";
        string filmPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\Filme.txt";

        public FormCautareClient()
        {
            InitializeComponent();
        }

        private void FormCautareClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim(); 
            bool ok = false;

            if (File.Exists(userPath))
            {
                var utilizatori = File.ReadLines(userPath);
                foreach (var line in utilizatori)
                {
                    var splitLine = line.Split('/');
                    if (splitLine.Length == 3 && splitLine[0] == user)
                    {
                        ok = true;
                        break;
                    }
                }
            }

            if (ok)
            {
                
                int sumaTotalaClient = 0;

                if (File.Exists(rezervariPath))
                {
                    var rezervari = File.ReadLines(rezervariPath);
                    foreach (var line in rezervari)
                    {
                        var splitLine = line.Split('/');
                        if (splitLine.Length >= 1 && splitLine[9] == user)
                        {
                            if (int.TryParse(splitLine[8], out int pretFinal))
                            {
                                sumaTotalaClient += pretFinal;
                            }
                        }
                    }
                }

                MessageBox.Show(
                    $"Suma totală a rezervărilor pentru {user} este: {sumaTotalaClient} RON.",
                    "Total Venituri",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Utilizatorul nu a fost găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (File.Exists(curentPath))
            {
                File.WriteAllText(curentPath, user);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}