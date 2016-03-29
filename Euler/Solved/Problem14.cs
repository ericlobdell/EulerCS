using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Euler
{
    class Problem14 : EulerChallenge
    {
        private const string Desc = "The following iterative sequence is defined for the set of positive integers:\n\tn → n/2 (n is even)\n\tn → 3n + 1 (n is odd)\n\n" +
            "It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.\n\nWhich starting number, under one million, produces the longest chain?";
         public Problem14()
            : base(14, Desc)
        {
            solve();
        }

        public void solve()
        {

            var seqs = new Dictionary<long, List<long>>();
            var counts = new List<long>();
            for ( int i = 1; i < 1000000; i++ )
            {
                var seq = BuildCollatzSequence( i );
                if (seqs.Count > 0)
                {
                    if ( seq.First().Value.Count > seqs.First().Value.Count )
                    {
                        seqs.Clear();
                        seqs.Add( seq.First().Key, seq.First().Value );
                    }
                }
                else
                {
                    seqs.Add( seq.First().Key, seq.First().Value );
                }
                
                
            }
            var longest = seqs.OrderBy(s => s.Value.Count).First();
            Console.WriteLine("{0} - {1}" ,longest.Key, longest.Value.Count );

        }

        private Dictionary<long, List<long>> BuildCollatzSequence ( long startingValue )
        {
            var vals = new List<long>() { startingValue };
            var currentValue = startingValue;

            while (currentValue != 1)
            {
                var newValue = IsEven(currentValue)
                    ? (currentValue/2)
                    : (currentValue*3) + 1;

                vals.Add( newValue );

                currentValue = newValue;
            }

            return new Dictionary<long, List<long>>()
                   {
                       { startingValue, vals }
                   }; 
        }
    }
}
