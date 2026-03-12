using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium_1_sem2
{
    internal class Student
    {

        private int wiek = 0;
        private string imie = "";
        private string szkola = "";
        public Student(int wiek, string imie, string szkola)
        {
            this.wiek = wiek;
            this.imie = imie;
            this.szkola = szkola;
        }
       public int NowaSzkola(string szkola)
        {
            this.szkola= szkola; 
            return 0;
        }
        public void DaneStudenta()
        {
            Console.WriteLine("Imie: " + this.imie);
            Console.WriteLine("Wiek: " + this.wiek);
            Console.WriteLine("Szkola: " + this.szkola);
        }
    }
}
