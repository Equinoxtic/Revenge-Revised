/// <summary>
/// Template Module
/// </summary>
using System;
using System.Linq;
using System.Threading.Tasks;
using Templates.SampleModule.Init;

namespace Templates.SampleModule
{
	class TemplateModule
	{
		public void InitModule() {
			ModuleInit moduleinit = new ModuleInit();
			moduleinit.StartInit();
		}
	}
}