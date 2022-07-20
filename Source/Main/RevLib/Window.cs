using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.Source.Main.RevLib
{
	public class Window
	{
		public void SetWindowTitle(string? title_str = "") {
			if (!String.IsNullOrEmpty(title_str)) {
				Console.Title = title_str;
			} else {
				Console.Title = "Title";
			}
		}

		public void SetWindowSize(int a, int b) {
			if (a != 0 && b != 0) {
				Console.SetWindowSize(a, b);
			}
		}
	}
}