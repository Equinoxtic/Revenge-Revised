using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.User
{
	public class UserData
	{
		public static string GetHash(int hash_length) {
			string hash = UserHashes.CreateHash(hash_length);
			string file = File.WriteAllText("userdat.txt", hash);
			return (!File.Exists(file)) ? file : "EMPTY_HASH";
		}
	}
}