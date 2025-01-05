using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WFA
{
    public partial class FormRezervare : Form
    {
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
            /*string nume = NumeText.Text;
            string prenume = PrenumeText.Text;
            string selected="";
            foreach(RadioButton rb in gb_TipBilet.Controls)
            {
                if(rb.Checked)
                {
                    selected = rb.Text;
                }
            }
            Console.WriteLine("Nume: " + nume);
            Console.WriteLine("Prenume: " + prenume);
            Console.WriteLine("Tip bilet: " + selected);*/
            Rezervari rezervareTest = new Rezervari("client", "Actiune", new DateTime(2025, 05, 02), new DateTime(2025, 05, 03), 7);
            List<Rezervari> rezervari = new List<Rezervari>();
            int index = 0;
            rezervareTest.Afisare_rezervare();
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
