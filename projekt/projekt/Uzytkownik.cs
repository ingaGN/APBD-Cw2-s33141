namespace projekt;

public abstract class Uzytkownik
{
    private static int id = 0;
    public int Id { get; }
    
    public String Imie { get; set; } 
    public String Nazwisko { get; set; }
    public String DataUrodzenia { get; set; }
    public String Adres { get; set; }
    public String Telefon { get; set; }
    public String Email { get; set; }
    
    public abstract int rentalLimit { get; }

    public Uzytkownik(string imie, string nazwisko)
    {
        Id = id++;
        Imie = imie;
        Nazwisko = nazwisko;
    }
}