
using System.Diagnostics.CodeAnalysis;

namespace Laboratorium_1_sem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new (5, 5);
            p1.wyswietl();
            p1.przesun(2, 3);
            p1.wyswietl();
            p1.cofnij();
            p1.wyswietl();

            Punkt p2 = new (10, 10);
            p1.odleglosc(p2);


            Trojkat t1 = new (3);
            double pole = t1.GetPole();
            Console.WriteLine("Bok: " + t1.GetBok());
            Console.WriteLine("Wysokosc: " + t1.GetWysokosc());
            Console.WriteLine("Pole: " + pole);

            Prostokat prostokat1 = new (4, 5);
            prostokat1.prezentuj();

            Prostokat[] prostokaty = new Prostokat[5];
            prostokaty[0] = new (2, 3);
            prostokaty[1] = new (4, 5);
            prostokaty[2] = new (10, 11);
            prostokaty[3] = new (6, 7);
            prostokaty[4] = new (8, 9);
            foreach (Prostokat p in prostokaty)
            {
                p.prezentuj();
            }
            Prostokat.Najwiekszy(prostokaty);

            Student s1 = new Student(23,"Jan","WSB");
            s1.DaneStudenta();
            s1.NowaSzkola("AGH");
            s1.DaneStudenta();
        }
       

    }
}