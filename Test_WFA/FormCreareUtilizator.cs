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
    public partial class FormCreareUtilizator : Form
    {
        string userPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\User.txt";
        public string tip { get; set; }
        public FormCreareUtilizator(string _tip)
        {
            tip=_tip;
            InitializeComponent();
        }

        private void FormCreareUtilizator_Load(object sender, EventArgs e)
        {

        }

        private void parola_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            Utilizator utilizator = new Utilizator(tip," ", parola_tb.Text, username_tb.Text);
            utilizator.User = utilizator.CreareUser();
            MessageBox.Show("Contul de client a fost creat cu succes! User id - ul  este: " + utilizator.User);
            using(StreamWriter sw = new StreamWriter(userPath,true))
            {
                sw.WriteLine($"{utilizator.User},{utilizator.Parola},{utilizator.Username}");
            }
        }
    }
}
