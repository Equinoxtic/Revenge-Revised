using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;

namespace Revenge.Source.Main.User
{
	public class Username
	{
		public string GetUsername() {
			FileReader fileReader = new FileReader();
			string user_name_file = fileReader.FileReader("username", "txt");
			return (!File.Exists(user_name_file)) ? user_name_file : "User";
		}

		public string SetUsername(string? uname_str) {
			string? uname = uname_str;
			return (!String.IsNullOrEmpty(uname)) ? uname : "User";
		}

		public string SetUsernameStrict(string? uname, string? strict_strings, string? replace_with) {
			string? strict_uname;
			if (!String.IsNullOrEmpty(uname)) {
				strict_uname = uname.Replace(strict_strings, replace_with);
			}
			return strict_uname;
		}
	}
}