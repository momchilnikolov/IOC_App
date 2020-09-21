using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOC_App.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IOC_App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IOCAppController : ControllerBase
    {

        private readonly Palindrome _palindromeService;

        public IOCAppController(Palindrome palindromeService)
        {
            _palindromeService = palindromeService;
        }
        [HttpGet]
        public IActionResult Get(string input)
        {
            return  Ok("You can do the following operations: \n\t Enter a query string value in the format IsPalindrome?input=mystring to see if string is a palindrome." +
               " \n\t Reverse?input=mystring to reverse a string." + "\n\t MakePalindrome?input=mystring to turn the string into a palindrome.");
        }

        [HttpGet]
        [Route("IsPalindrome")]
        public IActionResult IsPalindrome(string input)
        {
            var data = _palindromeService.IsPalindrome(input).ToString();
            return String.IsNullOrWhiteSpace(input) ? Ok("Please enter a query string value in the format IsPalindrome?input=mystring to see if we have a palindrome.") : Ok("String is Palindrome: " + data);
        }

        [HttpGet]
        [Route("Reverse")]
        public IActionResult Reverse(string input)
        {
            var data = _palindromeService.ReverseString(input).ToString();
            return String.IsNullOrWhiteSpace(input) ? Ok("Please enter a query string value in the format Reverse?input=mystring to reverse a string.") : Ok(data);
        }

        [HttpGet]
        [Route("MakePalindrome")]
        public IActionResult MakePalindrome(string input)
        {
            var data = _palindromeService.Palindromize(input).ToString();
            return String.IsNullOrWhiteSpace(input) ? Ok("Please enter a query string value in the format MakePalindrome?input=mystring to turn a string into a palindrome.") : Ok(data);
        }
    }
}
