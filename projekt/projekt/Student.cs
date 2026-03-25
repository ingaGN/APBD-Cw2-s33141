namespace projekt;

public class Student : Uzytkownik
{
    public string uczelnia { get; set; }
    public override int rentalLimit => 2;

    public Student(string uczelnia, string imie, string nazwisko) : base(imie, nazwisko)
    {
        this.uczelnia = uczelnia;
    }
}