using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VariablesAndTypes
{
    internal class Strings
    {

        //Introduction to C# strings
        /*
        The string keyword is the representation of string type. The string keyword is an alias
        of System.String type. Therefore, the string and String are equivalent.

        To declare a string, we must write the type and the variable name.

        We can initialize adding a value inside double-quotes or simple using the method String.Empty
        what is equivalent to adding just the quotes:
            string message = String.Empty;
            string message = "";

        The string type has some useful methods, like Lenght which gives the lenght of the string.

        We can concatenate strings adding the + operator:
            string fullName = "Pedro" + "Alcantara";

        We can added in any time with the asignment operator:
            string fullName = "Pedro";
            fullName += "Alcantara";

        Remember that strings are inmutable, that means that any change we apply to it, it creates a new
        string.
        */


        //Accesing to a index of a string text
        /*
         To access to a part of a string, we can use square brackets and look for the position of the char
        we are looking:
            string name = "Pedro";
            Console.WriteLine(name[0]); This will output "P", because index of strings starts from 0.

        We can replace a cartain character accesing to the index we want to change a asigning a new value:
            string model = "Ford Mustang";
            model[0] = 'B'; It output "Bord Mustang"
         */


        //Escape sequences
        /*
         Scape sequences are strings that contains special characters like tabs, newlines... using backslash (\).

        We can avoid this by adding an extra backslash:
            string message = "\"C# is a good language\", Pedro said";

        With paths (C:\\Users) we can do the same, but sometimes the code can be unreadable. A better way is using
        Verbatim string, which works as adding a @ at the begining of the initializing or asignment.
            string path = @"C:/Users";

        It disables escapes characters.

        This works too to preserve newlines characters as part of a string text.
         */


        //Interpolated string
        /*
        They are string variables inside other string variables.
            string name = "Pedro";
            string message = $"The name of the student is {name}";
         */


        //UTF-8 Strings
        /*
        The web uses UTF-8 as the character encoding. Each character takes 1 to 4 bytes.

        But in .NET, the string uses UTF-16 by default. It means each character takes at least 2
        bytes in size.

        If we are gonna use C# to process characters for the web, we need to convert UTF-16 to UTF-8.

        Note that if we use ASP.NET, it does automatically for us.

        We can use the Encoding.UTF8 to convert it, but it overhead and low down the program.
            var utf8 = Encoding.UTF8.GetBytes("Hello WWW");

        C# 11 introduced a concept of UTF-8 string. A UTF-8 string has a suffix of "u8" like this:
            var utf8 = "Hello WWW"u8;
        */
    }
}
