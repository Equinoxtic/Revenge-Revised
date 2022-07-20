using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;

namespace Revenge.Source.Main.Options
{
	public class Command
	{
		public void CreateCommand(string? term, string? name, bool newline = true, bool tabs = true, int tabs_amount = 6) {
			Repeat repeat = new Repeat();
			ErrorParser errorParser = new ErrorParser();
			if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(term)) {
				string str = $"[{term}] {name}";
				Console.Write(
					((tabs) ? repeat.GetCharRepeat("\t", tabs_amount) : "") + str + ((newline) ? "\n" : "")
				);
			} else {
				errorParser.ErrorSwitch("nul", "Name");
			}
		}
	}
}