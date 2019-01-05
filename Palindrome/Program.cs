using System;
using System.Linq;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter something to check to see if it a Palendrome");

            var inputArray = Console.ReadLine();

            inputArray.Replace(" ", "");

            var charArray = inputArray.Reverse();

            var PArray = string.Join("", charArray);

            if ( PArray == inputArray)
            {
                Console.WriteLine("PALENDROME");
            }
            else
            {
                Console.WriteLine("not");
            }




            Console.ReadLine();
        }
    }
}
