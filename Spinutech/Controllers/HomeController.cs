using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Spinutech.Helpers;
using Spinutech.Models;

namespace Spinutech.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController( ILogger<HomeController> logger )
        {
            _logger = logger;
        }

        /// <summary>
        /// Get Method For The Index View
        /// </summary>
        /// <param name="status"> Will contain the results if we have ran the palindrome calculations</param>
        /// <returns> The Index View </returns>
        public IActionResult Index( string status = "" )
        {
            // -- ViewBag to hold the results from the palidrome calculations
            ViewBag.StatusMessage = status;

            return View();
        }

        /// <summary>
        /// Post Method that will run the palindrome calculations
        /// </summary>
        /// <param name="eSix"> Model used on the input page</param>
        /// <returns> Passed Test - if the inputted value was a palindrome </returns>
        /// <returns> Failed Test - if the inputted value was NOT a palindrome </returns>
        /// <returns> Displays Error - if the inputted value was NOT a positive integer </returns>
        [HttpPost]
        public IActionResult Calculate( ExerciseSix eSix )
        {
            // -- Makes sure we have an integer and the integer is positive
            if ( ModelState.IsValid && ExerciseSixHelpers.IsAPositiveNumber( eSix.Number ) )
            {
                // -- Holds the response from the palindrome calculations
                string validationMessage = ExerciseSixHelpers.IsAPalindrome( eSix.Number ) ? $"Passed Test - { eSix.Number } Is A Palindrome" : $"Failed Test - { eSix.Number } Is Not A Palindrome";

                // -- Returns to the index page with the palindrome calculation results
                return RedirectToAction( "Index", new { status = validationMessage } ); 
            }

            // -- If we failed input validation we want to display a better error for the user rather than the default invalid input
            ReplaceDefaultErrorMessage();

            // -- return to the inputted page with the error.
            return View( "Index" );

        }

        /// <summary>
        /// Just replacing the default display error with a more descriptive error
        /// </summary>
        private void ReplaceDefaultErrorMessage()
        {
            ModelState.Remove( "Number" );
            ModelState.AddModelError( "Number", "Please Enter A Positive Integer." );
        }
    }
}
