using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;

namespace Revenge.Source.Main.Display
{
	public class Cursor
	{
		public string GetCursor() {
			FileReader fileReader = new FileReader();
			string cursor = fileReader.ReadFile("cursor", "txt");
			return (!File.Exists(cursor)) ? cursor + " " : "> ";
		}

		public string SetCursor(string cursorch) {
			return (!String.IsNullOrEmpty(cursorch)) ? cursorch + " " : "> ";
		}
	}
}