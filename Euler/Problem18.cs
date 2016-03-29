using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    internal class Problem18 : EulerChallenge
    {
        private const string Desc = "Find the maximum total from top to bottom of the triangle below:";

        public Problem18()
            : base(18, Desc)
        {
            Solve();
        }

        public void Solve()
        {
            var sum = 0;
            var numLists = new List<List<int>>()
                           {
                               new List<int>() {75},
                               new List<int>() {95, 64},
                               new List<int>() {17, 47, 82},
                               new List<int>() {18, 35, 87, 10},
                               new List<int>() {20, 04, 82, 47, 65},
                               new List<int>() {19, 01, 23, 75, 03, 34},
                               new List<int>() {88, 02, 77, 73, 07, 63, 67},
                               new List<int>() {99, 65, 04, 28, 06, 16, 70, 92},
                               new List<int>() {41, 41, 26, 56, 83, 40, 80, 70, 33},
                               new List<int>() {41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
                               new List<int>() {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
                               new List<int>() {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
                               new List<int>() {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
                               new List<int>() {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
                               new List<int>() {04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
                           };

            for (int i = 0; i < numLists.Count - 1; i++)
            {
                var currentList = numLists[i];
                var nextList = numLists[i + 1];
                var currentMaxSum = 0;
                foreach (var num in currentList)
                {
                    var sums = new List<int>();
                    var numIndex = currentList.IndexOf(num);
                    sums.Add( currentList[numIndex] + nextList[numIndex] );
                    sums.Add( currentList [ numIndex ] + nextList [ numIndex + 1 ] );

                    if (currentMaxSum < sums.Max())
                    {
                        currentMaxSum = sums.Max();
                    }
                }
                sum += currentMaxSum;
            }

            Console.WriteLine(sum);

        }
    }
}