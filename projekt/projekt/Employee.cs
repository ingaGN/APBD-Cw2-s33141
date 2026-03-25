namespace projekt;

public class Employee : Uzytkownik
{
    public string Stanowisko { get; set; }

    public Employee(string stanowisko, string imie, string nazwisko) : base(imie, nazwisko)
    {
        this.Stanowisko = stanowisko;
    }
}