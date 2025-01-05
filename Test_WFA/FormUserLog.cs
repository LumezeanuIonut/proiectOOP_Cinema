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
using static System.Windows.Forms.LinkLabel;
namespace Test_WFA
{
    public partial class FormUserLog : Form
    {

        string userPath = @"C:\Users\40767\Desktop\an2\poo\OOP_Project_Cinema\Test_WFA\TxtFiles\User.txt";
        public FormUserLog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string user = userTB.Text;
            string parola = parolaTB.Text;
            string User = "", Password = "", UserName="";
            bool ok = false;
            //Cautare utilizator in fisier text User.txt
            if(File.Exists(userPath))
            {
                var utilizatori = File.ReadLines(userPath);
                foreach (var line in utilizatori)
                {
                    var splitLine = line.Split(',');
                    if (splitLine.Length == 3)
                    {
                        User = splitLine[0];
                        Password = splitLine[1];
                        UserName = splitLine[2];
                        if (User == user && Password == parola)
                        {
                            ok = true;
                            break;
                        }
                    }
                }

            }

            if(ok)
            {
                Console.WriteLine("Bine ati venit " + UserName);
                this.Hide();
                //selectare tip de meniu
                if (User[0] == 'A')
                {
                    FormAdmin adminMenu= new FormAdmin();
                    adminMenu.Show();

                }
                else
                {
                    FormClient clientMenu = new FormClient();
                    clientMenu.Show();

                }
                
            }
            else
            {
                MessageBox.Show("Parola sau user gresit!");
            }
        }
    }
}
