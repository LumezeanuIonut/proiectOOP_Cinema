using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;

namespace Test_WFA
{
    public partial class FormAnulare : Form
    {
        string rezervariPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\Rezervari.txt";
        StringCollection rezervariCollection = new StringCollection();
        public FormAnulare()
        {
            InitializeComponent();
            SetUpAutoCompleterez(rezervariPath);
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(rezervariPath))
            {
                //aici se citesc toate rezervarile si se modifica cea selectata
                string rezervariText = File.ReadAllText(rezervariPath);
                
                if (rezervariText.Contains(anulari_tb.Text))
                {
                    rezervariText = rezervariText.Replace(anulari_tb.Text, string.Empty);
                    MessageBox.Show("Rezervarea a fost anulata cu succes!");
                }

                else
                    MessageBox.Show("Rezervarea nu a putut fi modificata anulata!");
                File.WriteAllText(rezervariPath, rezervariText);

            }
        }
    

        private void anulari_tb_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetUpAutoCompleterez(string rezervariPath)
        {

            var linesrez = File.ReadLines(rezervariPath);

            AutoCompleteStringCollection autoCompleteDatarez = new AutoCompleteStringCollection();
            autoCompleteDatarez.AddRange(linesrez.ToArray());

            anulari_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            anulari_tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            anulari_tb.AutoCompleteCustomSource = autoCompleteDatarez;

        }

        private void FormAnulare_Load(object sender, EventArgs e)
        {

        }
    }
}
