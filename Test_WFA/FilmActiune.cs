using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WFA
{
    class FilmActiune : Film
    {
        public FilmActiune(string titlu, string regizor, string gen, int anLansare, int durata)
            : base(titlu, regizor, gen, anLansare, durata)
        {
        }

        public int GetNumarMaximZileRezervare() => 3;
    }
}