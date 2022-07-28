using System;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Revenge.RevLib;

namespace Revenge.RevLib
{
	public class Link
	{
		public void OpenLink(string? link) 
		{
			Program program = new Program();
			if (!String.IsNullOrEmpty(link)) {
				RunLink(link);
			} else {
				LinkPrompt();
			}
			program.ReInit(false);
		}

		void LinkPrompt()
		{
			Program program = new Program();
			ErrorParser errorParser = new ErrorParser();
			string? link = "";
			Console.Write("\nInput a link to open: ");
			link = Console.ReadLine();
			if (!String.IsNullOrEmpty(link)) {
				RunLink(link);
			} else {
				errorParser.ErrorSwitch("nul", "Link");
				program.ReInit(false);
			}
			program.ReInit(false);
		}

		void RunLink(string? _link) {
			if (!String.IsNullOrEmpty(_link)) {
				_link = _link.Replace("&", "&^");
				Process.Start(
					new ProcessStartInfo(GetLink(_link)) {UseShellExecute = true}
				);
			}
		}

		string GetLink(string? link) {
			return (!String.IsNullOrEmpty(link)) ? (!link.StartsWith("https://")) ? "https://" + link : link : "NULL";
		}
	}
}