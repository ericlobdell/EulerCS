using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem5 : EulerChallenge
    {
        private const string Desc = "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";

        public Problem5()
            : base(5, Desc)
        {
            solve();
        }

        public void solve()
        {
            var solved = false;
            var nut = 21;
            while (!solved)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (nut % i != 0)
                    {
                        nut++;
                        break;
                    }

                    if (i == 20)
                    {
                        Console.WriteLine(nut);
                        solved = true;
                    }
                }
            }
        }
    }
}
