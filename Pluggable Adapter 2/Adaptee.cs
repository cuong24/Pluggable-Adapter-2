using System;
using System.Collections.Generic;
using System.Text;

namespace Pluggable_Adapter_2
{
	class Adaptee
	{
		public double Precise(double a, double b)
		{
			return a / b;
		}
	}
}
