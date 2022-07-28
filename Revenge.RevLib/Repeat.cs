using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.RevLib
{
	public class Repeat
	{
		ErrorParser errorParser = new ErrorParser();
		public void RepeatChar(string chr, int times) {
			if (!String.IsNullOrEmpty(chr)) {
				for (int i = 0; i < times; i++) {
					Console.Write(chr);
				}
			} else {
				errorParser.ErrorSwitch("nul", "Character");
			}
		}

		public void RepeatEscSeq(string escseqchr, int times) {
			if (!String.IsNullOrEmpty(escseqchr)) {
				if (escseqchr != "\n" && escseqchr != "\t") {
					errorParser.ErrorSwitch("inv", "Escape Sequence", escseqchr);
				} else {
					for (int i = 0; i < times; i++) {
						Console.Write(escseqchr);
					}
				}
			} else {
				errorParser.ErrorSwitch("nul", "Character");
			}
		}

		public string GetCharRepeat(string ch, int times) {
			return (!String.IsNullOrEmpty(ch)) ? string.Concat(Enumerable.Repeat(ch, times)) : "NULL";
		}
	}
}