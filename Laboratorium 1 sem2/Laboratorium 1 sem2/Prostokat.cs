using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_1_sem2
{
    internal class Prostokat
    {
        private double dlugosc = 0;
        private double szerokosc = 0;
        
       public Prostokat(double dlugosc, double szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }
        private double powierzchnia()
        {
            return this.dlugosc * this.szerokosc;
        }
        private double obwod()
        {
            return 2 * (this.dlugosc + this.szerokosc);
        }   
        private double GetPowierzchnia()
        {
            return this.powierzchnia();
        }
        private double GetObwod()
        {
            return this.obwod();
        }
        public void prezentuj()
        {
            Console.WriteLine("Powierzchnia: " + this.GetPowierzchnia());
            Console.WriteLine("Obwod: " + this.GetObwod());
        }
        public static void Najwiekszy(Prostokat[] prostokaty)
        {
            Prostokat najwiekszy = prostokaty[0];
            foreach (Prostokat p in prostokaty)
            {
                if (p.powierzchnia() > najwiekszy.powierzchnia())
                {
                    najwiekszy = p;
                }
            }
            Console.WriteLine("#######################################################");
            Console.WriteLine("Najwiekszy prostokat:" + najwiekszy.GetPowierzchnia());
            Console.WriteLine("#######################################################");

        }
    }
}
