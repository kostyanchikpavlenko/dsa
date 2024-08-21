namespace LeetCodeSolutions.Arrays;

/// <summary>
/// Runtime complexity: 0(n)
/// Space complexity: 0(1)
/// Runtime: 55ms
/// Memory: 41.99 MB
/// Solution pattern: Dictionary or Array
/// Level: Easy
/// </summary>

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }

        int[] freq = new int[26];

        for (int i = 0; i < s.Length; i++)
        {

            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;
        }

        return freq.All(x => x == 0);
    
    }
}