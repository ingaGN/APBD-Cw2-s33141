namespace projekt;

public class Laptop : Sprzet
{
    public string Model { get; set; }
    
    public Laptop(string name, string producent, string model) : base(name, producent)
    {
        Model = model;
    }
}