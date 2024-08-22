namespace LeetCodeSolutions.Strings;

/// <summary>
/// Runtime complexity: 0(n)
/// Space complexity: Sliding from the right - 0(1); Trim().Split().Last.Length 0(n)
/// Runtime: 58ms
/// Memory: 38.17 MB
/// Solution pattern: Sliding from the right or Trim().Split().Last.Length
/// Level: Easy
/// </summary>

public class LengthOfLastWord
{
    public int SolveBySlidingFromTheRight(string s)
    {
        if (s.Length is 1 && char.IsLetterOrDigit(s[0]))
        {
            return s.Length;
        }

        int lastWordLength = 0;
        int index = s.Length - 1;

        while (char.IsWhiteSpace(s[index]))
        {
            index--;
        }

        while (index >= 0 && char.IsLetterOrDigit(s[index]))
        {
            lastWordLength++;
            index--;
        }

        return lastWordLength;
    }
    
    public int SolveBySplitting(string s)
    {
        if (s.Length is 1 && char.IsLetterOrDigit(s[0]))
        {
            return s.Length;
        }

        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }

        return s.Trim().Split(' ').Last().Length;
    }
}