using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.MathLib
{
	public class FkMath
	{
		Functions functions = new Functions();
		Trigonometric trigonometric = new Trigonometric();
		Constants constants = new Constants();
		ErrorParser errorParser = new ErrorParser();

		public void Operation(string? type, int a = 0, int b = 0) {
			float a_fl = (float)a;
			float b_fl = (float)b;
			double a_db = (double)a;
			if (!String.IsNullOrEmpty(type)) {
				switch(type) {
					case "+" or "#add" or "Add":
						Console.Write(Add(a, b));
						break;
					case "-" or "#sub" or "Subtract":
						Console.Write(Subtract(a, b));
						break;
					case "*" or "#mult" or "Multiply":
						Console.Write(Multiply(a, b));
						break;
					case "/" or"#div" or "Divide":
						Console.Write(Divide(a_fl, b_fl));
						break;
					case "sin" or "sine" or "Sine":
						Console.Write(Sine(a_db));
						break;
					case "cos" or "cosine" or "Cosine":
						Console.Write(Cosine(a_db));
						break;
					case "tan" or "tangent" or "Tangent":
						Console.Write(Tangent(a_db));
						break;
					case "pi" or "PI":
						Console.Write(constants.PI());
						break;
					case "e" or "E":
						Console.Write(constants.E());
						break;
				}
			} else {
				errorParser.ErrorSwitch("nul", "Operation");
			}
		}

		int Add(int addend_a, int addend_b) {
			int sum = functions.IntAdd(
				addend_a, addend_b
			);
			return sum;
		}

		int Subtract(int minuend, int subtrahend) {
			int difference = functions.IntSub(
				minuend, subtrahend
			);
			return difference;
		}

		int Multiply(int multiplicand, int multiplier) {
			int product = functions.IntMult(
				multiplicand, multiplier
			);
			return product;
		}

		float Divide(float dividend, float divisor) {
			float quotient = functions.IntDiv(
				dividend, divisor
			);
			return quotient;
		}

		double Sine(double a) {
			double n_sin = trigonometric.Sin(a);
			return (n_sin > 0) ? n_sin : 0;
		}

		double Cosine(double b) {
			double n_cos = trigonometric.Cos(b);
			return (n_cos > 0) ? n_cos : 0;
		}

		double Tangent(double c) {
			double n_tan = trigonometric.Tan(c);
			return (n_tan > 0) ? n_tan : 0;
		}
	}
}