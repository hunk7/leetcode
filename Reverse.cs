/* https://leetcode.com/problems/reverse-integer/  |  LeetCode #7 - Reverse Integer */

public class Solution {
    public int Reverse(int x) {
        int rev = 0;
        while (x != 0) {
            int pop = x % 10;
            x /= 10;
            if (rev > int.MaxValue / 10 ||
                (rev == int.MaxValue / 10 && pop > 7))
                return 0;
            if (rev < int.MinValue / 10 ||
                (rev == int.MinValue / 10 && pop < -8))
                return 0;
            rev = rev * 10 + pop;
        }

        return rev;
    }
}

/*
7. Reverse Integer

Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

Example 1:

Input: x = 123
Output: 321
Example 2:

Input: x = -123
Output: -321
Example 3:

Input: x = 120
Output: 21

Constraints:

-231 <= x <= 231 - 1

Interview One-Liner ~

"I extract digits from right to left using % 10, build the reversed number using rev = rev * 10 + digit,
and perform overflow/underflow checks before every append operation so that I stay within the 32-bit integer range
without using a 64-bit datatype."

*/
