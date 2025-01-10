using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WFA
{
    class FilmDrama : Film
    {
        public FilmDrama(string titlu, string regizor, string gen, int anLansare, int durata)
            : base(titlu, regizor, gen, anLansare, durata)
        {
        }
        public int GetNumarMaximZileRezervare() => 7;
    }
    // public class FilmDrama : Film.
}