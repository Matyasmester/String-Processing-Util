using System;
using System.Collections.Generic;
using System.Linq;

namespace StringUtil
{
    /// <summary>
    ///     Provides the basic functions to process strings.
    /// </summary>
    static class StringProcessingUtil
    {

        public static readonly int SPACE = 32;

        public static int Len(string val)
        ///<summary>
        ///   Returns the length of the string.
        ///</summary>
        {
            int counter = 0;
            foreach (byte b in val)
            {
                counter++;
            }
            return counter;
        }

        public static bool HasUpperCase(string val)
        ///<summary>
        ///   Determines whether the string contains uppercase letters.
        ///</summary>
        {
            foreach (char c in val)
            {
                HasUpperCase(c);
            }
            return false;
        }

        public static bool HasUpperCase(char c)
        {
            int ascii = Convert.ToInt32(c);
            return (ascii >= 65 && ascii <= 90);
        }

        public static bool HasNumbers(string val)
        ///<summary>
        ///   Determines whether the string contains numbers.
        ///</summary>
        {
            foreach (char c in val)
            {
                int ascii = Convert.ToInt32(c);
                if (ascii >= 48 && ascii <= 57)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasSpecialChars(string val)
        ///<summary>
        ///   Determines whether the string contains special characters.
        ///</summary>
        {
            foreach (char c in val)
            {
                int ascii = Convert.ToInt32(c);
                if ((ascii >= SPACE && ascii <= 47) || (ascii >= 58 && ascii <= 64) || (ascii >= 91 && ascii <= 96) || (ascii >= 123 && ascii <= 126))
                {
                    return true;
                }
            }
            return false;
        }

        public static int CountUpperCase(string val)
        ///<summary>
        ///   Returns the number of uppercase characters in the string.
        ///</summary>
        {
            // this is equivalent:
            // int count = val.ToCharArray().Count(c => HasUpperCase(c.ToString()));
            int counter = 0;
            foreach (char c in val)
            {
                if (HasUpperCase(c))
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int CountAny(string val, Func<char, bool> predicate)
        {
            return val.ToCharArray().Count(predicate);
        }

        public static int CountNumbers(string val)
        ///<summary>
        ///   Returns the number of numbers in the string.
        ///</summary>
        {
            return CountAny(val, (c) => HasNumbers(c.ToString()));
        }

        public static int CountSpecialChars(string val)
        ///<summary>
        ///   Returns the number of special characters in the string.
        ///</summary>
        {
            return CountAny(val, (c) => HasSpecialChars(c.ToString()));
        }

        public static char GetRandomChar(string s)
        ///<summary>
        ///   Returns a random character from the entire string.
        ///</summary>
        {
            Random rand = new Random();
            int rnd = rand.Next(0, Len(s));
            int index = 0;
            foreach (char c in s)
            {
                if (index == rnd)
                {
                    return c;
                }
                index++;
            }
            return 'F';
        }

        public static char GetRandomChar(string s, int startIndex)
        ///<summary>
        ///   Returns a random character from the string,
        ///   starting at the specified start-index, and
        ///   going to the end.
        ///</summary>
        {
            Random rand = new Random();
            int rnd = rand.Next(startIndex, Len(s));
            int index = 0;
            foreach (char c in s)
            {
                if (index == rnd)
                {
                    return c;
                }
                index++;
            }
            return 'F';
        }

        public static char GetRandomChar(string s, int startIndex, int endIndex)
        ///<summary>
        ///   Returns a random character from the string, starting at
        ///   the specified start-index, and ending at the specified
        ///   end-index.
        ///</summary>
        {
            Random rand = new Random();
            int rnd = rand.Next(startIndex, endIndex);
            if (rnd < 0 || rnd > s.Length)
            {
                Console.Error.WriteLine("Nel egyékl már fastz!");
                throw new PEBCACException("Túl nagy az index te majom!");
            }
            return s.ToCharArray()[rnd];
        }

        public static string GenerateRandom(int strLen)
        {
            ///<summary>
            ///   Returns a fully random string, with the specified length.
            ///</summary>
            Random rand = new Random();
            string generated = "";
            for (int i = 0; i < strLen; i++)
            {
                int rnd = rand.Next(33, 126);
                generated += Convert.ToChar(rnd);
            }
            return generated;
        }

        public static string GenerateRandom(int strLen, int minAscii, int maxAscii)
        {
            ///<summary>
            ///   Returns a random string, with the specified length, and
            ///   between the specified prefix of ASCII values.
            ///</summary>
            Random rand = new Random();
            string generated = "";
            for (int i = 0; i < strLen; i++)
            {
                int rnd = rand.Next(minAscii, maxAscii);
                generated += Convert.ToChar(rnd);
            }
            return generated;
        }
    }
}
