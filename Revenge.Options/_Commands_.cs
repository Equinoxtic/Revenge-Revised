using System;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Class for storing arrays for the Command's Name, Description, etc.
/// </summary>

namespace Revenge.Options
{
	public class _Commands_
	{
		public string[] testCommandTerms = {
			"test",
			"-exit",
			"ioio"
		};

		public string[] testCommandNames = {
			"Test",
			"Exit",
			"IOIO"
		};

		public string[] testCommandDescs = {
			"Testing",
			"Exit out of the client",
			"Ooga Booga"
		};
	}
}