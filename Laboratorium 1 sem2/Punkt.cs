using System;
namespace Laboratorium_1_sem2
{
	public class Punkt
	{
		public Punkt()
		{
		}
		Punkt(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		przesun(int k, int z)
		{
			this.k = k;
			this.z = z;

			this.x += k;
			this.y += z;
		}
		cofnij()
		{
			this.x -= this.k;
			this.y -= this.z;
		}
		wyswietl()
		{
			Console.WriteLine("x: " + this.x + " y: " + this.y);
		}
	}
}