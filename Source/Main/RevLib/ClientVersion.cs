using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.Source.Main.RevLib
{
	public class ClientVersion
	{
		public string GetClientVersion() {
			FileReader fileReader = new FileReader();
			string version_file = fileReader.ReadFile("version", "txt");
			return (!File.Exists(version_file)) ? version_file : "NULL";
		}

		public void OutputClientVersion() {
			FileReader fileReader = new FileReader();
			string version_file = fileReader.ReadFile("version", "txt");
			if (!File.Exists(version_file)) {
				Console.Write(version_file);
			} else {
				Console.Write("> ");
			}
		}
	}
}