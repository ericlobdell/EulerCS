using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem7 : EulerChallenge
    {
        private const string Desc = "What is the 10 001st prime number?";
         public Problem7()
            : base(7, Desc)
        {
            solve();
        }

        public void solve()
        {
            var primes = new List<long>();
            var i = 1;
            var solved = false;

            while (!solved)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                    Console.WriteLine("{0} - {1}", i, primes.Count);
                }

                if (primes.Count == 10001)
                {
                    Console.WriteLine("The 10001th prime number is {0}", i);
                    solved = true;
                }

                i++;
            }
            

        }
    }
}
