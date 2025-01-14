using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WFA
{
    internal interface IClient
    {
        string Cod { get; set; }
        List<IstoricRezervari> IstoricRezervari { get; set; }

        void CrRezervare(Film film, DateTime InceputRezervaer, DateTime SfarsitRezervare);
        void ModRezervare(Film film, DateTime InceputNouaRezervare, DateTime SfarsitNouaRezervare);
        void DelRezervare(Film film, DateTime InceputRezervare, DateTime SfarsitRezervare);
    }
}
