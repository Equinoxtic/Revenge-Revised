using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Revenge.User;

namespace Revenge.RevLib
{
	public class FileWriter
	{
		public string WriteFile(string? file, string? ext, string? contents) {
			string _file = @$"{file}.{ext}";
			string doc_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			StreamWriter out_file = new StreamWriter(Path.Combine(doc_path, _file));
			out_file.WriteLine(contents);
			return Convert.ToString(out_file);
		}
	}
}