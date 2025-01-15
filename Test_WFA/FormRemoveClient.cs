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
    public partial class FormRemoveClient : Form
    {
        string userPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\User.txt";
        string rezervariPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\Rezervari.txt";
        public FormRemoveClient()
        {
            InitializeComponent();
            SetUpAutoCompleteUser(userPath,'C');
        }

        private void id_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRemoveClient_Load(object sender, EventArgs e)
        {

        }
        
        private void SetUpAutoCompleteUser(string userPath, char startLetter)
        {
            var linesrez = File.ReadLines(userPath)
                               .Where(line => line.StartsWith(startLetter.ToString(), StringComparison.OrdinalIgnoreCase));

            AutoCompleteStringCollection autoCompleteDatarez = new AutoCompleteStringCollection();
            autoCompleteDatarez.AddRange(linesrez.ToArray());

            id_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            id_tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            id_tb.AutoCompleteCustomSource = autoCompleteDatarez;

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            string userText = "";
            string userTB = id_tb.Text;
            //separam continutul tb ului pentru a extrage doar user id-ul pentru a sterge rezervarile
            var x = userTB.Split('/');
            if(File.Exists(userPath))
            {
               userText = File.ReadAllText(userPath);
            }
            else
            {
                MessageBox.Show("Fisierul User.txt nu exista!");
            }
            if (userText.Contains(id_tb.Text))
            {
                string[] lines = File.ReadAllLines(userPath);
                using (StreamWriter sw = new StreamWriter(userPath))
                {
                    foreach (string line in lines)
                    {
                        if (!line.Contains(id_tb.Text))
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                string[] linesrez = File.ReadAllLines(rezervariPath);
                using (StreamWriter sw = new StreamWriter(rezervariPath))
                {
                    foreach (string line in linesrez)
                    {
                        if (!line.Contains(x[0]))
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                MessageBox.Show("Utilizatorul a fost sters cu succes!");
            }
            else
            {
                MessageBox.Show("Utilizatorul nu exista!");
            }
        }
    }
}
