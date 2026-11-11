# 🧠 LeetCode Problem Solving in C#

A collection of **LeetCode problems solved primarily in C#**, with dedicated solutions for **SQL** and **concurrency**. The repository covers fundamental data structures, advanced algorithms, reusable coding patterns, database querying, thread synchronization, and technical interview preparation.

## 📌 Repository Overview

- **Primary language:** C#
- **Additional track:** SQL
- **Problem range:** LeetCode #1 to #1115
- **Focus:** Data Structures, Algorithms, SQL, Concurrency, and Technical Interview Preparation
- **Solution format:** One source file per problem
- **Runtime compatibility:** LeetCode, C# Fiddle, and .NET console environments

## 📋 C# Problem Index

| # | Problem | Solution | Primary approach | Complexity |
|---:|---|---|---|---|
| 1 | Two Sum | [`TwoSum.cs`](TwoSum.cs) | Hash map complement lookup | `O(n)` time, `O(n)` space |
| 2 | Add Two Numbers | [`AddTwoNumbers.cs`](AddTwoNumbers.cs) | Linked-list simulation with carry | `O(max(m,n))` time |
| 3 | Longest Substring Without Repeating Characters | [`LengthOfLongestSubstring.cs`](LengthOfLongestSubstring.cs) | Sliding window | `O(n)` time, `O(k)` space |
| 5 | Longest Palindromic Substring | [`LongestPalindrome.cs`](LongestPalindrome.cs) | Expand around center | `O(n²)` time, `O(1)` space |
| 7 | Reverse Integer | [`Reverse.cs`](Reverse.cs) | Arithmetic with overflow protection | `O(log n)` time |
| 8 | String to Integer (atoi) | [`MyAtoi.cs`](MyAtoi.cs) | String parsing | `O(n)` time, `O(1)` space |
| 9 | Palindrome Number | [`IsPalindrome.cs`](IsPalindrome.cs) | Reverse half of the number | `O(log n)` time |
| 10 | Regular Expression Matching | [`IsMatch.cs`](IsMatch.cs) | Dynamic programming | `O(m × n)` time, `O(m × n)` space |
| 11 | Container With Most Water | [`MaxArea.cs`](MaxArea.cs) | Two pointers | `O(n)` time, `O(1)` space |
| 13 | Roman to Integer | [`RomanToInt.cs`](RomanToInt.cs) | Symbol mapping | `O(n)` time |
| 14 | Longest Common Prefix | [`LongestCommonPrefix.cs`](LongestCommonPrefix.cs) | String scanning | `O(n × m)` time |
| 15 | 3Sum | [`ThreeSum.cs`](ThreeSum.cs) | Sorting and two pointers | `O(n²)` time |
| 17 | Letter Combinations of a Phone Number | [`LetterCombinations.cs`](LetterCombinations.cs) | Backtracking | `O(4ⁿ)` time |
| 19 | Remove Nth Node From End of List | [`RemoveNthFromEnd.cs`](RemoveNthFromEnd.cs) | Fast and slow pointers | `O(n)` time, `O(1)` space |
| 33 | Search in Rotated Sorted Array | [`Search.cs`](Search.cs) | Binary search | `O(log n)` time |
| 39 | Combination Sum | [`CombinationSum.cs`](CombinationSum.cs) | Backtracking with reusable candidates | Exponential time |
| 40 | Combination Sum II | [`CombinationSum2.cs`](CombinationSum2.cs) | Backtracking with duplicate pruning | Exponential time |
| 42 | Trapping Rain Water | [`Trap.cs`](Trap.cs) | Two pointers | `O(n)` time, `O(1)` space |
| 49 | Group Anagrams | [`GroupAnagrams.cs`](GroupAnagrams.cs) | Hash-map grouping | `O(n × k log k)` time |
| 51 | N-Queens | [`SolveNQueens.cs`](SolveNQueens.cs) | Backtracking | `O(n!)` time |
| 53 | Maximum Subarray | [`MaxSubArray.cs`](MaxSubArray.cs) | Kadane's algorithm | `O(n)` time, `O(1)` space |
| 56 | Merge Intervals | [`Merge.cs`](Merge.cs) | Sorting and interval merging | `O(n log n)` time |
| 57 | Insert Interval | [`Insert.cs`](Insert.cs) | Interval processing | `O(n)` time |
| 70 | Climbing Stairs | [`ClimbStairs.cs`](ClimbStairs.cs) | Dynamic programming | `O(n)` time, `O(1)` space |
| 76 | Minimum Window Substring | [`MinWindow.cs`](MinWindow.cs) | Sliding window | `O(n + m)` time |
| 84 | Largest Rectangle in Histogram | [`LargestRectangleArea.cs`](LargestRectangleArea.cs) | Monotonic stack | `O(n)` time, `O(n)` space |
| 89 | Gray Code | [`GrayCode.cs`](GrayCode.cs) | Bit manipulation | `O(2ⁿ)` time |
| 102 | Binary Tree Level Order Traversal | [`LevelOrder.cs`](LevelOrder.cs) | Breadth-first search | `O(n)` time |
| 121 | Best Time to Buy and Sell Stock | [`MaxProfit.cs`](MaxProfit.cs) | Greedy running minimum | `O(n)` time |
| 122 | Best Time to Buy and Sell Stock II | [`MaxProfit2.cs`](MaxProfit2.cs) | Greedy profit accumulation | `O(n)` time |
| 123 | Best Time to Buy and Sell Stock III | [`MaxProfit3.cs`](MaxProfit3.cs) | State-based dynamic programming | `O(n)` time, `O(1)` space |
| 124 | Binary Tree Maximum Path Sum | [`BinaryTreeMaxPathSum.cs`](BinaryTreeMaxPathSum.cs) | Tree DFS | `O(n)` time |
| 128 | Longest Consecutive Sequence | [`LongestConsecutive.cs`](LongestConsecutive.cs) | Hash set | `O(n)` time |
| 133 | Clone Graph | [`CloneGraph.cs`](CloneGraph.cs) | DFS/BFS with visited mapping | `O(V + E)` time |
| 153 | Find Minimum in Rotated Sorted Array | [`FindMin.cs`](FindMin.cs) | Binary search | `O(log n)` time |
| 167 | Two Sum II: Input Array Is Sorted | [`TwoSum2.cs`](TwoSum2.cs) | Two pointers | `O(n)` time |
| 198 | House Robber | [`Rob.cs`](Rob.cs) | Dynamic programming | `O(n)` time, `O(1)` space |
| 200 | Number of Islands | [`NumIslands.cs`](NumIslands.cs) | DFS/BFS flood fill | `O(rows × columns)` time |
| 207 | Course Schedule | [`CanFinish.cs`](CanFinish.cs) | Topological sort | `O(V + E)` time |
| 210 | Course Schedule II | [`FindOrder.cs`](FindOrder.cs) | Topological sort | `O(V + E)` time |
| 215 | Kth Largest Element in an Array | [`FindKthLargest.cs`](FindKthLargest.cs) | Min heap / Quickselect | `O(n log k)` heap time |
| 269 | Alien Dictionary | [`AlienOrder.cs`](AlienOrder.cs) | Topological sort | `O(C)` time |
| 300 | Longest Increasing Subsequence | [`LengthOfLIS.cs`](LengthOfLIS.cs) | Binary search over tails | `O(n log n)` time |
| 322 | Coin Change | [`CoinChange.cs`](CoinChange.cs) | Dynamic programming | `O(amount × coins)` time |
| 347 | Top K Frequent Elements | [`TopKFrequent.cs`](TopKFrequent.cs) | Heap / bucket sort | `O(n log k)` heap time |
| 424 | Longest Repeating Character Replacement | [`CharacterReplacement.cs`](CharacterReplacement.cs) | Sliding window | `O(n)` time |
| 435 | Non-overlapping Intervals | [`EraseOverlapIntervals.cs`](EraseOverlapIntervals.cs) | Greedy intervals | `O(n log n)` time |
| 503 | Next Greater Element II | [`NextGreaterElements.cs`](NextGreaterElements.cs) | Monotonic stack | `O(n)` time |
| 543 | Diameter of Binary Tree | [`DiameterOfBinaryTree.cs`](DiameterOfBinaryTree.cs) | Tree DFS | `O(n)` time |
| 560 | Subarray Sum Equals K | [`SubarraySum.cs`](SubarraySum.cs) | Prefix sum and hash map | `O(n)` time |
| 703 | Kth Largest Element in a Stream | [`KthLargest.cs`](KthLargest.cs) | Fixed-size min heap | `O(log k)` per insertion |
| 739 | Daily Temperatures | [`DailyTemperatures.cs`](DailyTemperatures.cs) | Monotonic stack | `O(n)` time |
| 743 | Network Delay Time | [`NetworkDelayTime.cs`](NetworkDelayTime.cs) | Dijkstra's algorithm | `O((V + E) log V)` time |
| 778 | Swim in Rising Water | [`SwimInWater.cs`](SwimInWater.cs) | Minimax Dijkstra | `O(n² log n)` time |
| 875 | Koko Eating Bananas | [`MinEatingSpeed.cs`](MinEatingSpeed.cs) | Binary search on answer | `O(n log m)` time |
| 901 | Online Stock Span | [`StockSpanner.cs`](StockSpanner.cs) | Monotonic stack | Amortized `O(1)` per call |
| 973 | K Closest Points to Origin | [`KClosest.cs`](KClosest.cs) | Heap / Quickselect | `O(n log k)` heap time |
| 994 | Rotting Oranges | [`OrangesRotting.cs`](OrangesRotting.cs) | Multi-source BFS | `O(rows × columns)` time |
| 1011 | Capacity To Ship Packages Within D Days | [`ShipWithinDays.cs`](ShipWithinDays.cs) | Binary search on answer | `O(n log sum)` time |

