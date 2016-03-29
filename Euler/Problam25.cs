using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem25 : EulerChallenge
    {
        private const string Desc = "What is the first term in the Fibonacci sequence to contain 1000 digits?";
        public Problem25()
            : base(25, Desc)
        {
            solve();
        }

        public void solve()
        {
            var solved = false;
            double i = 10;
            double n = 0;
            double previous = 0;
            while (!solved)
            {
                n = Fibonacci(i);
                // if we've exceeded the boundary, proceed with smaller increments
                if (n >= Math.Pow(10, 999))
                {
                    // walk every number to find the first value that satisfies the requirement
                    for (double j = previous; j < n; j++)
                    {
                        var x = Fibonacci(j);
                        solved = x >= Math.Pow(10, 999);
                        Console.WriteLine( "{0} - {1}", j, x );
                    }

                    i++;
                }
                else
                {
                    // until we reach or exceed the limit, increase index exponentially
                    // store index for when we do cross boundary
                    previous = i;
                    i = Math.Pow(i, i);
                }
                
            }
            
        }
    }
}
