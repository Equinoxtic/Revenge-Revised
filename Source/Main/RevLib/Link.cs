using System;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Revenge.Source.Main.RevLib;

namespace Revenge.Source.Main.RevLib
{
	public class Link
	{
		public string GetLink(string? link) {
			return (!String.IsNullOrEmpty(link)) ? (!link.StartsWith("https://")) ? "https://" + link : link : "NULL";
		}

		public void OpenLink(string? link) 
		{
			Program program = new Program();
			if (!String.IsNullOrEmpty(link)) {
				link = link.Replace("&", "&^");
				Process.Start(
					new ProcessStartInfo(link) {UseShellExecute = true}
				);
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
				link = link.Replace("&", "&^");
				Process.Start(
					new ProcessStartInfo(GetLink(link)) {UseShellExecute = true}
				);
			} else {
				errorParser.ErrorSwitch("nul", "Link");
				program.ReInit(false);
			}
			program.ReInit(false);
		}
	}
}