## 🗄️ SQL Solutions

These problems cover distinct-value handling, ordering, aggregation, subqueries, stored functions, joins, and ranking salaries.

| # | Problem | Solution | Main SQL concepts |
|---:|---|---|---|
| 176 | Second Highest Salary | [`SecondHighestSalary.sql`](SecondHighestSalary.sql) | `DISTINCT`, `ORDER BY`, `LIMIT`, `OFFSET`, scalar subquery |
| 177 | Nth Highest Salary | [`getNthHighestSalary.sql`](getNthHighestSalary.sql) | Stored function, `DISTINCT`, ordered pagination, `NULL` handling |

### SQL patterns covered

- Selecting distinct ranked values
- Returning `NULL` when a requested rank does not exist
- Sorting values in descending order
- Using `LIMIT` and `OFFSET`
- Encapsulating reusable database logic in a function

## 🧵 Concurrency Solutions

Concurrency problems coordinate multiple threads so that shared operations execute in a deterministic order.

| # | Problem | Solution | Synchronization technique | Complexity |
|---:|---|---|---|---|
| 1115 | Print FooBar Alternately | [`PrintFooBarAlternately.cs`](PrintFooBarAlternately.cs) | `lock`, shared turn flag, `Monitor.Wait()`, `Monitor.PulseAll()` | `O(n)` time, `O(1)` space |

