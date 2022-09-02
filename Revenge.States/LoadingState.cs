using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Events;
using Revenge.RevLib;

namespace Revenge.States
{
	public class LoadingState
	{
		string[] loading_files = {

			// Display
			"Display/Cursor",
			"Display/StatusBar",
			"Display/TextDivider",
			"Display/Title",

			// Events
			"Events/ClearScreen",
			"Events/ClientExit",
			"Events/OpenLink",
			"Events/RunCommand",
			"Events/RunOption",

			// Init
			"Init/InitClient",
			"Init/ModuleInit",

			// MathLib
			"MathLib/Constants",
			"MathLib/FkMath",
			"MathLib/Functions",
			"MathLib/Trigonometric",

			// Options
			"Options/_Commands_",
			"Options/_Options_",
			"Options/Category",
			"Options/Command",
			"Options/Option",
			"Options/OptionsHandler",

			// RevLib
			"RevLib/ClientVersion",
			"RevLib/ErrorParser",
			"RevLib/FileReader",
			"RevLib/FileWriter",
			"RevLib/Link",
			"RevLib/Listener",
			"RevLib/Parser",
			"RevLib/Repeat",
			"RevLib/Window",

			// States
			"States/LoadingState",

			// User
			"User/UserHandler"

		};

		public void CreateLoadingState() {
			CreateLoadingTitle();
			LoadingProcess();
		}

		void LoadingProcess() {
			Random random = new Random();
			ClearScreen clearScreen = new ClearScreen();
			for (int i = 0; i < loading_files.Length; i++) {
				Thread.Sleep(random.Next(300, 600));
				Console.Write(
					"- Revenge/" + loading_files[i] + ".cs\n"
				);
			}
			clearScreen.DoScreenClear(false);
		}

		void CreateLoadingTitle() {
			ClientVersion clientVersion = new ClientVersion();
			ClearScreen clearScreen = new ClearScreen();
			clearScreen.DoScreenClear(false);
			Console.Write(
				"\n\n# Compiling - REVENGE #\n> .NET SDK version: " + Environment.Version.ToString()
				+ "\n> REVENGE Client version: " + clientVersion.GetClientVersion() + "\n\n"
			);
		}
	}
}