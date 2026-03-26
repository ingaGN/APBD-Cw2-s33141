namespace projekt;

public class Program
{
    public static void Main(string[] args)
    {
        List<Sprzet> sprzety = new List<Sprzet>();
        List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();
        List<Rental> rentals = new List<Rental>();

        Serwis serwis = new Serwis(rentals);
        Raport raport = new Raport();

        var laptop = new Laptop("Dell", "Dell", "Latitude");
        var projektor = new Projektor("Epson", "Epson", 1080);
        var camera = new Camera("Canon", "Canon", "DSLR");

        sprzety.Add(laptop);
        sprzety.Add(projektor);
        sprzety.Add(camera);

        var student = new Student("PJATK", "Jan", "Kowalski");
        var employee = new Employee("Admin", "Anna", "Nowak");

        uzytkownicy.Add(student);
        uzytkownicy.Add(employee);

        serwis.wypozyczSprzet(student, laptop, DateTime.Now, DateTime.Now.AddDays(7));

        projektor.Status = Status.niedostepny;
        serwis.wypozyczSprzet(student, projektor, DateTime.Now, DateTime.Now.AddDays(3));

        serwis.wypozyczSprzet(student, camera, DateTime.Now, DateTime.Now.AddDays(2));

        var laptop2 = new Laptop("Lenovo", "Lenovo", "ThinkPad");
        sprzety.Add(laptop2);
        serwis.wypozyczSprzet(student, laptop2, DateTime.Now, DateTime.Now.AddDays(2));

        serwis.zwrocSprzet(rentals[0]);

        serwis.wypozyczSprzet(employee, laptop2, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-5));
        serwis.zwrocSprzet(rentals[rentals.Count - 1]);

        raport.Pokaz(sprzety, rentals);
    }
}