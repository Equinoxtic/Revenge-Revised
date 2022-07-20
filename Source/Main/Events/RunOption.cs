using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;

namespace Revenge.Source.Main.Events
{
	public class RunOption
	{
		public void RunOptionEvent(int option, bool returnToMain = true) {
			Program program = new Program();
			ErrorParser errorParser = new ErrorParser();
			if (option != 0) {
				switch(option) {
					case 1: Console.Write("\njriviwjiiorg\n"); break;
				}
			} else {
				errorParser.ErrorSwitch("inv", "Number", Convert.ToString(option));
			}
			if (returnToMain) {
				program.ReInit(false);
			}
		}
	}
}