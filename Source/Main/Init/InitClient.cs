using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;
using Revenge.Source.Main.Display;
using Revenge.Source.Main.Options;
using Revenge.Source.Main.Events;
using Revenge.Source.Main.Math;

/// <summary>
/// Main Initialization File for REVENGE (Only code here that is needed to start)
/// </summary>

namespace Revenge.Source.Main.Init
{
	public class InitClient
	{
		ClearScreen clearScreen = new ClearScreen();
		TextDivider textDiv = new TextDivider();
		Title title = new Title();
		Cursor cursor = new Cursor();
		Repeat strrepeat = new Repeat();
		Parser parser = new Parser();
		Window window = new Window();
		OptionsHandler optionsHandler = new OptionsHandler();
		RunCommand runCommand = new RunCommand();
		RunOption runOption = new RunOption();
		Listener listener = new Listener();
		ModuleInit moduleInit = new ModuleInit();
		Trigonometric trigonometric = new Trigonometric();

		public void NewInstance(bool showInit)
		{
			string _input;

			Console.Write(trigonometric.Sin(20));

			moduleInit.RunClientModules();

			window.SetWindowTitle("Revenge");
			window.SetWindowSize(120, 32);

			if (showInit) {
				title.CreateTitle("Title");
				strrepeat.RepeatEscSeq("\t", 6);
				Console.Write("Hello World!");
				optionsHandler.CreateOptions();
				textDiv.CreateDivider("-", 120, true);
			}
			
			Console.Write(cursor.GetCursor());
			_input = Console.ReadLine();
			listener.ListenForCommandInput(_input);
		}
	}
}