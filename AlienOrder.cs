/* https://leetcode.com/problems/alien-dictionary/ | Leetcode #269 - Alien Dictionary */

public class Solution 
{
    public string AlienOrder(string[] words) 
    {
        // 1. Initialize adjacency list and in-degree map for all unique characters
        Dictionary<char, HashSet<char>> adj = new Dictionary<char, HashSet<char>>();
        Dictionary<char, int> inDegree = new Dictionary<char, int>();

        foreach (string word in words) 
        {
            foreach (char c in word) 
            {
                if (!adj.ContainsKey(c)) 
                {
                    adj[c] = new HashSet<char>();
                    inDegree[c] = 0;
                }
            }
        }

        // 2. Build the dependency graph by comparing adjacent words
        for (int i = 0; i < words.Length - 1; i++) 
        {
            string word1 = words[i];
            string word2 = words[i + 1];
            int minLen = Math.Min(word1.Length, word2.Length);

            // Edge Case: Prefix violation (e.g., "apple" appears before "app")
            if (word1.Length > word2.Length && word1.StartsWith(word2)) 
            {
                return "";
            }

            // Find the first differing character
            for (int j = 0; j < minLen; j++) 
            {
                char c1 = word1[j];
                char c2 = word2[j];

                if (c1 != c2) 
                {
                    // Add directed edge c1 -> c2 if not already present
                    if (!adj[c1].Contains(c2)) 
                    {
                        adj[c1].Add(c2);
                        inDegree[c2]++;
                    }
                    // Only the first differing character determines the order
                    break;
                }
            }
        }

        // 3. Queue all characters with 0 in-degrees (no prerequisites)
        Queue<char> queue = new Queue<char>();
        foreach (var kvp in inDegree) 
        {
            if (kvp.Value == 0) 
            {
                queue.Enqueue(kvp.Key);
            }
        }

        // 4. Process the graph (Topological Sort)
        StringBuilder result = new StringBuilder();
        while (queue.Count > 0) 
        {
            char current = queue.Dequeue();
            result.Append(current);

            foreach (char neighbor in adj[current]) 
            {
                inDegree[neighbor]--;
                if (inDegree[neighbor] == 0) 
                {
                    queue.Enqueue(neighbor);
                }
            }
        }

        // 5. If result doesn't contain all unique letters, a cycle was detected
        if (result.Length < inDegree.Count) 
        {
            return "";
        }

        return result.ToString();
    }
}

/* Problem Description

There is a new alien language that uses the English alphabet. However, the order among the letters is unknown to you.
You are given a list of strings `words` from the alien language's dictionary, where the strings in `words` are **sorted lexicographically** by the rules of this new language.
Return *a string of the unique letters in the new alien language sorted in **lexicographically increasing order** by the new language's rules.* If there is no valid ordering of letters, return `""`. If there are multiple valid solutions, return *any of them*.

### Examples

**Example 1:**

* **Input:** `words = ["wrt","wrf","er","ett","rftt"]`
* **Output:** `"wertf"`

**Example 2:**

* **Input:** `words = ["z","x"]`
* **Output:** `"zx"`

**Example 3:**

* **Input:** `words = ["z","x","z"]`
* **Output:** `""`
* **Explanation:** The order is invalid because 'z' cannot come before 'x' and simultaneously after 'x', so return `""`.

Constraints

* `1 <= words.length <= 100`
* `1 <= words[i].length <= 100`
* `words[i]` consists of only lowercase English letters.

Complexity

* **Time Complexity:** $O(C)$, where $C$ is the total number of characters across all words in `words`.
* Finding all unique characters and validating prefixes takes $O(C)$ time.
* Building the graph requires inspecting characters in adjacent words up to the length of the shorter word, which is bounded by $O(C)$.
* The topological sort runs in $O(V + E)$ time. Since the alphabet is constrained to 26 lowercase English letters, $V \le 26$ and $E \le 26^2 = 676$, making the graph traversal step effectively $O(1)$.


* **Space Complexity:** $O(1)$ auxiliary space.
* The number of vertices $V$ is bounded by 26, and the maximum edges $E$ is bounded by 676.
* The adjacency map, in-degree dictionary, queue, and result string buffer hold at most 26 keys/characters each.

Actual Breakdown Explanation ~

To derive the answer `"wertf"`, we must deduce the alien alphabet's rules by looking at the input array as a strictly sorted dictionary. We only learn the relative order of characters by comparing **adjacent words** and finding the **first character that differs** between them.

Here is the exact step-by-step breakdown for `words = ["wrt", "wrf", "er", "ett", "rftt"]`.

### 1. Identify All Unique Characters (The Nodes)

First, we look at all the letters used in the array to know which characters exist in this alien alphabet.

* **Unique characters:** `w`, `r`, `t`, `f`, `e` (5 characters in total).

### 2. Compare Adjacent Words (Building the Edges)

We compare each word with the word immediately after it. We read left-to-right and stop at the *first* mismatch. That mismatch tells us which letter comes first.

* **Compare "wrt" and "wrf"**
* `w` matches `w`
* `r` matches `r`
* `t` differs from `f`. Because "wrt" comes first in the dictionary, **`t` comes before `f**`.
* *Rule added:* `t -> f`


* **Compare "wrf" and "er"**
* `w` differs from `e`. (We stop immediately; the rest of the word doesn't matter).
* Because "wrf" comes first, **`w` comes before `e**`.
* *Rule added:* `w -> e`


* **Compare "er" and "ett"**
* `e` matches `e`
* `r` differs from `t`.
* Because "er" comes first, **`r` comes before `t**`.
* *Rule added:* `r -> t`


* **Compare "ett" and "rftt"**
* `e` differs from `r`.
* Because "ett" comes first, **`e` comes before `r**`.
* *Rule added:* `e -> r`



### 3. The Dependency Graph

From those comparisons, we built a clear set of rules. We can count how many incoming arrows (dependencies) each character has.

| Character | Must come before (Edges out) | Dependencies (In-Degree) |
| --- | --- | --- |
| **w** | e | 0 |
| **e** | r | 1 (from w) |
| **r** | t | 1 (from e) |
| **t** | f | 1 (from r) |
| **f** | *none* | 1 (from t) |

### 4. Topological Sort (Resolving the Order)

Now we build the final string by always picking a character that has **0 dependencies left**, then removing its rules from the graph so the next character is freed up.

1. **Look for 0 dependencies:** Only `w` has 0.
* **Result:** `"w"`
* **Action:** Remove `w`'s outgoing rule (`w -> e`). This drops `e`'s dependencies to 0.


2. **Look for 0 dependencies:** Now `e` has 0.
* **Result:** `"we"`
* **Action:** Remove `e`'s outgoing rule (`e -> r`). This drops `r`'s dependencies to 0.


3. **Look for 0 dependencies:** Now `r` has 0.
* **Result:** `"wer"`
* **Action:** Remove `r`'s outgoing rule (`r -> t`). This drops `t`'s dependencies to 0.


4. **Look for 0 dependencies:** Now `t` has 0.
* **Result:** `"wert"`
* **Action:** Remove `t`'s outgoing rule (`t -> f`). This drops `f`'s dependencies to 0.


5. **Look for 0 dependencies:** Now `f` has 0.
* **Result:** `"wertf"`
* **Action:** No more rules to remove.

The graph is empty, all 5 unique letters are in our result, and the final deduced alphabet is **"wertf"**.    
*/                 
