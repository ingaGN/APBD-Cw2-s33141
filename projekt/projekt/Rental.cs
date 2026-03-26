namespace projekt;

public class Rental
{
    public Uzytkownik Uzytkownik { get;}
    public Sprzet Sprzet { get;}
    
    public DateTime DataWypozyczenia { get; }
    public DateTime DataZwrotuDue { get; }
    public DateTime? DataZwrotu { get; set; }
    
    public double Kara { get; set; }
    
    public bool CzyZwrocona => DataZwrotu.HasValue;
    public bool CzyZwroconaWTerminie => DataZwrotu.HasValue && DataZwrotu <= DataZwrotuDue ;

    public Rental(Uzytkownik uzytkownik, Sprzet sprzet, DateTime dataWypozyczenia, DateTime dataZwrotuDue)
    {
        this.Uzytkownik = uzytkownik;
        this.Sprzet = sprzet;
        this.DataWypozyczenia = dataWypozyczenia;
        this.DataZwrotuDue = dataZwrotuDue;
    }
    
    
    
}