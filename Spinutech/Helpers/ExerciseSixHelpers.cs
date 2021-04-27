using System;
using System.Linq;

namespace Spinutech.Helpers
{
    public class ExerciseSixHelpers
    {
        /// <summary>
        /// This will make sure that the user cannot pass in a negative number to the palindrome calculation
        /// </summary>
        /// <param name="Number"> The input that comes from the user </param>
        /// <returns> True - if the input is a positive number </returns>
        /// <returns> False - if the input is a NOT positive number </returns>
        public static bool IsAPositiveNumber( int Number )
        {
            return Number >= 0;
        }

        /// <summary>
        /// This is the base method to calculate if the integer passed in is a palindrome
        /// </summary>
        /// <param name="Number"> The input that comes from the user </param>
        /// <returns> True - if the input is a palindrome </returns>
        /// <returns> False - if the input is a NOT a palindrome </returns>
        public static bool IsAPalindrome( int Number )
        {
            return CalculateIfValueIsAPalindrome( Number ); ;
        }

        /// <summary>
        /// Compares the string version of the integer with the reverse string value of the integer to see if they match
        /// </summary>
        /// <param name="Number"> The input that comes from the user </param>
        /// <returns> True - if the string version of the input MATCHES the reverse string value of the input </returns>
        /// <returns> False - if the string version of the input DOES NOT MATCH the reverse string value of the input </returns>
        private static bool  CalculateIfValueIsAPalindrome( int Number )
        {
            // -- Converts the passed in integer to a string
            string NumberAsAString = ConvertValueToAString( Number );

            return NumberAsAString.SequenceEqual( NumberAsAString.Reverse() );
        }

        /// <summary>
        /// Converts the passed in integer to a string. 
        /// </summary>
        /// <param name="Number"> The input that comes from the user </param>
        /// <returns> the string value of the passed in integer </returns>
        private static string ConvertValueToAString( int Number )
        {
            return Number.ToString();
        }
    }
}
