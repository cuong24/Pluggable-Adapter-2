﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pluggable_Adapter_2
{
	class AnotherAdaptee
	{
		public string Estimate(int i)
		{
			return "Estimate is " + (int)Math.Round(i / 3.0);
		}
	}
}
