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
            
        }
    }
}
