using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WFA
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void addFilmButton_Click(object sender, EventArgs e)
        {

        }

        private void totWinButton_Click(object sender, EventArgs e)
        {
            string pathSumaTotala = @"C:\Users\Andro\Source\Repos\proiectOOP_Cinema44\Test_WFA\TxtFiles\SumaVenituriTotale.txt";
            int sumaTotala = 0;

            try
            {
                if (File.Exists(pathSumaTotala))
                {
                    using (StreamReader sr = new StreamReader(pathSumaTotala))
                    {
                        string sumaTot = sr.ReadLine();
                        if (!string.IsNullOrEmpty(sumaTot) && int.TryParse(sumaTot, out int result))
                        {
                            sumaTotala = result;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Suma totală a rezervărilor: " + sumaTotala, "Total Venituri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
