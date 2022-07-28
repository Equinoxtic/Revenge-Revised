using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.RevLib
{
	public class Throw
	{
		ErrorParser errorParser = new ErrorParser();

		public void CreateThrow(string? str, bool newline) {
			if (!String.IsNullOrEmpty(str)) {
				Console.Write(
					((newline) ? "\n" : "") + str + ((newline) ? "\n" : "")
				);
			} else {
				errorParser.ErrorSwitch("nul", "Message");
			}
		}
	}
}