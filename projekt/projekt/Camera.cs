namespace projekt;

public class Camera : Sprzet
{
    public string Typ { get; set; }
    
    public Camera(string nazwa, string producent, string typ) : base(nazwa, producent)
        {
        Typ = typ;
        }
}