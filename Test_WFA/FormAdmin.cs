﻿using System;
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
        private string _username;
        private string _password;

        public FormAdmin(string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;
        }

        private void button6_Click(object sender, EventArgs e)
        {
             FormCautareFilmeClient formCautareFilmeClient = new FormCautareFilmeClient();
            formCautareFilmeClient.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void addFilmButton_Click(object sender, EventArgs e)
        {
            FormAdaugareFilm formAdaugareFilm = new FormAdaugareFilm();
            formAdaugareFilm.Show();
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

        private void adaugareAdmin_button_ClickC(object sender, EventArgs e)
        {
            FormCreareUtilizator creareAdmin = new FormCreareUtilizator("A");
            creareAdmin.Show();

        }

        private void clientWinButton_Click(object sender, EventArgs e)
        {
            FormCautareClient formCautareClient = new FormCautareClient();
            formCautareClient.Show();
        }

        private void remFilmButton_Click(object sender, EventArgs e)
        {
            FormStergereFilm formStergereFilm = new FormStergereFilm();
            formStergereFilm.Show();
        }

        private void remClientButton_Click(object sender, EventArgs e)
        {
           
        }

        private void TotRezHistButton_Click(object sender, EventArgs e)
        {
            FormCautareFilme_total_ formCautareFilmeTotal = new FormCautareFilme_total_();
            formCautareFilmeTotal.Show();
        }

        private void stergereClientButton_Click(object sender, EventArgs e)
        {
            FormRemoveClient remClient = new FormRemoveClient();
            remClient.Show();
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            FormModificareIntervalRezervare modintrez = new FormModificareIntervalRezervare();
            modintrez.Show();
        }
    }
}