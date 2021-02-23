using System;
using System.Collections.Generic;
using System.Text;

namespace Pluggable_Adapter_2
{
	class AnotherAdapter : IAdapter
	{
        private AnotherAdaptee anotherAdaptee;
        public AnotherAdapter(AnotherAdaptee anotherAdaptee)
        {
            this.anotherAdaptee = anotherAdaptee;
        }
        public string Estimate(int x)
        {
            return "Estimate is " + anotherAdaptee.Estimate(x);
        }
    }
}
