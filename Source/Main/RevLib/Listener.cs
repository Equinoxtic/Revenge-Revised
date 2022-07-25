using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.Events;

namespace Revenge.Source.Main.RevLib
{
	public class InputCommand
	{
		public void ListenForCommandInput(string? _input) {
			RunCommand runCommand = new RunCommand();
			RunOption runOption = new RunOption();
			Revenge.Program = new Revenge.Program();
			if (!String.IsNullOrEmpty(_input)) {
				if (_input.StartsWith("-") || _input.StartsWith("--")) {
					runCommand.RunCommandEvent(_input);
				} else { runOption.RunOptionEvent(Convert.ToInt32(_input)); break; }
			} else {
				program.ReInit(false);
			}
		}
	}
}