using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.Display
{
	public class StatusBar
	{
		public void CreateStatusBar(bool shouldNewLine) {
			ClientVersion clientVersion = new ClientVersion();
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write(
				"[ " + clientVersion.GetClientVersion() + " ]", Console.BackgroundColor
			);
			Console.ResetColor();
			if (shouldNewLine) { Console.Write("\n"); }
		}
	}
}