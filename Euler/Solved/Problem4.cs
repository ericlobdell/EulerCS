using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem4 : EulerChallenge
    {
        private const string Desc = "Find the largest palindrome made from the product of two 3-digit numbers.";
         public Problem4()
            : base(4, Desc)
        {
            Solve();
        }

        public void Solve()
        {
            var maxPalindrome = 0;
            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    var p = i*j;
                    if (IsPalindrome(p.ToString()))
                    {
                        maxPalindrome = p > maxPalindrome
                            ? p
                            : maxPalindrome;
                    }
                }
            }

            Console.WriteLine(maxPalindrome);
        }

    }
}
