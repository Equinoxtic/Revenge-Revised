using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.Options
{
	public class Command
	{
		public void CreateCommand(string? term, string? name, string? description, bool newline = true, bool tabs = true, int tabs_amount = 6) {
			Repeat repeat = new Repeat();
			ErrorParser errorParser = new ErrorParser();
			if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(term) && !String.IsNullOrEmpty(description)) {
				string str = $"> [ -{term} ]\n\t\t\t\t\t\t- Name: {name}";
				Console.Write("\n" +
					((tabs) ? repeat.GetCharRepeat("\t", tabs_amount) : "") + 
					str + ((newline) ? "\n" : "") +
					((tabs) ? repeat.GetCharRepeat("\t", tabs_amount) : "") + 
					$"- Description: {description}" + ((newline) ? "\n\n" : "")
				);
			} else {
				errorParser.ErrorSwitch("nul", "Name");
			}
		}
	}
}