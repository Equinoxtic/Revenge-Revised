using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;
using Revenge.Display;
using Revenge.Options;
using Revenge.Events;
using Revenge.MathLib;
using Revenge.States;

/// <summary>
/// Main Initialization File for REVENGE (Only code here that is needed to start)
/// </summary>

namespace Revenge.Init
{
	public class InitClient
	{
		public void NewInstance(bool showInit, bool openLoading)
		{
			ModuleInit moduleInit = new ModuleInit();
			Repeat repeat = new Repeat();
			Title title = new Title();
			TextDivider textDivider = new TextDivider();
			Cursor cursor = new Cursor();
			Listener listener = new Listener();
			OptionsHandler optionsHandler = new OptionsHandler();
			Window window = new Window();
			LoadingState loadingState = new LoadingState();
			InitClient init = new InitClient();

			window.SetWindowTitle("Revenge");
			window.SetWindowSize(120, 32);

			string _input;

			// moduleInit.RunClientModules();

			if (showInit) {
				if (openLoading) {
					loadingState.CreateLoadingState();
				}
				title.CreateTitle("Title");
				repeat.RepeatEscSeq("\t", 6);
				Console.Write("Hello World!");
				optionsHandler.CreateOptions();
				textDivider.CreateDivider("-", 120, true);
			}
			
			Console.Write(cursor.GetCursor());
			_input = Console.ReadLine();
			listener.ListenForCommandInput(_input);
		}
	}
}