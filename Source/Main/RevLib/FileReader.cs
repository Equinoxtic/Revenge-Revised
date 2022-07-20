using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.Source.Main.RevLib
{
	public class FileReader
	{
		public string ReadFile(string? file, string? ext) {
			string _file = System.IO.File.ReadAllText(@$"{file}.{ext}");
			return _file;
		}
	}
}