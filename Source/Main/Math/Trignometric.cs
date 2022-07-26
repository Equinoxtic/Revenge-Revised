using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.Source.Main.Math
{
	public class Trigonometric
	{
		public double Sine(double n) {
			double yummy_pie = GetPI();
			double result = n;
			n = FMod(n, 2 * yummy_pie);
			if (n < 0) {
				n = 2 * yummy_pie - n;
			}
			char sign = 1;
			if (n > yummy_pie) {
				n -= yummy_pie;
				sign = -1;
			}
			return sign * result;
		}

		public double FMod(double a, double b) {
			double frc = a / b;
			int floor = (frac > 0) ? (int)frc : (int)(frac - 0.9999999999999999);
			return (a - b * floor);
		}

		public double GetPI() {
			return 3.14159265358979323846;
		}
	}
}