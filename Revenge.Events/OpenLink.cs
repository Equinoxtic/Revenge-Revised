using System;
using System.Linq;
using System.Threading.Tasks;
using Revenge.RevLib;

namespace Revenge.Events
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