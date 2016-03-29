using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem9 : EulerChallenge
    {
         private const string Desc = "There exists exactly one Pythagorean triplet for which a + b + c = 1000.\nFind the product abc.";
         public Problem9()
            : base(9, Desc)
        {
            solve();
        }

        public void solve()
        {
            for (int a = 0; a < 1000; a++)
            {
                for (int b = 0; b < 1000; b++)
                {
                    for (int c = 0; c < 1000; c++)
                    {
                        if (a + b + c != 1000) continue;
                        if (IsPythagoreanTriplet(a, b, c))
                        {
                            Console.WriteLine(a*b*c);
                        }
                    }
                }
            }
        }
    }
}
