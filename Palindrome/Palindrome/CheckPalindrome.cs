using System;

namespace Palindrome
{
    public class CheckPalindrome
    {
        
        public bool palindrome(string str)
        {

            string s = str.ToLower();
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {


                //ignoring white spaces

                if (Char.IsPunctuation(s[i]) || s[i] == ' ')
                {
                    i++;
                }
                if (Char.IsPunctuation(str[j]) || s[j] == ' ')
                {
                    j--;
                }

                if (i > j)
                {
                    break;
                }

                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
