using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.Display;

namespace Revenge.Source.Main.Options
{
	public class OptionsHandler
	{

		public void CreateOptions() {
			Option option = new Option();
			Category category = new Category();
			TextDivider textDivider = new TextDivider();
			
			/* Test Category */
			textDivider.CreateDivider("-", 120, true);
			category.CreateCategory("Test Category", true, true, true, 6);
			option.CreateOption(1, "Test Option 1", true, true, 6);
			option.CreateOption(2, "Test Option 1", true, true, 6);
			option.CreateOption(3, "Test Option 1", true, true, 6);
		}
	}
}