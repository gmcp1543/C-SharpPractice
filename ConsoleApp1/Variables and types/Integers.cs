using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Integers : ITestClass
    {
        //Introduction to C# Integers
        /*
        Integers are whole numbers like -2, -1, 0, 1, and 2. C# use integral numeric types
        to represent integer numbers.

        Beside int type, C# has other integers types with their specific keyword, size and range.

        sbyte: -128 to 127 » Signed 8-bit integer
        byte: 0 to 255 » Unsigned 8-bit integer
        short: -32,768 to 32,767 » Signed 16-bit integer
        ushort: 0 to 65,535 » Unsigned 16-bit integer
        int: -2,147,483,648 to 2,147,483,647 » Signed 32-bit integer
        uint: 0 to 4,294,967,295 » Unsigned 32-bit integer
        long: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 » Signed 64-bit integer
        ulong: 0 to 18,446,744,073,709,551,615 » Unsigned 64-bit integer

        C# also has other two integer types nint and nunit whose ranges depend on the specific plataform.

        Integer literals can be decimal, hexadecimal and binary.

        A decimal number can be write:
        int quantity = 10;
        int amount = 5;

        A hexadecimal number starts with 0x or 0X prefix:
        int address = 0x5A;

        A binary number starts with 0b or 0B prefix:
        int flag = 0b10011110;

        Also, the binary number can be separated with underscores:
        int flag = 0b_1001_1110;
         */



        public void Test()
        {

            sbyte sbyteExample = 126; //Values major than 126 will issues a error
            byte byteExample = 45; //Values less than 0 or greater than 255 will issue a error
            short shortExample = 31_458;
            ushort ushortExample = 45_245;
            int intExample = 2_140_265;
            uint uintExample = 4_145_621;
            long longExample = 8_243_415;
            ulong ulongExample = 17_631_451;

            Console.WriteLine($"sbyte: {sbyteExample}");
            Console.WriteLine($"byte: {byteExample}");
            Console.WriteLine($"short: {shortExample}");
            Console.WriteLine($"ushort: {ushortExample}");
            Console.WriteLine($"int: {intExample}");
            Console.WriteLine($"uint: {uintExample}");
            Console.WriteLine($"long: {longExample}");
            Console.WriteLine($"ulong: {ulongExample}");
        }
    }
}
