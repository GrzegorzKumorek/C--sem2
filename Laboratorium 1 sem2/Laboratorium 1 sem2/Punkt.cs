using System;
namespace Laboratorium_1_sem2
{
	public class Punkt
	{
        private int x;
        private int y;
        private int k;
        private int z;
        public Punkt()
		{
			this.x = 0;
			this.y = 0;
			this.k = 0;
			this.z = 0;
        }
		public Punkt(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public void przesun(int k, int z)
		{
			this.k = k;
			this.z = z;

			this.x += k;
			this.y += z;
		}
		public void cofnij()
		{
			this.x -= this.k;
			this.y -= this.z;
		}
		public void wyswietl()
		{
			Console.WriteLine("x: " + this.x + " y: " + this.y);
		}
        public void odleglosc(Punkt p)
        {
            int dx = this.x - p.x;
            int dy = this.y - p.y;

            Console.WriteLine("odleglosc miedzy punktami: " + Math.Sqrt(dx * dx + dy * dy));

        }
    }
}