### Concurrency concepts covered

- Mutual exclusion with `lock`
- Thread coordination with `Monitor.Wait()` and `Monitor.PulseAll()`
- Releasing the lock while a thread waits
- Protecting shared state with a critical section
- Deterministic alternation between two asynchronously scheduled threads
- Avoiding busy waiting

## 🧠 Algorithms and Problem-Solving Patterns

### Hash Maps and Hash Sets
`TwoSum.cs`, `RomanToInt.cs`, `GroupAnagrams.cs`, `LongestConsecutive.cs`, `TopKFrequent.cs`, `SubarraySum.cs`

### Two Pointers
`LongestPalindrome.cs`, `MaxArea.cs`, `ThreeSum.cs`, `RemoveNthFromEnd.cs`, `Trap.cs`, `TwoSum2.cs`

### Sliding Window
`LengthOfLongestSubstring.cs`, `MinWindow.cs`, `CharacterReplacement.cs`

### Binary Search
`Search.cs`, `FindMin.cs`, `LengthOfLIS.cs`, `MinEatingSpeed.cs`, `ShipWithinDays.cs`

### Backtracking
`LetterCombinations.cs`, `CombinationSum.cs`, `CombinationSum2.cs`, `SolveNQueens.cs`

### Dynamic Programming
`IsMatch.cs`, `ClimbStairs.cs`, `MaxSubArray.cs`, `MaxProfit3.cs`, `Rob.cs`, `LengthOfLIS.cs`, `CoinChange.cs`

### Monotonic Stack
`LargestRectangleArea.cs`, `NextGreaterElements.cs`, `DailyTemperatures.cs`, `StockSpanner.cs`

### Trees and Graphs
`LevelOrder.cs`, `BinaryTreeMaxPathSum.cs`, `DiameterOfBinaryTree.cs`, `CloneGraph.cs`, `NumIslands.cs`, `CanFinish.cs`, `FindOrder.cs`, `AlienOrder.cs`, `NetworkDelayTime.cs`, `SwimInWater.cs`, `OrangesRotting.cs`

### Heap and Priority Queue
`FindKthLargest.cs`, `TopKFrequent.cs`, `KthLargest.cs`, `NetworkDelayTime.cs`, `SwimInWater.cs`, `KClosest.cs`

### Intervals and Greedy
`Merge.cs`, `Insert.cs`, `EraseOverlapIntervals.cs`, `MaxProfit.cs`, `MaxProfit2.cs`

## 🔗 Related Problem Progressions

### Stock Trading

```text
#121 Best Time to Buy and Sell Stock
        ↓
#122 Best Time to Buy and Sell Stock II
        ↓
#123 Best Time to Buy and Sell Stock III
```

### Graph Pathfinding

```text
#200 Number of Islands
        ↓
#743 Network Delay Time
        ↓
#778 Swim in Rising Water
        ↓
#994 Rotting Oranges
```

### Salary Ranking with SQL

```text
#176 Second Highest Salary
        ↓
#177 Nth Highest Salary
```

### Thread Coordination

```text
#1115 Print FooBar Alternately
lock + shared state + Monitor.Wait/PulseAll
```
