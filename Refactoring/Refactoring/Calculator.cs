using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public static class Calculator
    {
        private static decimal _RunningTotal;

        public static decimal RunningTotal
        {
            get { return _RunningTotal; }
            set { _RunningTotal = value; }
        }



        public  static decimal Add(decimal a, decimal b)
        {
            var rv = a + b;
            _RunningTotal += rv;
            return rv;
        }
        public static decimal Subtract(decimal a, decimal b)
        {
            var rv = a - b;
            _RunningTotal -= rv;
            return rv;
        }

        public static decimal Multiple(decimal a, decimal b)
        {
            var rv = a * b;
            _RunningTotal *= rv;
            return rv;
        }
        public static decimal Divide(decimal a, decimal b)
        {
            var rv = (decimal)a / (decimal)b;
            _RunningTotal /= rv;
            return rv;
        }
    }
}
