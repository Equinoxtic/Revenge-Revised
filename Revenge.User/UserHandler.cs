using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.User
{
	public class UserHandler
	{
		public string GetUsername() {
			FileReader fileReader = new FileReader();
			string user_name_file = fileReader.ReadFile("username", "txt");
			return (!File.Exists(user_name_file)) ? user_name_file : "User";
		}

		public string SetUsername(string? uname_str) {
			string? uname = uname_str;
			return (!String.IsNullOrEmpty(uname)) ? uname : "User";
		}
	}
}