using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.Source.Main.RevLib
{
	public class ProgramReturn
	{
		public void ReturnToProgram(bool a = false) {
			Program program = new Program();
			program.ReInit(a);
		}
	}
}