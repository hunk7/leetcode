/* https://leetcode.com/problems/minimum-window-substring/ | Leetcode #76 - Minimum Window Substring */

public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return "";
        Dictionary<char, int> target = new();
        foreach (char c in t) {
            if (target.ContainsKey(c))
                target[c]++;
            else
                target[c] = 1;  
        }
        int required = target.Count, formed = 0, left = 0,minLength = int.MaxValue, startIndex = 0;
        Dictionary<char, int> window = new();
        for (int right = 0; right < s.Length; right++)
        {
            char rightChar = s[right];
            if (!window.ContainsKey(rightChar))
                window[rightChar] = 0;
            window[rightChar]++;
            if (target.ContainsKey(rightChar) && window[rightChar] == target[rightChar])
                formed++;
            while (left <= right && formed == required)
            {
                int windowLength = right - left + 1;
                if (windowLength < minLength)
                {
                    minLength = windowLength;
                    startIndex = left;
                }
                char leftChar = s[left];
                window[leftChar]--;
                if (target.ContainsKey(leftChar) &&  window[leftChar] < target[leftChar])
                {
                    formed--;
                }
                left++;
            }
        }
        return minLength == int.MaxValue ? "" : s.Substring(startIndex, minLength);
    }
}

// This is actually the same sliding window idea, but optimized by replacing Dictionary<char,int> with arrays (Span<int>). Running ms = 4

public class Solution {
public string MinWindow(string s, string t) {
    Span<int> window = stackalloc int[128];
    Span<int> need = stackalloc int[128];
    int required = 0;
    foreach (var c in t) {
        if (need[(int)c] == 0) required++;
        need[(int)c]++;
    }
    int i=0;
    int minLen = int.MaxValue, start = -1;
    int match = 0;
    for (int j=0; j<s.Length; j++)
    {
        var c = (int)s[j];
        window[c]++;

        if (need[c] == window[c]) match++;

        while (i <= j && match == required)
        {
            if ((j - i + 1) < minLen)
            {
                minLen = j - i + 1;
                start = i;
            }
            var idx = (int)s[i];
            if (need[idx] == window[idx]) match--;
            window[idx]--;
            i++;
        }
    }
    return start == -1 ? "" : s[start..(start+minLen)];
  }
}

/*
76. Minimum Window Substring

Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that
every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".

The testcases will be generated such that the answer is unique.

Example 1:

Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
Example 2:

Input: s = "a", t = "a"
Output: "a"
Explanation: The entire string s is the minimum window.
Example 3:

Input: s = "a", t = "aa"
Output: ""
Explanation: Both 'a's from t must be included in the window.
Since the largest window of s only has one 'a', return empty string.
 
Constraints:

m == s.length
n == t.length
1 <= m, n <= 105
s and t consist of uppercase and lowercase English letters.
 
Follow up: Could you find an algorithm that runs in O(m + n) time?

Interview Summary ~

I use a sliding window with two frequency dictionaries. The target dictionary stores the required character counts from t,
and the window dictionary stores counts in the current window. As I expand the right pointer, I update frequencies
and maintain a formed count representing how many unique characters meet their required frequency. Once formed == required,
the window is valid, so I shrink it from the left to find the smallest valid window. Since each character is processed at most twice,
the solution runs in O(m+n) time and O(k) space.

*/
