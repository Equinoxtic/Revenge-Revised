using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.User
{
	public class UserPass
	{
		public string GetUserPassword(string? pass) {
			FileReader fileReader = new FileReader();
			string pass_content = fileReader.ReadFile("pass", "txt");
			return (!File.Exists(pass_content)) ? pass_content : "Password";
		}
	}
}
