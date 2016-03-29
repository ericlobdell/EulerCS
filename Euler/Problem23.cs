using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem23 : EulerChallenge
    {
        private const string Desc = "Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.";
        public Problem23()
            : base(23, Desc)
        {
            solve();
        }

        public void solve()
        {

            long sum = 0;
            for ( int i = 0; i <= 28123; i++ )
            {
                sum += IsAbundantSum(i) ? 0 : i;
                if (i % 100 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(sum);
        }
    }
}
