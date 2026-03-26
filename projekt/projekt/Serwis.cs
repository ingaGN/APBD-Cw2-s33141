using System.Security.AccessControl;

namespace projekt;

public class Serwis
{
    private List<Rental> rentals;
    
    public Serwis(List<Rental> rentals)
        {
        this.rentals = rentals;
        }

    public void wypozyczSprzet(Uzytkownik uzytkownik, Sprzet sprzet, DateTime dataWypozyczenia, DateTime dataZwrotuDue)
    {
        if(sprzet.Status != Status.dostepny)
            Console.WriteLine("sprzet nie dostepny");
        
        else if(ileWypozyczonych(uzytkownik)>= uzytkownik.rentalLimit)
            Console.WriteLine("maksymalna ilosc wypozyczonych sprzetow osiagnieta");

        else
        {
            var rental = new Rental(uzytkownik, sprzet, dataWypozyczenia, dataZwrotuDue);
                rentals.Add(rental);
                sprzet.Status = Status.wypozyczony;
        }
        
    }

    public void zwrocSprzet(Rental rental)
    {
        if (rental.CzyZwrocona)
            Console.WriteLine("sprzet jest juz zwrocony");
        else
        {
            rental.Zwrot(DateTime.Now, przynajKare(rental, DateTime.Now) );
            rental.Sprzet.Status = Status.dostepny;
        }
    }

    public int ileWypozyczonych(Uzytkownik uzytkownik)
    {
        int ile = 0;
        foreach (var w in rentals)
        {
            if(w.Uzytkownik.Id == uzytkownik.Id && !w.CzyZwrocona)
                ile++;
        }

        return ile;
    }

    public double przynajKare(Rental rental, DateTime zwrot)
    {
        if (zwrot <= rental.DataZwrotuDue)
            return 0;

        int lateDays = (zwrot - rental.DataZwrotuDue).Days;
        return lateDays * 5;
    }
}