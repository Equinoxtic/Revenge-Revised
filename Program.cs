using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.Init;

namespace Revenge
{
	class Program
	{
		static void Init(bool showOptions = true) {
			Init init = new Init();
			init.NewInstance(showOptions);
		}

		public static void Main(string[] args) {
			Init();
		}

		public void ReInit(bool showOptions) {
			Init(showOptions);
		}
	}
}