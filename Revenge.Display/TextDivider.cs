using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.Display
{
	public class TextDivider
	{
		Repeat repeat = new Repeat();
		public void CreateDivider(string ch, int times, bool donl) {
			if (donl) { Console.Write("\n"); }
			repeat.RepeatChar(ch, times);
			if (donl) { Console.Write("\n"); }
		}
	}
}