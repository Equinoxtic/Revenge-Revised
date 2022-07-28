using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.RevLib
{
	public class FileWriter
	{
		public string WriteFile(string? file, string? ext, string? contents) {
			string _file = File.WriteAllText(@$"{file}.{ext}", contents);
			return _file;
		}
	}
}