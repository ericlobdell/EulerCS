using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem21 : EulerChallenge
    {
        private const string Desc = "Evaluate the sum of all the amicable numbers under 10000.";
         public Problem21()
            : base(21, Desc)
        {
            Solve();
        }

        public void Solve()
        {
            Console.WriteLine( Range( 10000 )
                .Where( IsAmicableNumber ).Sum() );
        }
    }
}
