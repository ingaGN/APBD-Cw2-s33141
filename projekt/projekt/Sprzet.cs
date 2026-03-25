namespace projekt;

public class Sprzet
{
    private int id = 0;
    
    public int Id { get ; }
    public string Nazwa { get; set; }
    public string Producent { get; set; }
    public string Status { get; set; }

    public Sprzet(string nazwa, string producent)
    {
        Id = id++;
        Nazwa = nazwa;
        Producent = producent;
        Status = "dostepny";
    }
}