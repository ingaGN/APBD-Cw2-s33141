namespace projekt;

public class Sprzet
{
    private int id = 0;
    
    public int Id { get ; }
    public string Nazwa { get; set; }
    public string Status { get; set; }

    public Sprzet(string nazwa)
    {
        Id = id++;
        Nazwa = nazwa;
        Status = "dostepny";
    }
}