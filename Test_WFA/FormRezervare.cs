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
            List<Rezervari> rezervari = new List<Rezervari>();
            Rezervari rezervare1 = new Rezervari(selected ,Convert.ToDateTime(dataIncep), Convert.ToDateTime(dataIncep),Convert.ToInt32(durata));
            rezervare1.Afisare_rezervare();
            int index = 0;
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
