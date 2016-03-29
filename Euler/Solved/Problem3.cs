using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem3 : EulerChallenge
    {
        private const string Desc = "What is the largest prime factor of the number 600851475143 ?";
        private const long nut = 600851475143;
        public Problem3()
            : base(3, Desc)
        {
            solve();
        }

        public void solve()
        {
            var num = (long)Math.Floor(Math.Sqrt(nut));
            var solved = false;

            Func<long, bool> IsDivisibleBy = n =>
                nut % n == 0;


            while (!solved)
            {
                if (IsDivisibleBy(num))
                {
                    if (IsPrime(num))
                    {
                        Console.WriteLine(num);
                        solved = true;
                    }
                }
                num--;
            }

        }
    }
}
