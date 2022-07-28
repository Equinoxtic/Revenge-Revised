using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.Events
{
	public class RunCommand
	{
		public void RunCommandEvent(string? command, bool returnToMain = true) {
			Program program = new Program();
			ErrorParser errorParser = new ErrorParser();
			ClientExit clientExit = new ClientExit();
			OpenLink openLink = new OpenLink();
			if (!String.IsNullOrEmpty(command)) {
				switch(command) {
					case "--exit": clientExit.InitExit(true); break;
					case "--getgit": openLink.InitLink("https://github.com/Equinoxtic/Revenge-Revised"); break;
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