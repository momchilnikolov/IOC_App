using IOC_App.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC_App.Services
{
    public class PalindromeService: Palindrome
    {
        public string ReverseString(string input)
        {

            //base case to handle one char string and empty string
            if (input.Length < 2)
                return input;

            return ReverseString(input.Substring(1)) + input.ElementAt(0);
        }
        public string Palindromize(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return string.Empty;
            return input + ReverseString(input).Substring(1);
        }
        public bool IsPalindrome(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return false;
            for(int i = 0; i <= input.Length/2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
