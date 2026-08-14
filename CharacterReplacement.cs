/* https://leetcode.com/problems/longest-repeating-character-replacement/  |  Leetcode #424 - Longest Repeating Character Replacement */

public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int left = 0, maxFreq = 0, result = 0;
        int[] ArrayCharCount = new int[26];
        for (int right = 0; right < s.Length; right++)
        {
            ArrayCharCount[s[right] - 'A']++;
            maxFreq = Math.Max(maxFreq, ArrayCharCount[s[right] - 'A']);
            while ((right - left + 1) - maxFreq > k)
            {
                ArrayCharCount[s[left] - 'A']--;
                left++;
            }
            result = Math.Max(result, right - left + 1);
        }
        return result;
    }
}

/*
424. Longest Repeating Character Replacement

You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.

Return the length of the longest substring containing the same letter you can get after performing the above operations.

Example 1:

Input: s = "ABAB", k = 2
Output: 4
Explanation: Replace the two 'A's with two 'B's or vice versa.
Example 2:

Input: s = "AABABBA", k = 1
Output: 4
Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
The substring "BBBB" has the longest repeating letters, which is 4.
There may exists other ways to achieve this answer too.
 
Constraints:

1 <= s.length <= 105
s consists of only uppercase English letters.
0 <= k <= s.length

Interview Explanation ~

We use a sliding window and maintain the frequency of characters inside the current window.
The largest character frequency in the window is maxFreq. If windowSize - maxFreq becomes greater than k, 
it means we need more than k replacements, so we shrink the window. Otherwise, the window is valid and we update the answer.
Since each character is processed at most twice, the solution runs in O(n) time and O(1) space.

*/
