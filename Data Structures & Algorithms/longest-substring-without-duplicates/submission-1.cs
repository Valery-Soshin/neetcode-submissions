public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0)
        {
            return 0;
        }
        
        if (s.Length == 1)
        {
            return 1;
        }

        var maxLength = 0;

        for (int left = 0; left < s.Length; left++)
        {
            var chars = new HashSet<char>();

            for (int right = left; right < s.Length; right++)
            {
                if (chars.Contains(s[right]))
                {
                    maxLength = Math.Max(chars.Count, maxLength);
                    break;
                }
                else
                {
                    chars.Add(s[right]);
                    maxLength = Math.Max(chars.Count, maxLength);
                }
            }
        }

        return maxLength;
    }
}
