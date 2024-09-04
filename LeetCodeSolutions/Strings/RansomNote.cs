namespace LeetCodeSolutions.Strings;

public class RansomNote
{
    public bool CanConstructByArray(string ransomNote, string magazine)
    {
        int[] count = new int[26];

        foreach (var c in magazine)
        {
            count[c - 'a']++;
        }

        foreach (var c in ransomNote)
        {
            count[c - 'a']--;

            if (count[c - 'a'] == -1)
            {
                return false;
            }
        }

        return true;
    }
    
    public bool CanConstructByDictionary(string ransomNote, string magazine)
    {
        Dictionary<char, int> countMap = new Dictionary<char, int>();

        foreach (var c in magazine)
        {
            if (countMap.ContainsKey(c))
            {
                countMap[c]++;
            }
            else
            {
                countMap[c] = 1;
            }
        }

        foreach (var c in ransomNote)
        {
            if (!countMap.ContainsKey(c) || countMap[c] == 0)
            {
                return false;
            }

            countMap[c]--;
        }

        return true;
    }
}