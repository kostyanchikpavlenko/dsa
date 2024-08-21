using System.Text;

namespace LeetCodeSolutions.Strings;

public class IsPalindrom
{
   public bool SolveByStack(string input) {
    
        if(string.IsNullOrWhiteSpace(input))
        {
            return true;
        }
    
        var builder = new StringBuilder();

        foreach (var c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                builder.Append(char.ToLower(c));
            }
        }

        var palindrome = builder.ToString();

        if (palindrome.Length is 0 or 1)
        {
            return true;
        }

        int mid = palindrome.Length / 2;
        string leftPart = palindrome.Substring(0, mid);
        string rightPart = palindrome.Substring(palindrome.Length % 2 != 0 ? mid + 1 : mid);

        var stack = new Stack<char>();
    
        for (int i = 0; i < leftPart.Length; i++)
        {
            stack.Push(leftPart[i]);
        }

        for (int i = 0; i < rightPart.Length; i++)
        {
            if (stack.Pop() != rightPart[i])
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
   
    public bool SolveByTwoPointers(string input) 
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return true;
        }

        var builder = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                builder.Append(char.ToLower(c));
            }
        }

        string palindrom = builder.ToString();

        if (palindrom.Length is 0 or 1)
        {
            return true;
        }

        int left = 0;
        int right = palindrom.Length - 1;
   
        while (left < right)
        {
            if (palindrom[left] != palindrom[right])
            {
                return false;
            }

            left++;
            right--;
        }
    
        return true;
    }
}