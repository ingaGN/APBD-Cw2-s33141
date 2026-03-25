namespace projekt;

public class Projektor : Sprzet
{
    public int Rozdzielczosc { get; set; }

    public Projektor(string nazwa, string producent, int rozdzielczosc) : base(nazwa, producent) 
    {
        Rozdzielczosc = rozdzielczosc;
    }
}