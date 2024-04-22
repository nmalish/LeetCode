using System.Text.RegularExpressions;

namespace LC._125.ValidPalindrome;

public class Solution
{
    public bool IsPalindrome(string str)
    {
        var rgx = new Regex("[^a-z0-9]");
        str = str.ToLower();
        str = rgx.Replace(str, "");

        var len = str.Length;
        for (var i = 0; i < len; i++)
        {
            if (str[i] != str[len - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
    
    // Other solution from LC
    public bool IsPalindrome1(string s)
    {    
        var clean = s.ToLower().Where(char.IsLetterOrDigit);
        return clean.Reverse().SequenceEqual(clean);
    }
    
    
    public bool IsPalindrome2(string s) 
    {
        for (int i = 0, j = s.Length - 1 ; j > i ; )
        {
            if ( !char.IsLetterOrDigit(s[i]) )
            {
                i++;
                continue;
            }

            if ( !char.IsLetterOrDigit(s[j]) )
            {
                j--;
                continue;
            }

            if ( char.ToLower(s[i++]) != char.ToLower(s[j--]) )
            {
                return false;
            }
        }
        return true;
    }
}