namespace LeetCodeSolutions.Strings;

/// <summary>
/// Runtime complexity: 0(n)
/// Space complexity: 0(n)
/// Runtime: 60ms
/// Memory: 39.56 MB
/// Solution pattern: Dictionary
/// Level: Easy
/// </summary>
public class ValidParentheses
{
    public bool IsValid(string s) {

        if(s.Length % 2 != 0)
        {
            return false;
        }

        var bracketsMap = new Dictionary<char, char>
        {
            {')','('},
            {'}','{'},
            {']','['}
        };

        var stack = new Stack<char>();

        for(int i = 0; i < s.Length; i++)
        {
            char currentValue = s[i];

            if(bracketsMap.ContainsValue(currentValue))
            {
                stack.Push(currentValue);
            }

            if(bracketsMap.ContainsKey(currentValue) 
               && 
               (stack.Count == 0 || stack.Pop() != bracketsMap[currentValue]))
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}