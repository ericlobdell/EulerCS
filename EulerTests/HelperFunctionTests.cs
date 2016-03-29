using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler;

namespace EulerTests
{
    [TestClass]
    public class HelperFunctionTests
    {
        [TestMethod]
        public void IsPalindromeReturnFalseForNonPalindrome ()
        {
            Assert.IsFalse( EulerChallenge.IsPalindrome( "notapalindrome" ) );
        }

        [TestMethod]
        public void IsPalindromeReturnTrueForPalindrome ()
        {
            Assert.IsTrue( EulerChallenge.IsPalindrome( "noon" ) );
            Assert.IsTrue( EulerChallenge.IsPalindrome( "abcba" ) );
            Assert.IsTrue( EulerChallenge.IsPalindrome( "123454321" ) );
        }

        [TestMethod]
        public void GetDivisorsReturnsCollectionOfDivisorsForNumber ()
        {
            var divisorsOf220 = new List<int> { 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110 };
            var nums = EulerChallenge.GetDivisors( 220 );

            Assert.AreEqual( divisorsOf220.Count, nums.Count() );

            foreach ( var d in divisorsOf220 )
            {
                Assert.IsTrue( nums.Contains( d ) );
            }
        }

        [TestMethod]
        public void RangeReturnsIenumerableOfNumbersFromOneToN ()
        {
            var range = EulerChallenge.Range( 15 ).ToList();
            Assert.AreEqual( 1, range.Min() );
            Assert.AreEqual( 15, range.Max() );
            Assert.AreEqual( 15, range.Count );
        }

        [TestMethod]
        public void SumNumericStringReturnsCorrectValue ()
        {
            var sum = EulerChallenge.SumNumericString( "123" );
            Assert.AreEqual( 6, sum );
        }

        [TestMethod]
        public void IsDivisorReturnsTrueForDivisor ()
        {
            Assert.IsTrue( EulerChallenge.IsDivisor( 6, 2 ) );
            Assert.IsTrue( EulerChallenge.IsDivisor( 6, 3 ) );
        }

        [TestMethod]
        public void IsDivisorReturnsFalseForNonDivisor ()
        {
            Assert.IsFalse( EulerChallenge.IsDivisor( 6, 5 ) );
            Assert.IsFalse( EulerChallenge.IsDivisor( 6, 4 ) );
        }

        [TestMethod]
        public void IsEvenReturnsTrueForEvenNumbers ()
        {
            Assert.IsTrue( EulerChallenge.IsEven( 6 ) );
            Assert.IsTrue( EulerChallenge.IsEven( 12 ) );
        }

        [TestMethod]
        public void IsEvenReturnsFalseForOddNumbers ()
        {
            Assert.IsFalse( EulerChallenge.IsEven( 3 ) );
            Assert.IsFalse( EulerChallenge.IsEven( 5 ) );
        }

        [TestMethod]
        public void IsPrimeReturnsTrueForPrimeNumbers ()
        {
            Assert.IsTrue( EulerChallenge.IsPrime( 13 ) );
            Assert.IsTrue( EulerChallenge.IsPrime( 7 ) );
        }

        [TestMethod]
        public void IsPrimeReturnsFalseForNonPrimeNumbers ()
        {
            Assert.IsFalse( EulerChallenge.IsPrime( 4 ) );
            Assert.IsFalse( EulerChallenge.IsPrime( 10 ) );
        }

        [TestMethod]
        public void IsAmicableNumberReturnsTrueForAmicblbeNumbers ()
        {
            Assert.IsTrue( EulerChallenge.IsAmicableNumber( 220 ) );
            Assert.IsTrue( EulerChallenge.IsAmicableNumber( 284 ) );
        }

        [TestMethod]
        public void IsAmicableNumberReturnsFalseForNonAmicblbeNumbers ()
        {
            Assert.IsFalse( EulerChallenge.IsAmicableNumber( 3 ) );
            Assert.IsFalse( EulerChallenge.IsAmicableNumber( 5 ) );
        }

        [TestMethod]
        public void IsAbundantNumberReturnsTrueForAbundantNumbers ()
        {
            Assert.IsTrue( EulerChallenge.IsAbundantNumber( 12 ) );
            Assert.IsTrue( EulerChallenge.IsAbundantNumber( 18 ) );
        }

        [TestMethod]
        public void IsAbundantNumberReturnsFalseForNonAbundantNumbers ()
        {
            Assert.IsFalse( EulerChallenge.IsAbundantNumber( 28 ) );
            Assert.IsFalse( EulerChallenge.IsAbundantNumber( 8 ) );
        }

        [TestMethod]
        public void IsAbundantsumReturnsTrueForAbundantsums ()
        {
            Assert.IsTrue( EulerChallenge.IsAbundantSum( 12 + 18 ) );
            Assert.IsTrue( EulerChallenge.IsAbundantSum( 20 + 24 ) );
            Assert.IsTrue( EulerChallenge.IsAbundantSum( 24 ) );
        }

        [TestMethod]
        public void IsAbundantsumReturnsFalseForNonAbundantsums ()
        {
            Assert.IsFalse( EulerChallenge.IsAbundantSum( 5 + 6 ) );
            Assert.IsFalse( EulerChallenge.IsAbundantSum( 3 + 12 ) );
        }

        [TestMethod]
        public void FibbonacciReturnsCorrectResult ()
        {
            Assert.AreEqual( 2, EulerChallenge.Fibonacci( 3 ) );
            Assert.AreEqual( 8, EulerChallenge.Fibonacci( 6 ) );
            Assert.AreEqual( 21, EulerChallenge.Fibonacci( 8 ) );
        }

        [TestMethod]
        public void TriangleValueForNumberReturnsCorrectResult ()
        {
            Assert.AreEqual( 28, EulerChallenge.TriangleValueForNumber( 7 ) );
            Assert.AreEqual( 21, EulerChallenge.TriangleValueForNumber( 6 ) );
            Assert.AreEqual( 15, EulerChallenge.TriangleValueForNumber( 5 ) );
        }

    }
}
