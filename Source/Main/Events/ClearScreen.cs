using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.Source.Main.Events
{
	public class ClearScreen
	{
		public void DoScreenClear(bool returnToMain) {
			Program program = new Program();
			System.Console.Clear();
			if (returnToMain) {
				program.ReInit(false);
			}
		}
	}
}