﻿using System;
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
            Console.Read();
        }
    }
}
