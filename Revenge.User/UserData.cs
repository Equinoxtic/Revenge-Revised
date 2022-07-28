using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.User
{
	public class UserData
	{
		public static string GetHash(int hash_length) {
			FileWriter fileWriter = new FileWriter();
			string hash = UserHashes.CreateHash(hash_length);
			string file = fileWriter.WriteFile("userdat", "txt", hash);
			return (!File.Exists(file)) ? file : "EMPTY_HASH";
		}
	}
}