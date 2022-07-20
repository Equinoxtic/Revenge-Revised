using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;

namespace Revenge.Source.Main.Options
{
	public class Option
	{
		public void CreateOption(int num, string? name, bool newline = true, bool tabs = true, int tabs_amount = 6) {
			Repeat repeat = new Repeat();
			ErrorParser errorParser = new ErrorParser();
			if (!String.IsNullOrEmpty(name)) {
				string str = $"[{num}] {name}";
				Console.Write(
					((tabs) ? repeat.GetCharRepeat("\t", 6) : "") + str + ((newline) ? "\n" : "")
				);
			} else {
				errorParser.ErrorSwitch("nul", "Name");
			}
		}
	}
}