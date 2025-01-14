using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
namespace Test_WFA
{
    public partial class FormClient : Form
    {
        
        public FormClient()
        {
            InitializeComponent();
        }

        private void addFilmButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            FormRezervare rezervare = new FormRezervare();
            rezervare.ShowDialog();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            FormModificareRez modRezervare = new FormModificareRez();
            modRezervare.ShowDialog();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
