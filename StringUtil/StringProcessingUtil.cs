using System;

namespace StringUtil
{
    /// <summary>
    ///     Provides the basic functions to process strings.
    /// </summary>
    static class StringProcessingUtil
    {
        public static int Len(string val)
        {
            int counter = 0;
            foreach (byte b in val)
            {
                counter++;
            }
            return counter;
        }
        
        public static bool HasUpperCase(string val)
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
        {
            Random rand = new Random();
            int rnd = rand.Next(0, Len(s));
            int counter = 0;
            foreach (char c in s)
            {
                if (counter == rnd)
                {
                    return c;
                }
                counter++;
            }
            return 'F';
        }
    }
}
