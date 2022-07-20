using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;

namespace Revenge.Source.Main.Events
{
	public class RunCommand
	{
		public void RunCommandEvent(string? command, bool returnToMain = true) {
			Program program = new Program();
			ErrorParser errorParser = new ErrorParser();
			ClientExit clientExit = new ClientExit();
			if (!String.IsNullOrEmpty(command)) {
				switch(command) {
					case "--exit": clientExit.InitExit(true); break;
				}
			} else {
				errorParser.ErrorSwitch("nul", "String");
			}
			if (returnToMain) {
				program.ReInit(false);
			}
		}
	}
}