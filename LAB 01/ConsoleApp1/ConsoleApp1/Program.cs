using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


class ulamek //prywatne zmienne licznik i mianownik (typu całkowitego ze znakiem),
{
    private int licznik, mianownik;
    ulamek someObject = new ulamek();


    public ulamek() // konstruktor domyślny (bez argumentów),
    {

    }
    public ulamek(int a, int b) // konstruktor z dwoma argumentami,
    {
        mianownik = a;
        licznik = b;

    }
    public ulamek(ulamek licznik, ulamek mianownik) // konstruktor kopiujący (1 argument).
    {

    }
    public override string ToString() //Dodaj metodę ToString() i Przeładuj operatory + - * /.
    {
        return $"licznik:{this.licznik }.";
    }
    

    public interface icomparable // Zaimplementuj interfejsy IEquatable i IComparable (posortuj tablice ułamków, aby sprawdzić czy IComparable działa poprawnie).
    {
        int compareTo(object obj);

    }
    public interface icopmare<t>
    {
        int compareto(t other);
    }
    public int compareto(object obj)
    {
        return compareto((ulamek)obj);
    }
    public int compareto(ulamek other)
    {
        double d1 = (double)licznik / mianownik;
        double d2 = (double)other.licznik / other.mianownik;
        if (d1 == d2)
            return 0;
        return d1 < d2 ? -1 : 1;
    }

} 












