namespace OpenCoverTest.Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Multiplier : ICalculator
    {
        public decimal Calculate(decimal value1, decimal value2)
        {
            return value1 * value2;
        }

        public decimal ExtraMethod(decimal value)
        {
            return value * 1000;
        }

        public decimal ExtraMethod2(decimal value)
        {
            return value * 1000;
        }
    }
}
