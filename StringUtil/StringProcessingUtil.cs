using System;

namespace StringUtil
{
    /// <summary>
    ///     Provides the basic functions to process strings.
    /// </summary>
    static class StringProcessingUtil
    {
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
                int ascii = Convert.ToInt32(c);
                if (ascii >= 65 && ascii <= 90)
                {
                    return true;
                }
            }
            return false;
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
                if ((ascii >= 32 && ascii <= 47) || (ascii >= 58 && ascii <=64) || (ascii >= 91 && ascii <= 96) || (ascii >= 123 && ascii <= 126))
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
            int counter = 0;
            foreach (char c in val)
            {
                if (HasUpperCase(c.ToString()))
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int CountNumbers(string val)
        ///<summary>
        ///   Returns the number of numbers in the string.
        ///</summary>
        {
            int counter = 0;
            foreach (char c in val)
            {
                if (HasNumbers(c.ToString()))
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int CountSpecialChars(string val)
        ///<summary>
        ///   Returns the number of special characters in the string.
        ///</summary>
        {
            int counter = 0;
            foreach (char c in val)
            {
                if (HasSpecialChars(c.ToString()))
                {
                    counter++;
                }
            }
            return counter;
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
        {
            ///<summary>
            ///   Returns a random character from the string,
            ///   starting at the specified start-index, and
            ///   going to the end.
            ///</summary>
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
        {
            ///<summary>
            ///   Returns a random character from the string, starting at
            ///   the specified start-index, and ending at the specified
            ///   end-index.
            ///</summary>
            Random rand = new Random();
            int rnd = rand.Next(startIndex, endIndex);
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
    }
}
