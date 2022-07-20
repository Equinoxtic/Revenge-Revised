using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.Display;

namespace Revenge.Source.Main.Options
{
	public class OptionsHandler
	{
		string[] testOptionsArr = {
			"One",
			"Two",
			"Three",
			"Four",
			"Five"
		};

		public void CreateOptions() {
			Option option = new Option();
			Command command = new Command();
			Category category = new Category();
			TextDivider textDivider = new TextDivider();
			
			/* Test Category */
			textDivider.CreateDivider("-", 120, true);
			category.CreateCategory("Test Category", true, true, true, 6);
			for (int i = 1; i <= 5; i++) {
				option.CreateOption(i, "Test Option " + i, true, true, 6);
			}

			/* Test Array Category */
			textDivider.CreateDivider("-", 120, true);
			category.CreateCategory("Test Arrays", true, true, true, 6);
			GetOptions(testOptionsArr, testOptionsArr.Length, 6);

			/* Commands Test */
			textDivider.CreateDivider("-", 120, true);
			category.CreateCategory("Test Commands", true, true, true, 6);
			for (int i = 1; i <= 5; i++) {
				command.CreateCommand($"lol {i}", $"LOL {i}", $"LOLOLOLOLOLOLOL {i}");
			}
		}

		void GetOptions(string[] arr, int length, int increment) {
			Option option = new Option();
			for (int i = 0; i < length; i++) {
				option.CreateOption(i+increment, arr[i]);
			}
		}

		void GetOptions(string[] arr_command_term, string[] arr_command_name, int length, string[] arr_command_descs) {
			Command command = new Command();
			for (int i = 0; i < length; i++) {
				command.CreateCommand(arr_command_term[i], arr_command_name[i], arr_command_descs[i]);
			}
		}
	}
}