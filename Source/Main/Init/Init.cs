using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;
using Revenge.Source.Main.Display;
using Revenge.Source.Main.Options;

/// <summary>
/// Main Initialization File for REVENGE (Only code here that is needed to start)
/// </summary>

namespace Revenge.Source.Main.Init
{
	public class Init
	{
		TextDivider textDiv = new TextDivider();
		Title title = new Title();
		Cursor cursor = new Cursor();
		Repeat strrepeat = new Repeat();
		Parser parser = new Parser();
		Window window = new Window();
		OptionsHandler optionsHandler = new OptionsHandler();

		public void NewInstance(bool showOptions)
		{
			window.SetWindowTitle("Revenge");
			window.SetWindowSize(120, 32);
			title.CreateTitle("Title");
			strrepeat.RepeatEscSeq("\t", 6);
			Console.Write("Hello World!");
			
			if (showOptions) {
				optionsHandler.CreateOptions();
			}

			textDiv.CreateDivider("-", 120, true);
			Console.Write(cursor.GetCursor());
			Console.Read();
		}
	}
}