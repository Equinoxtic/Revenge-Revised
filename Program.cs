using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.Init;

namespace Revenge
{
	class Program
	{
		static void Init(bool showInit = true) {
			Init init = new Init();
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