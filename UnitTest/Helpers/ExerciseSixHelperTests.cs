using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Spinutech.Helpers.Tests
{
    [TestClass()]
    public class ExerciseSixHelperTests
    {
        #region Tests For Positive Number

        /// <summary>
        /// Test If 0 Passes
        /// </summary>
        [TestMethod()]
        public void IsZeroAPositiveNumberTest()
        {
            Assert.IsTrue( ExerciseSixHelpers.IsAPositiveNumber( 0 ) );
        }

        /// <summary>
        /// Test If A Positive Number Passes
        /// </summary>
        [TestMethod()]
        public void DoesAPositiveNumberPassTest()
        {
            Assert.IsTrue( ExerciseSixHelpers.IsAPositiveNumber( 50 ) );
        }


        /// <summary>
        /// Test If A Negative Number Fails
        /// </summary>
        [TestMethod()]
        public void DoesANegativeNumberPassTest()
        {
            Assert.IsFalse( ExerciseSixHelpers.IsAPositiveNumber( -50 ) );
        }

        #endregion

        #region Tests For Calculating A Palindrome
        /// <summary>
        /// Test If 0 Passes
        /// </summary>
        [TestMethod()]
        public void IsZeroAPalindromeTest()
        {
            Assert.IsTrue( ExerciseSixHelpers.IsAPalindrome( 0 ) );
        }

        /// <summary>
        /// Test If A 2digit Palindrome Number Passes
        /// </summary>
        [TestMethod()]
        public void DoesATwoDigitPalindromeNumberPassTest()
        {
            Assert.IsTrue( ExerciseSixHelpers.IsAPalindrome( 22 ) );
        }

        /// <summary>
        /// Test If A 3digit Palindrome Number Passes
        /// </summary>
        [TestMethod()]
        public void DoesAThreeDigitPalindromeNumberPassTest()
        {
            Assert.IsTrue( ExerciseSixHelpers.IsAPalindrome( 101 ) );
        }


        /// <summary>
        /// Test If A Two Digit Non Palindrome Fails
        /// </summary>
        [TestMethod()]
        public void DoesATwoDigitNonPalindromeNumberPassTest()
        {
            Assert.IsFalse( ExerciseSixHelpers.IsAPalindrome( 50 ) );
        }

        /// <summary>
        /// Test If A Three Digit Non Palindrome Fails
        /// </summary>
        [TestMethod()]
        public void DoesAThreeDigitNonPalindromeNumberPassTest()
        {
            Assert.IsFalse( ExerciseSixHelpers.IsAPalindrome( 506 ) );
        }
        #endregion
    }
}