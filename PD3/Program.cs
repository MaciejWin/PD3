using System;

class Pracownik
{
    private decimal wynagrodzenie;
    protected string imie;
    internal string dzial;

    public Pracownik(string imie, string dzial, decimal wynagrodzenie)
    {
        this.imie = imie;
        this.dzial = dzial;
        this.wynagrodzenie = wynagrodzenie;
    }

    public void PokazDane()
    {
        Console.WriteLine($"Pracownik: {imie}, Dział: {dzial}, Wynagrodzenie: {wynagrodzenie} zł");
    }

    public void ZmienWynagrodzenie(decimal kwota)
    {
        if (kwota > 0)
        {
            wynagrodzenie = kwota;
            Console.WriteLine($"Zaktualizowano wynagrodzenie na: {wynagrodzenie} zł");
        }
        else
        {
            Console.WriteLine("Błąd: Wynagrodzenie musi być większe od zera!");
        }
    }
}

class Kierownik : Pracownik
{
    public Kierownik(string imie, string dzial, decimal wynagrodzenie)
        : base(imie, dzial, wynagrodzenie)
    {
    }

    public void PrzedstawSie()
    {
        Console.WriteLine($"Imię kierownika: {imie}");
    }
}

class Program
{
    static void Main()
    {
        Pracownik pracownik = new Pracownik("Jan Kowalski", "IT", 5000m);
        Kierownik kierownik = new Kierownik("Anna Nowak", "Zarządzanie", 9000m);

        pracownik.PokazDane();
        kierownik.PokazDane();
        kierownik.PrzedstawSie();

        pracownik.ZmienWynagrodzenie(5500m);
        //pracownik.wynagrodzenie = 5000m
        //Nie można zmienić bezpośrednio wynagrodzenie bo jest on zapisane jako "private" co uniemożliwia dostęp do niego po za klasą do której jest przypisany
        Console.WriteLine($"Dział: {pracownik.dzial}");
        //dzial można wyświetlić bo jest on zapisany jako "internal" co umożliwia korzystanie z niego całego zestawu (w tym przypadku klasy Pracownik i Program)
    }
}