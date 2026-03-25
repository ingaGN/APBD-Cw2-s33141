namespace projekt;

public class Student : Uzytkownik
{
    public string uczelnia { get; set; }

    public Student(string uczelnia, string imie, string nazwisko) : base(imie, nazwisko)
    {
        this.uczelnia = uczelnia;
    }
}