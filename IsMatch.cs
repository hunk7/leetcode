/* https://leetcode.com/problems/regular-expression-matching/ | Leetcode #10 - Regular Expression Matching */

public class Solution {
    public bool IsMatch(string s, string p) {
        // Base case: if pattern is empty, string must also be empty
        if (string.IsNullOrEmpty(p)) {
            return string.IsNullOrEmpty(s);
        }

        // Check if the first characters match
        bool isFirstMatch = !string.IsNullOrEmpty(s) && (p[0] == s[0] || p[0] == '.');

        // Check if the second character in the pattern is a '*'
        bool hasAsteriskNext = p.Length >= 2 && p[1] == '*';

        if (hasAsteriskNext) {
            // Option A: Skip the '*' pattern entirely (match 0 occurrences)
            // Option B: If the first char matches, consume 1 character from 's' and keep the pattern
            return IsMatch(s, p.Substring(2)) || (isFirstMatch && IsMatch(s.Substring(1), p));
        } 
        else {
            // Normal match: current chars must match, and the rest of the strings must match too
            return isFirstMatch && IsMatch(s.Substring(1), p.Substring(1));
        }
    }
}

/*
10. Regular Expression Matching
Hard
Topics
premium lock icon
Companies
Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:

'.' Matches any single character.​​​​
'*' Matches zero or more of the preceding element.
Return a boolean indicating whether the matching covers the entire input string (not partial).

 

Example 1:

Input: s = "aa", p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".
Example 2:

Input: s = "aa", p = "a*"
Output: true
Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
Example 3:

Input: s = "ab", p = ".*"
Output: true
Explanation: ".*" means "zero or more (*) of any character (.)".
 

Constraints:

1 <= s.length <= 20
1 <= p.length <= 20
s contains only lowercase English letters.
p contains only lowercase English letters, '.', and '*'.
It is guaranteed for each appearance of the character '*', there will be a previous valid character to match.

*/
