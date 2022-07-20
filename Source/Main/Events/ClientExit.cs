using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.Source.Main.Events
{
	public class ClientExit
	{
		public void InitExit(bool shouldClearScreen) {
			ClearScreen clearScreen = new ClearScreen();
			Console.Write("\nExiting...\n");
			Thread.Sleep(3000);
			if (shouldClearScreen) {
			 	clearScreen.DoScreenClear(false);
			}
		}
	}
}	