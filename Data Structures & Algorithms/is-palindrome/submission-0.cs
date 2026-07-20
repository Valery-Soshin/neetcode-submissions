public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;

        while (left < right) {
            var leftChar = char.ToLower(s[left]);
            var rightChar = char.ToLower(s[right]);

            if (!IsValidASCIIChar(leftChar)) {
                left++;
            } else if (!IsValidASCIIChar(rightChar)) {
                right--;
            } else if (leftChar != rightChar) {
                return false;
            } else {
                left++;
                right--;
            }
        }

        return true;
    }

    static bool IsValidASCIIChar(char symbol) {
        return char.IsAsciiLetterOrDigit(symbol);
    }
}
