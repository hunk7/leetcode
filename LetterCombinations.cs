/* https://leetcode.com/problems/letter-combinations-of-a-phone-number/ | Leetcode #17 - Letter Combinations of a Phone Number */

public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
            return new List<string>();
        Dictionary<char, List<char>> map = new()
        {
            { '2', new List<char> { 'a', 'b', 'c' } },
            { '3', new List<char> { 'd', 'e', 'f' } },
            { '4', new List<char> { 'g', 'h', 'i' } },
            { '5', new List<char> { 'j', 'k', 'l' } },
            { '6', new List<char> { 'm', 'n', 'o' } },
            { '7', new List<char> { 'p', 'q', 'r', 's' } },
            { '8', new List<char> { 't', 'u', 'v' } },
            { '9', new List<char> { 'w', 'x', 'y', 'z' } }
        };
        List<string> res = new() { "" };
        for (int i = 0; i < digits.Length; i++)
        {
            List<char> letters = map[digits[i]];
            List<string> newCombinations = new();
            foreach (string existingCombination in res)
            {
                foreach (char letter in letters)
                    newCombinations.Add(existingCombination + letter);
            }
            res = newCombinations;  // Replace old combinations with newly expanded combinations.
        }
        return res;
    }
}

/*
17. Letter Combinations of a Phone Number

Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

+-----+-----+-----+
|  1  |  2  |  3  |
|     | abc | def |
+-----+-----+-----+
|  4  |  5  |  6  |
| ghi | jkl | mno |
+-----+-----+-----+
|  7  |  8  |  9  |
|pqrs | tuv |wxyz |
+-----+-----+-----+
|  *  |  0  |  #  |
+-----+-----+-----+

Example 1:

Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
Example 2:

Input: digits = "2"
Output: ["a","b","c"]
 
Constraints:

1 <= digits.length <= 4
digits[i] is a digit in the range ['2', '9'].

Interview Explanation ~

This problem can be solved by generating all possible combinations represented by the phone keypad. I use an iterative approach where I start with an empty string and process each digit
one by one. For every digit, I take all combinations built so far and append each possible letter mapped to the current digit, creating a new set of combinations.
This is essentially performing a Cartesian product of the letter sets for each digit. For example, for "23", the combinations from '2' (a,b,c) are expanded with the letters 
from '3' (d,e,f) to produce ad, ae, af, bd, be, bf, cd, ce, cf. The time complexity is proportional to the total number of combinations generated, which is O(4^N),
where N is the number of digits.

*/
