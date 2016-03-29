using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem12 : EulerChallenge
    {
        private const string Desc = "What is the value of the first triangle number to have over five hundred divisors?";
        public Problem12()
            : base(12, Desc)
        {
            solve();
        }

        public void solve()
        {
            var solved = false;
            var i = 1000;

            while (!solved)
            {
                var triValue = TriangleValueForNumber(i);
                var divisors = GetDivisors((int)triValue);

                if ( i % 100 == 0 )
                    Console.WriteLine( $"{divisors.Count( )} divisors for {i}..." );

                if (divisors.Count() > 500)
                {
                    solved = true;
                    Console.WriteLine(triValue);
                }
                i++;
            }
        }

    }
}
