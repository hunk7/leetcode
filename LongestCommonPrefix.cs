/* https://leetcode.com/problems/longest-common-prefix/  |  Leetcode #14 - Longest Common Prefix */

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";
        for (int i = 0; i < strs[0].Length; i++)
        {
            char current = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length ||
                    strs[j][i] != current)
                {
                    return strs[0].Substring(0, i);
                }
            }
        }
        return strs[0];
    }
}

/*
14. Longest Common Prefix

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.

Interview Answer

The preferred solution is Horizontal Scanning because it avoids sorting and directly compares characters column by column
across all strings, achieving O(N × M) time and O(1) space.

*/
