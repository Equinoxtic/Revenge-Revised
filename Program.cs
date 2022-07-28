using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Init;

namespace Revenge
{
	class Program
	{
		static void Init(bool showInit = true) {
			InitClient init = new InitClient();
			init.NewInstance(showInit);
		}

		public static void Main(string[] args) {
			Init();
		}

		public void ReInit(bool showInit) {
			Init(showInit);
		}
	}
}