using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.Display;
using Revenge.Source.Main.Options.Objects;

namespace Revenge.Source.Main.Options
{
	public class OptionsHandler
	{
		public void CreateOptions() {
			Option option = new Option();
			Command command = new Command();
			Category category = new Category();
			TextDivider textDivider = new TextDivider();
			_Options_ options = new _Options_();
			_Commands_ commands = new _Commands_();
			
			/* Test Category */
			textDivider.CreateDivider("-", 120, true);
			category.CreateCategory("Test Category", true, true, true, 6);
			for (int i = 1; i <= 5; i++) {
				option.CreateOption(i, "Test Option " + i, true, true, 6);
			}

			/* Test Array Category */
			textDivider.CreateDivider("-", 120, true);
			category.CreateCategory("Test Arrays", true, true, true, 6);
			GetOptions(options.testOptionsArr, options.testOptionsArr.Length, 6);

			/* Commands Test */
			textDivider.CreateDivider("-", 120, true);
			category.CreateCategory("Test Commands", true, true, true, 6);
			for (int i = 1; i <= 5; i++) {
				command.CreateCommand($"lol {i}", $"LOL {i}", $"LOLOLOLOLOLOLOL {i}");
			}

			textDivider.CreateDivider("-", 120, true);
			category.CreateCategory("Test Comand Arrays", true, true, true, 6);
			GetCommands(commands.testCommandTerms, commands.testCommandNames, commands.testCommandDescs, commands.testCommandTerms.Length);
		}

		void GetOptions(string[] arr, int length, int increment) {
			Option option = new Option();
			for (int i = 0; i < length; i++) {
				option.CreateOption(i+increment, arr[i]);
			}
		}

		void GetCommands(string[] arr_command_term, string[] arr_command_name, string[] arr_command_descs, int length) {
			Command command = new Command();
			for (int i = 0; i < length; i++) {
				command.CreateCommand(arr_command_term[i], arr_command_name[i], arr_command_descs[i]);
			}
		}
	}
}