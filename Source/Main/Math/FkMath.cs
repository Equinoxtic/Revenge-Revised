using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;

namespace Revenge.Source.Main.Math
{
	public class FkMath
	{
		Functions functions = new Functions();
		ErrorParser errorParser = new ErrorParser();

		public void Operation(string? type, int a, int b) {
			float a_fl = (float)a;
			float b_fl = (float)b;
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
						Console.Write(Divide(a, b));
						break;
				}
			} else {
				errorParser.ErrorSwitch("nul", "Operation");
			}
		}

		public int Add(int addend_a, int addend_b) {
			int sum = functions.IntAdd(
				addend_a, addend_b
			);
			return sum;
		}

		public int Subtract(int minuend, int subtrahend) {
			int difference = functions.IntSub(
				minuend, subtrahend
			);
			return difference;
		}

		public int Multiply(int multiplicand, int multiplier) {
			int product = functions.IntMult(
				multiplicand, multiplier
			);
			return product;
		}

		public float Divide(float dividend, float divisor) {
			float quotient = functions.IntDiv(
				dividend, divisor
			);
			return quotient;
		}
	}
}