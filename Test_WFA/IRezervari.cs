using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WFA
{
    interface IRezervari
    {
        void Adaugare_rezervare(List<Rezervari> rez);
        int Calculator_taxe();
        int Pret_Final();
    }
}
