using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.Display
{
	public class TextDivider
	{
		public void CreateDivider(string ch, int times, bool donl) {
			Repeat repeat = new Repeat();
			if (donl) { Console.Write("\n"); }
			repeat.RepeatChar(ch, times);
			if (donl) { Console.Write("\n"); }
		}
	}
}