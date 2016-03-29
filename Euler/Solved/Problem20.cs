using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem20 : EulerChallenge
    {
        private const string Desc = "Find the sum of the digits in the number 100!";
         public Problem20()
            : base(20, Desc)
        {
            Solve();
        }

        public void Solve()
        {
            // used python to get the number as a usable string of just digits
            Console.WriteLine(
                SumNumericString(
                    "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000"
                ));
        }
    }
}
