namespace projekt;

public class Raport
{
    public void Pokaz(List<Sprzet> sprzety, List<Rental> rentals)
    {
        int dostepne = 0;
        int wypozyczone = 0;
        int niedostepne = 0;
        int aktywne = 0;
        int przeterminowane = 0;

        foreach (var s in sprzety)
        {
            if (s.Status == Status.dostepny) dostepne++;
            else if (s.Status == Status.wypozyczony) wypozyczone++;
            else niedostepne++;
        }

        foreach (var r in rentals)
        {
            if (!r.CzyZwrocona) aktywne++;
            if (!r.CzyZwrocona && r.DataZwrotuDue < DateTime.Now) przeterminowane++;
        }

        Console.WriteLine("=== RAPORT ===");
        Console.WriteLine("Sprzety: " + sprzety.Count);
        Console.WriteLine("Dostepne: " + dostepne);
        Console.WriteLine("Wypozyczone: " + wypozyczone);
        Console.WriteLine("Niedostepne: " + niedostepne);
        Console.WriteLine("Aktywne wypozyczenia: " + aktywne);
        Console.WriteLine("Przeterminowane: " + przeterminowane);
    }
}