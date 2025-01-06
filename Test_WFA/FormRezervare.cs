using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_WFA
{
    public partial class FormRezervare : Form
    {
        string rezervariPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\Rezervari.txt";
        public FormRezervare()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(rezervariPath);
            string durata = textDurata.Text;
            string selected = "";
            string dataIncep = dateTimePicker1.Text;
            string dataSfarsit= dateTimePicker2.Text;
            foreach (RadioButton rb in gb_TipBilet.Controls)
            {
                if (rb.Checked)
                {
                    selected = rb.Text;
                }
            }
            Rezervari rezervare1 = new Rezervari("Nasul",selected ,Convert.ToDateTime(dataIncep), Convert.ToDateTime(dataIncep),Convert.ToInt32(durata));
            //adaugarea rezervarii in fisierul text Rezervari.txt
            if(rezervare1.Calculator_taxe() != 0)
            {
                rezervare1.Afisare_rezervare();
                sw.Write(rezervare1.film + ',' + rezervare1.genFilm + ',' + Convert.ToString(rezervare1.inceputRezervare) + ',' + Convert.ToString(rezervare1.sfarsitRezervare) + ',' + Convert.ToString(rezervare1.durata));
                sw.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormRezervare_Load(object sender, EventArgs e)
        {

        }
    }
}
