namespace projekt;

public class Uzytkownik
{
    public String Imie { get; set; }
    public String Nazwisko { get; set; }
    public String DataUrodzenia { get; set; }
    public String Adres { get; set; }
    public String Telefon { get; set; }
    public String Email { get; set; }

    public Uzytkownik(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }
}