using System;
using System.Collections.Generic;
using System.Text;

namespace Pluggable_Adapter_2
{
    class Adapter : IAdapter
    {
        private Adaptee adaptee;
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public string Estimate(int x)
        {
            return "Estimate is " + adaptee.Precise(x, 3.0);
        }
    }
}
