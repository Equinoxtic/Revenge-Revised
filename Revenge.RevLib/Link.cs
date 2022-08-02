using System;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Revenge.RevLib
{
	public class Link
	{
		public void OpenLink(string? link) {
			Program program = new Program();
			NullLinkCheck(link);
			program.ReInit(false, false);
		}

		void LinkPrompt()
		{
			Program program = new Program();
			string? link = "";
			Console.Write("\nInput a link to open: ");
			link = Console.ReadLine();
			NullLinkCheck(link, true);
			program.ReInit(false, false);
		}

		void RunLink(string? _link) {
			if (!String.IsNullOrEmpty(_link)) {
				_link = _link.Replace("&", "&^");
				Process.Start(
					new ProcessStartInfo(GetLink(_link)) {UseShellExecute = true}
				);
			}
		}

		void NullLinkCheck(string? link_str, bool throw_nul = false) {
			Program program = new Program();
			ErrorParser errorParser = new ErrorParser();
			if (!String.IsNullOrEmpty(link_str)) {
				RunLink(link_str);
			} else {
				if (!throw_nul) {
					RunLink(link_str);
				} else {
					errorParser.ErrorSwitch("nul", "Link");
					program.ReInit(false, false);
				}
			}
		}

		string GetLink(string? link) {
			return (!String.IsNullOrEmpty(link)) ? (!link.StartsWith("https://")) ? "https://" + link : link : "NULL";
		}
	}
}