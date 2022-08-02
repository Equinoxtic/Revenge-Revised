using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Init;

namespace Revenge
{
	class Program
	{
		static void Init(bool showInit = true, bool doLoading = true) {
			InitClient client_init = new InitClient();
			client_init.NewInstance(showInit, doLoading);
		}

		public static void Main(string[] args) {
			Init();
		}

		public void ReInit(bool showInit, bool doLoading) {
			Init(showInit, doLoading);
		}
	}
}