using System;

namespace Pluggable_Adapter_2
{
	class Client
	{

		static void Main()
		{

			IAdapter adapter1 = new Adapter(new Adaptee());
			Console.WriteLine(adapter1.Estimate(5));

			IAdapter adapter2 = new AnotherAdapter(new AnotherAdaptee());
			Console.WriteLine(adapter2.Estimate(5));

		}
	}
}
