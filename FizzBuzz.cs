using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge
{
    public static class FizzBuzz

    {
        public static string FizzOrBuzz(int a)
        {
            if (a % 3 == 0 && a % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (a % 5 == 0)
            {
                return "Buzz";
            }
                return "Fizz";
            
            
        }
    }
}
