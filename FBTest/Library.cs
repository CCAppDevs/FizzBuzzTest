using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBTest
{
    public static class Library
    {
        public static string FizzBuzz(int num)
        {
            string result = "";

            if (num % 3 == 0)
            {
                result += "Mizz";
            }
            
            if (num % 5 == 0)
            {
                result += "Buzz";
            }

            if (result.Length == 0)
            {
                result = num.ToString();
            }
            
            return result;
        }
    }
}
