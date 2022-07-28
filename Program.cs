using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Init;
using Revenge.States;
using Revenge.RevLib;

namespace Revenge
{
	class Program
	{
		static void Init(bool showInit = true) {
			Window window = new Window();
			LoadingState loadingState = new LoadingState();
			InitClient init = new InitClient();

			window.SetWindowTitle("Revenge");
			window.SetWindowSize(120, 32);
			loadingState.CreateLoadingState();

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