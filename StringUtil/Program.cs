using System;
using static StringUtil.StringProcessingUtil;

namespace StringUtil
{
    class Program
    {
        static void Main()
        {
            string Str = "AsdAsdAsdY/%!+%01";
            Console.WriteLine("Length: {0}", Len(Str));
            Console.WriteLine("Has numbers: {0}", HasNumbers(Str));
            Console.WriteLine("Has uppercase: {0}", HasUpperCase(Str));
            Console.WriteLine("Has special characters: {0}", HasSpecialChars(Str));
            Console.WriteLine("Uppercase count: {0}", CountUpperCase(Str));
            Console.WriteLine("Number count: {0}", CountNumbers(Str));
            Console.WriteLine("Special character count: {0}", CountSpecialChars(Str));
            Console.WriteLine("Random char from string: {0}", GetRandomChar(Str));
            Console.WriteLine("Random char from string (Overload 1): {0}", GetRandomChar(Str, 15));
            Console.WriteLine("Random char from string (Overload 2): {0}", GetRandomChar(Str, 0, 3));
            Console.WriteLine("Random string with 10 length: {0}", GenerateRandom(10));
            Console.WriteLine("Random string with 10 length and ASCII values between 50 and 100: {0}", GenerateRandom(10, 50, 100));
            Console.Read();
        }
    }
}
