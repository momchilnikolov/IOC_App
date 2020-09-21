using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC_App.Domain.Interfaces
{
    public interface Palindrome
    {
        public bool IsPalindrome(string input);
        public string ReverseString(string input);
        public string Palindromize(string input);
        
    }
}
