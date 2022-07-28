using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.RevLib
{
	public class Parser
	{
		public string ParseStr(string str) {
			return (!String.IsNullOrEmpty(str)) ? str : "NULL";
		}
	}
}