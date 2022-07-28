using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.User
{
	public class UserHashes
	{
		private static Random random = new Random();
		public static void CreateHash(int length) {
			const string hash_chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(hash_chars, length)
				.Select(s => s[random.Next(s.Length)]).ToArray());
		}
	}
}