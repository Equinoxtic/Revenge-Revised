using System;
using System.Linq;
using System.Threading.Tasks;

namespace Revenge.RevLib
{
	public class ErrorParser
	{
		/*
			Error Switch types
			- "inv" > Invalid Error
			- "nul" > Null Error
			- "wip" > Work In Progress Error
		*/

		public void ErrorSwitch(string? type, string? cause, string? key = "", string? errorStr = "ERROR", bool doBeep = true)
		{
			// This if statement looking kinda goofy bro ong :skull:
			if ( !String.IsNullOrEmpty(type) &&
				!String.IsNullOrEmpty(cause) && 
				!String.IsNullOrEmpty(key) &&
				!String.IsNullOrEmpty(errorStr) ) {
				switch(type)
				{
					case "inv":
						Console.Write($"[{errorStr}]: Invalid {cause}: {key}.");
						break;
					case "nul":
						Console.Write($"[{errorStr}]: Empty/NULL {cause}.");
						break;
					case "wip":
						Console.Write($"{cause}: {key}, is still in Work In Progress.");
						break;
				}
			}
			if (doBeep) { Console.Beep(800, 200); }
		}
	}
}