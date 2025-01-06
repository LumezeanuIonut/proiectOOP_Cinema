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
    public partial class FormModificareRez : Form
    {
        string rezervariPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\Rezervari.txt";
        StringCollection rezervariCollection = new StringCollection();
        public FormModificareRez()
        {
            InitializeComponent();
            SetUpAutoComplete(rezervariPath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modRez_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetUpAutoComplete(string rezervariPath)
        {

            var lines = File.ReadLines(rezervariPath);

            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            autoCompleteData.AddRange(lines.ToArray());

            modRez_tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            modRez_tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            modRez_tb.AutoCompleteCustomSource = autoCompleteData;
        
        }
        private void FormModificareRez_Load(object sender, EventArgs e)
        {
            
        }
    }
}
