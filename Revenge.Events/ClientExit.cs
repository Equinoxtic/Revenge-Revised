using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.Events
{
	public class ClientExit
	{
		public void InitExit() {
			Console.Write("\nExiting...\n");
			Thread.Sleep(3000);
			Environment.Exit(0);
		}
	}
}