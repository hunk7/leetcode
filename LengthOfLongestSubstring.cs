/* https://leetcode.com/problems/longest-substring-without-repeating-characters/  LeetCode #3 Longest Substring Without Repeating Characters */

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> window = new(s.Length);
        int left = 0;
        int maxLength = 0;
        for (int right = 0; right < s.Length; right++)
        {
            while (window.Contains(s[right]))
            {
                window.Remove(s[left]);
                left++;
            }
            window.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}

/*
3. Longest Substring Without Repeating Characters

Given a string s, find the length of the longest substring without duplicate characters.

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
*/
