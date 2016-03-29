using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem6 : EulerChallenge
    {
        private const string Desc = "Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";
        public Problem6()
            : base(6, Desc)
        {
            solve();
        }

        public void solve()
        {
            var nums = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                nums.Add(i);
            }

            var numSum = nums.Sum();
            var sqSum = nums.Select(x => x * x).Sum();
            Console.WriteLine("{0} - {1} = {2}", (numSum * numSum), sqSum, (numSum * numSum) - sqSum);
        }
    }
}
