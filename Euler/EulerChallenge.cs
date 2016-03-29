using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class EulerChallenge
    {
        public string Description { get; set; }
        public int Number { get; set; }

        public EulerChallenge(int n, string d)
        {
            Console.WriteLine("{0}. {1}", n, d);
        }

        public static bool IsPrime ( long n )
        {
            var boundary = (long) Math.Floor( Math.Sqrt( n ) );
            if ( n == 1 ) return false;
            if ( n == 2 ) return true;

            for ( int i = 2; i <= boundary; ++i )
            {
                if ( n % i == 0 ) return false;
            }

            return true;
        }


        public static bool IsPythagoreanTriplet ( int a, int b, int c )
        {
            return ( a * a ) + ( b * b ) == ( c * c );
        }

        public static bool IsEven ( long n )
        {
            return n % 2 == 0;
        }

        public static bool IsDivisor ( int n, int test )
        {
            return n % test == 0;
        }

        public static long SumNumericString ( string s )
        {
            return s.Aggregate(0, (acc, n) => acc += Int32.Parse(n.ToString()));
        }

        public static long Factorial ( long n )
        {
            return n <= 0 ? 1 : n * Factorial( n - 1 );
        }

        public static bool IsPalindrome ( string s )
        {
            var isPalindrome = false;
            for ( int i = 0; i < s.Length; i++ )
            {
                isPalindrome = ( s.Substring( i, 1 ) == s.Substring( ( s.Length - 1 ) - i, 1 ) );
                if ( !isPalindrome )
                    break;
            }

            return isPalindrome;
        }

        public static IEnumerable<int> GetDivisors ( int n )
        {
            return Range( n - 1 ).Where( x => IsDivisor( n, x ) );
        }

        public static bool IsAmicableNumber ( int a )
        {
            var b = GetDivisors( a ).Sum();
            return GetDivisors( b ).Sum() == a && b != a;
        }

        public static IEnumerable<int> Range ( int n )
        {
            return Enumerable.Range( 1, (n >= 0 ? n : 0) );
        }

        public static bool IsAbundantNumber(int n)
        {
            return GetDivisors(n).Sum() > n;
        }

        public static bool IsAbundantSum(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                if (!IsAbundantNumber(i)) continue;

                if (IsAbundantNumber(n-i))
                {
                    return true;
                }
            }
            return false;
        }

        public static double TriangleValueForNumber(int n)
        {
            var triVal = 0;
            for (int i = 0; i <= n; i++)
            {
                triVal += i;
            }
            return triVal;
        }

        public static double Fibonacci(double n)
        {
            double a = 0;
            double b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for ( double i = 0; i < n; i++ )
            {
                double temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
