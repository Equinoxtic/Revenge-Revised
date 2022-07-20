using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;
using Figgle;

namespace Revenge.Source.Main.Display
{
	public class Title
	{
		public void CreateTitle(string? title_name) {
			Repeat repeat = new Repeat();
			ErrorParser errorParser = new ErrorParser();
			if (!String.IsNullOrEmpty(title_name)) {
				Console.Write(FiggleFonts.SubZero.Render(title_name));
			} else {
				errorParser.ErrorSwitch("nul", "TITLE_NAME", "string", "ERROR");
			}
		}
	}
}