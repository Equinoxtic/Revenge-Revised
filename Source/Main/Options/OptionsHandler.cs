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
			"Three"
		};

		public void CreateOptions() {
			Option option = new Option();
			Category category = new Category();
			TextDivider textDivider = new TextDivider();
			
			/* Test Category */
			textDivider.CreateDivider("-", 120, true);
			category.CreateCategory("Test Category", true, true, true, 6);
			for (int i = 1; i <= 3; i++) {
				option.CreateOption(i, "Test Option " + i, true, true, 6);
			}

			/* Test Array Category */
			textDivider.CreateDivider("-", 120, true);
			category.CreateCategory("Test Arrays", true, true, true, 6);
			GetOptions(testOptionsArr, testOptionsArr.Length, 4);
		}

		void GetOptions(string[] arr, int length, int increment) {
			Option option = new Option();
			for (int i = 0; i < length; i++) {
				option.CreateOption(i+increment, arr[i]);
			}
		}
	}
}