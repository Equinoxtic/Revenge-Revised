using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Events;

namespace Revenge.RevLib
{
	public class Listener
	{
		public void ListenForCommandInput(string? _input) {
			RunCommand runCommand = new RunCommand();
			RunOption runOption = new RunOption();
			Revenge.Program program = new Revenge.Program();
			if (!String.IsNullOrEmpty(_input)) {
				if (_input.StartsWith("-") || _input.StartsWith("--")) {
					runCommand.RunCommandEvent(_input);
				} else { runOption.RunOptionEvent(Convert.ToInt32(_input)); }
			} else {
				program.ReInit(false);
			}
		}
	}
}