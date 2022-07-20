using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;

namespace Revenge.Source.Main.Display
{
	public class TextDivider
	{
		Repeat repeat = new Repeat();
		public void CreateDivider(string ch, int times, bool donl) {
			if (donl) { Console.Write("\n\n"); }
			repeat.RepeatChar(ch, times);
			if (donl) { Console.Write("\n\n"); }
		}
	}
}