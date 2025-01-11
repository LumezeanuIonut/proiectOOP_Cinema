using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_WFA
{
    interface IRezervari
    {
        void Calculator_Castiguri_totale();
        void Afisare_rezervare();
        int Calculator_taxe();
        int Pret_Final();
    }
}
