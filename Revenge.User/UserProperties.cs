using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.User
{
	public class UserProperties
	{
		public static string exec_prior = "";
		private static bool exec_admin = false;
		public bool CheckUserPermission() {
			exec_admin = ((exec_prior == "admin") ? true : false);
			return exec_admin;
		}
	}
}