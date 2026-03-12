using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_1_sem2
{
    internal class Trojkat
    {
        private double bok = 0;
        private double pole = 0;
        private double wysokosc = 0;
        public Trojkat()
        {
            this.bok = 6;
        }
        public Trojkat(double bok)
        {
            this.bok = bok;
            this.wysokosc = 0.5 * this.bok * Math.Sqrt(3);
        }
        public void SetBok(double bok)
        {
            this.bok = bok;
            this.wysokosc = 0.5 * this.bok * Math.Sqrt(3);
        }
        public double GetBok()
        {
            
            return this.bok;
        }
        public double GetWysokosc()
        {
            return this.wysokosc;
        }
        public double GetPole()
        {
            this.pole =  ((this.bok * this.bok)*Math.Sqrt(3))/4;
            return this.pole;
        }
       
    }
}
