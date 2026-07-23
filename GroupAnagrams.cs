/*  https://leetcode.com/problems/group-anagrams/  |  Leetcode #49 - Group Anagrams */

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = new();
        foreach (string word in strs)
        {
            int[] count = new int[26];
            foreach (char c in word)
            {
                count[c - 'a']++;
            }
            string key = string.Join("#", count);
            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(word);
        }
        return map.Values.Cast<IList<string>>().ToList();
    }
}

/*
49. Group Anagrams

Given an array of strings strs, group the anagrams together. You can return the answer in any order.

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]

Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Explanation:

There is no string in strs that can be rearranged to form "bat".
The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
Example 2:

Input: strs = [""]

Output: [[""]]

Example 3:

Input: strs = ["a"]

Output: [["a"]]

Constraints:

1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lowercase English letters.

Interview Answer

The sorting approach is accepted and easy to explain with O(n × k log k) time complexity.
For an optimal solution, use a character frequency count as the HashMap key,
reducing the complexity to O(n × k) because we avoid sorting every string.

*/
