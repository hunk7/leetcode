/* https://leetcode.com/problems/longest-palindromic-substring/  |  LeetCode #5 - Longest Palindromic Substring */

public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";
        int start = 0;
        int maxLen = 1;
        for (int i = 0; i < s.Length; i++)
        {
            // Odd length palindrome
            Expand(s, i, i, ref start, ref maxLen);
            // Even length palindrome
            Expand(s, i, i + 1, ref start, ref maxLen);
        }
        return s.Substring(start, maxLen);
    }
    private void Expand(string s, int left,  int right,  ref int start,  ref int maxLen)
    {
        while (left >= 0 &&  right < s.Length && s[left] == s[right])
        {
            int currentLen = right - left + 1;
            if (currentLen > maxLen)
            {
                start = left;
                maxLen = currentLen;
            }
            left--;
            right++;
        }
    }
}

/*

5. Longest Palindromic Substring

Given a string s, return the longest palindromic substring in s.

Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"

Constraints:

1 <= s.length <= 1000
s consist of only digits and English letters.

Interview Answer (30 Seconds)

"I used the Expand Around Center approach. A palindrome always has a center,
which can be either a single character for odd-length palindromes or between two characters for even-length palindromes. For every index,
I expand outward from both possible centers while the characters match and keep track of the longest palindrome found. 
Since there are O(n) centers and each expansion can take O(n) time in the worst case, the overall time complexity is O(n²) with O(1) extra space.

*/
