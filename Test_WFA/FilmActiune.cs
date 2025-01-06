namespace CinemaManagementSystem.Models
{
    public class FilmActiune : Film
    {
        public FilmActiune(string titlu, string regizor, string gen, int anLansare, int durata)
            : base(titlu, regizor, gen, anLansare, durata)
        {
        }

        public override int GetNumarMaximZileRezervare() => 3;
    }
}