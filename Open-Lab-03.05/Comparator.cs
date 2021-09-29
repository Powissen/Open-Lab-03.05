using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {
            if (string.Equals(str1, str2, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
