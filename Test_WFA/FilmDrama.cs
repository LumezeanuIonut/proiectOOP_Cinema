namespace CinemaManagementSystem.Models
{
    public class FilmDrama : Film
    {
        public FilmDrama(string titlu, string regizor, string gen, int anLansare, int durata)
            : base(titlu, regizor, gen, anLansare, durata)
        {
        }
        public override int GetNumarMaximZileRezervare() => 7;
    }
    // public class FilmDrama : Film
}