namespace projekt;

public class Employee : Uzytkownik
{
    
    public string Stanowisko { get; set; }
    public override int rentalLimit => 5;

    public Employee(string stanowisko, string imie, string nazwisko) : base(imie, nazwisko)
    {
        this.Stanowisko = stanowisko;
    }
}