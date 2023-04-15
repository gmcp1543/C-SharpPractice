using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Variables_and_types
{
    internal class Variables : ITestClass
    {

        //Introduction to C# variables
        /*
         Programs process data. Typically, they work as follow:

        1 - First, get data from user inputs, files, or third-party API
        2- Second, process the data
        3- Third, output the result to the screen or save it to data storage as file o database

        To store data during execution, we use variables
         */


        //Declare variables
        /*
         A variable can be created by adding: "type variableName"

        In this syntax:
            - The type can be any C# built-in type or custom type. For example, int built-in type
                represents the integers, and the string built-in type represents the text strings.
            - The variableName is a valid identifier that starts with a character or underscore (_)
                and is followed by other characters.

        Those are some commons built-in variables types:
            - int: Integers, like 1, 2 or 3.
            - float: Single-precision floating-point numbers like 1.1F
            - double: Double-precision floating-point numbers like 2.5
            - string: Text strings like "Hi"
            - char: Characters like 'a', 'b' and 'c'
            - bool: Booleans values like True or False

        Variables must start with a letter, like "color", "textColor", ect.

        When creating a variable, if we don't assign a value or instantiated, the compile will issue a error.

        C# is a type-safe language, that means we cannot change the type of a variable.
         */


        //Display variables
        /*
        To display a variable, we can use Console.WriteLine() method. To do it correctly, we must start with a 
        dollar sign ($) + double quotes. Inside them, we add the variable name with to curly braces "{}".

        string name = "Jhon";
        int age = 15;
        Console.WriteLine($"The age of {name} is {age}");
         */

        //Declare multiple variables
        /*
         We declare variables by adding statments:

        double weight = 60.5;
        double height = 1.72;

        Also, we can declare them in line:
        double weight = 60.5,
               height = 1.72;
         */

        //C# variable example
        public void Test()
        {
            //We are gonna calculate the body mass index
            double weight = 60.5;
            double height = 1.72;
            double bmi;

            bmi = weight / (height * height);

            Console.WriteLine("Calculate the Body Mass Index:");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"BMI: {bmi:0.#}");//"0.#" is a way to limits the decimals numbers are gonna be shown
        }
    }
}
