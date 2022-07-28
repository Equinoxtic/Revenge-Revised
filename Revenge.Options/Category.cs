using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;

namespace Revenge.Options
{
	public class Category
	{
		public void CreateCategory(string? name, bool uppercase = true, bool newline = true, bool tabs = true, int tabs_amount = 6) {
			Repeat repeat = new Repeat();
			ErrorParser errorParser = new ErrorParser();
			if (!String.IsNullOrEmpty(name)) {
				Console.Write(
					((tabs) ? repeat.GetCharRepeat("\t", 6) : "") + ((uppercase) ? name.ToUpper() : name) + ((newline) ? "\n" : "")
				);
			} else {
				errorParser.ErrorSwitch("nul", "Name");
			}
		}
	}
}