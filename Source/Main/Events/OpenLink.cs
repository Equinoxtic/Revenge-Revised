using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.Source.Main.RevLib;

namespace Revenge.Source.Main.Events
{
	public class OpenLink
	{
		public void InitLink(string? _link) {
			Link link = new Link();
			if (!String.IsNullOrEmpty(_link)) {
				link.OpenLink(_link);
			}
 		}
	}
}