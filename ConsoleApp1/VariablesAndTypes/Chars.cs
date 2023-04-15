using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VariablesAndTypes
{
    internal class Chars : ITestClass
    {

        //Introduction to C# char type
        /*
         C# uses the char type to represent characters. A variable of type char can hold
        a single character.

        C# provides three ways to represent a character literal:
            - A character literal
            - A Unicode escape sequence
            - A hexadecimal espace sequence

        All three character literals are surrounded by single-quotes
         */

        char charLiteral = 'a';//This is a character literal
        char charUnicode = '\u002B'; //A Unicode character starts from \u followed by four-symbol hexadecimal representation of the character
        char charHexadecimal = '\x002C'; //A hexadecimal character starts from \x and the representation of the character code

        public void Test()
        {
            //A character support comparison, equality, increment and decrement
            char c1 = 'a',
                c2 = 'a';

            bool result = c1 == c2;

            Console.WriteLine($"{result} is the result of comparing {nameof(c1)} and {nameof(c2)} by equality");


            result = c1 < c2; //We can also compare the greater character
            Console.WriteLine($"{result} is the result of comparing {nameof(c1)} and {nameof(c2)} greater");
        }

    }
}
