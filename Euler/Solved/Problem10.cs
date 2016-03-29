using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem10 : EulerChallenge
    {
        private const string Desc = "Find the sum of all the primes below two million.";
         public Problem10()
            : base(10, Desc)
        {
            solve();
        }

        public void solve()
        {
            long sum = 0;
            long count = 0;
            while (count < 2000000)
            {
                sum += IsPrime( count ) ? count : 0;
                count++;
            }

            Console.WriteLine(sum);
        }
    }
}
