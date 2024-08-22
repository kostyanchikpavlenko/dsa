namespace LeetCodeSolutions.Strings;

/// <summary>
/// Runtime complexity: 0(n)
/// Space complexity: 0(1)
/// Runtime: 58ms
/// Memory: 38.17 MB
/// Solution pattern: Sliding from the right
/// Level: Easy
/// </summary>

public class LengthOfLastWord
{
    public int Solve(string s)
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
}