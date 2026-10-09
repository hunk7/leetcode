# 🧠 LeetCode Problem Solving in C#

A collection of **LeetCode problems solved in C#**, covering fundamental data structures, advanced algorithms, reusable coding patterns and technical interview techniques.

The repository provides concrete examples of:

- Selecting algorithms based on constraints and input characteristics
- Progressing from brute-force reasoning to optimized solutions
- Evaluating time and space complexity
- Implementing algorithms using readable and maintainable C#
- Handling boundary conditions, invalid states and uncommon edge cases
- Applying reusable patterns across arrays, strings, linked lists, trees, graphs and dynamic programming problems

---

## 📌 Repository Overview

- **Primary language:** C#
- **Problem range:** LeetCode #1 to #1011
- **Primary focus:** Data Structures, Algorithms and Technical Interview Preparation
- **Core areas:** Arrays, Strings, Linked Lists, Trees, Graphs, Heaps, Dynamic Programming and Greedy Algorithms
- **Advanced patterns:** Sliding Window, Monotonic Stack, Topological Sort, Dijkstra’s Algorithm, Multi-Source BFS and Binary Search on Answer
- **Solution format:** One C# source file per problem
- **Runtime compatibility:** C# Fiddle and .NET console environments

---

## 📋 Complete Problem Index

Each entry includes the problem, C# source file, primary algorithm, problem-specific technique and expected complexity.

- **#1 Two Sum** • [`TwoSum.cs`](TwoSum.cs) • Hash Map • Store visited values and search for each complement • `O(n)` time • `O(n)` space
- **#2 Add Two Numbers** • [`AddTwoNumbers.cs`](AddTwoNumbers.cs) • Linked List Simulation • Add corresponding digits while propagating carry through a dummy node • `O(max(m,n))` time • `O(max(m,n))` output space
- **#3 Longest Substring Without Repeating Characters** • [`LengthOfLongestSubstring.cs`](LengthOfLongestSubstring.cs) • Sliding Window • Move the left boundary after detecting repeated characters • `O(n)` time • `O(k)` space
- **#5 Longest Palindromic Substring** • [`LongestPalindrome.cs`](LongestPalindrome.cs) • Expand Around Center • Evaluate odd and even palindrome centers • `O(n²)` time • `O(1)` space
- **#7 Reverse Integer** • [`Reverse.cs`](Reverse.cs) • Arithmetic • Extract digits and rebuild the integer with overflow protection • `O(log n)` time • `O(1)` space
- **#8 String to Integer (atoi)** • [`MyAtoi.cs`](MyAtoi.cs) • String Parsing • Handle whitespace, sign, digits and integer overflow • `O(n)` time • `O(1)` space
- **#9 Palindrome Number** • [`IsPalindrome.cs`](IsPalindrome.cs) • Arithmetic • Reverse half of the integer instead of converting it to a string • `O(log n)` time • `O(1)` space
- **#11 Container With Most Water** • [`MaxArea.cs`](MaxArea.cs) • Two Pointers • Move the shorter boundary because it limits the current area • `O(n)` time • `O(1)` space
- **#13 Roman to Integer** • [`RomanToInt.cs`](RomanToInt.cs) • Hash Map • Map Roman symbols and process subtractive combinations • `O(n)` time • `O(1)` space
- **#14 Longest Common Prefix** • [`LongestCommonPrefix.cs`](LongestCommonPrefix.cs) • String Scanning • Compare matching characters across all strings • `O(n × m)` time • `O(1)` auxiliary space
- **#15 3Sum** • [`ThreeSum.cs`](ThreeSum.cs) • Sorting and Two Pointers • Fix one number, solve the remaining pair and skip duplicates • `O(n²)` time • `O(1)` auxiliary space
- **#17 Letter Combinations of a Phone Number** • [`LetterCombinations.cs`](LetterCombinations.cs) • Backtracking • Explore one keypad character choice for each digit • `O(4ⁿ)` time • `O(n)` recursion space
- **#19 Remove Nth Node From End of List** • [`RemoveNthFromEnd.cs`](RemoveNthFromEnd.cs) • Fast and Slow Pointers • Maintain an `n`-node gap using a dummy head • `O(n)` time • `O(1)` space
- **#33 Search in Rotated Sorted Array** • [`Search.cs`](Search.cs) • Binary Search • Detect the sorted half before eliminating a search region • `O(log n)` time • `O(1)` space
- **#39 Combination Sum** • [`CombinationSum.cs`](CombinationSum.cs) • Backtracking • Reuse candidates and prune branches that exceed the target • Exponential time • `O(target)` recursion space
- **#40 Combination Sum II** • [`CombinationSum2.cs`](CombinationSum2.cs) • Backtracking • Sort candidates, skip duplicate branches and use each value once • Exponential time • `O(n)` recursion space
- **#42 Trapping Rain Water** • [`Trap.cs`](Trap.cs) • Two Pointers • Process the side with the smaller maximum boundary • `O(n)` time • `O(1)` space
- **#49 Group Anagrams** • [`GroupAnagrams.cs`](GroupAnagrams.cs) • Hash Map • Group strings using a canonical sorted or frequency-based key • `O(n × k log k)` time • `O(n × k)` space
- **#51 N-Queens** • [`SolveNQueens.cs`](SolveNQueens.cs) • Backtracking • Place one queen per row while tracking blocked columns and diagonals • `O(n!)` time • `O(n)` auxiliary space excluding output
- **#56 Merge Intervals** • [`Merge.cs`](Merge.cs) • Sorting and Intervals • Sort by starting position and merge overlapping ranges • `O(n log n)` time • `O(n)` output space
- **#57 Insert Interval** • [`Insert.cs`](Insert.cs) • Interval Processing • Append earlier intervals, merge overlaps and append remaining intervals • `O(n)` time • `O(n)` output space
- **#70 Climbing Stairs** • [`ClimbStairs.cs`](ClimbStairs.cs) • Dynamic Programming • Apply the Fibonacci recurrence using rolling states • `O(n)` time • `O(1)` space
- **#76 Minimum Window Substring** • [`MinWindow.cs`](MinWindow.cs) • Sliding Window • Expand until valid and contract while preserving required frequencies • `O(n + m)` time • `O(k)` space
- **#84 Largest Rectangle in Histogram** • [`LargestRectangleArea.cs`](LargestRectangleArea.cs) • Monotonic Stack • Calculate maximum widths when increasing height order breaks • `O(n)` time • `O(n)` space
- **#89 Gray Code** • [`GrayCode.cs`](GrayCode.cs) • Bit Manipulation • Generate each value using the transformation `i ^ (i >> 1)` • `O(2ⁿ)` time • `O(2ⁿ)` output space
- **#102 Binary Tree Level Order Traversal** • [`LevelOrder.cs`](LevelOrder.cs) • Breadth-First Search • Process queued tree nodes one level at a time • `O(n)` time • `O(w)` space
- **#121 Best Time to Buy and Sell Stock** • [`MaxProfit.cs`](MaxProfit.cs) • Greedy • Track the minimum price and maximum single-transaction profit • `O(n)` time • `O(1)` space
- **#122 Best Time to Buy and Sell Stock II** • [`MaxProfit2.cs`](MaxProfit2.cs) • Greedy • Accumulate every positive price difference • `O(n)` time • `O(1)` space
- **#123 Best Time to Buy and Sell Stock III** • [`MaxProfit3.cs`](MaxProfit3.cs) • State-Based Dynamic Programming • Track buy and sell states for two transactions • `O(n)` time • `O(1)` space
- **#124 Binary Tree Maximum Path Sum** • [`BinaryTreeMaxPathSum.cs`](BinaryTreeMaxPathSum.cs) • Tree DFS • Combine left and right gains while returning the best one-sided path • `O(n)` time • `O(h)` recursion space
- **#128 Longest Consecutive Sequence** • [`LongestConsecutive.cs`](LongestConsecutive.cs) • Hash Set • Start counting only when the previous sequence value does not exist • `O(n)` time • `O(n)` space
- **#133 Clone Graph** • [`CloneGraph.cs`](CloneGraph.cs) • Graph DFS or BFS • Map original nodes to cloned nodes to prevent repeated creation • `O(V + E)` time • `O(V)` space
- **#153 Find Minimum in Rotated Sorted Array** • [`FindMin.cs`](FindMin.cs) • Binary Search • Compare the middle value with the right boundary to locate the pivot • `O(log n)` time • `O(1)` space
- **#167 Two Sum II: Input Array Is Sorted** • [`TwoSum2.cs`](TwoSum2.cs) • Two Pointers • Move sorted-array boundaries based on the current sum • `O(n)` time • `O(1)` space
- **#198 House Robber** • [`Rob.cs`](Rob.cs) • Dynamic Programming • Choose between taking the current value and retaining previous profit • `O(n)` time • `O(1)` space
- **#200 Number of Islands** • [`NumIslands.cs`](NumIslands.cs) • DFS or BFS Flood Fill • Traverse every unvisited land component • `O(rows × columns)` time • `O(rows × columns)` worst-case space
- **#207 Course Schedule** • [`CanFinish.cs`](CanFinish.cs) • Topological Sort • Apply Kahn’s algorithm and detect cycles through processed-node count • `O(V + E)` time • `O(V + E)` space
- **#210 Course Schedule II** • [`FindOrder.cs`](FindOrder.cs) • Topological Sort • Reduce indegrees while constructing a valid course ordering • `O(V + E)` time • `O(V + E)` space
- **#215 Kth Largest Element in an Array** • [`FindKthLargest.cs`](FindKthLargest.cs) • Min Heap or Quickselect • Preserve the largest `k` values or partition around a pivot • `O(n log k)` heap time • `O(k)` space
- **#269 Alien Dictionary** • [`AlienOrder.cs`](AlienOrder.cs) • Topological Sort • Derive character dependencies and detect invalid prefix orderings • `O(C)` time • `O(U + E)` space
- **#300 Longest Increasing Subsequence** • [`LengthOfLIS.cs`](LengthOfLIS.cs) • Dynamic Programming and Binary Search • Maintain the smallest possible tail for every subsequence length • `O(n log n)` time • `O(n)` space
- **#322 Coin Change** • [`CoinChange.cs`](CoinChange.cs) • Dynamic Programming • Build minimum coin counts using unbounded reusable choices • `O(amount × coins)` time • `O(amount)` space
- **#347 Top K Frequent Elements** • [`TopKFrequent.cs`](TopKFrequent.cs) • Heap or Bucket Sort • Count frequencies before selecting the highest-frequency values • `O(n log k)` heap time • `O(n)` space
- **#424 Longest Repeating Character Replacement** • [`CharacterReplacement.cs`](CharacterReplacement.cs) • Sliding Window • Validate the window using its size and maximum character frequency • `O(n)` time • `O(k)` space
- **#435 Non-overlapping Intervals** • [`EraseOverlapIntervals.cs`](EraseOverlapIntervals.cs) • Greedy Intervals • Retain the interval with the earliest ending position • `O(n log n)` time • `O(1)` auxiliary space
- **#503 Next Greater Element II** • [`NextGreaterElements.cs`](NextGreaterElements.cs) • Monotonic Stack • Simulate circular traversal through modular indexing • `O(n)` time • `O(n)` space
- **#543 Diameter of Binary Tree** • [`DiameterOfBinaryTree.cs`](DiameterOfBinaryTree.cs) • Tree DFS • Combine left and right subtree heights at every node • `O(n)` time • `O(h)` recursion space
- **#560 Subarray Sum Equals K** • [`SubarraySum.cs`](SubarraySum.cs) • Prefix Sum and Hash Map • Count earlier prefixes equal to `currentSum - k` • `O(n)` time • `O(n)` space
- **#703 Kth Largest Element in a Stream** • [`KthLargest.cs`](KthLargest.cs) • Fixed-Size Min Heap • Preserve only the largest `k` values received from the stream • `O(log k)` per insertion • `O(k)` space
- **#739 Daily Temperatures** • [`DailyTemperatures.cs`](DailyTemperatures.cs) • Monotonic Stack • Resolve earlier indices when a warmer temperature is encountered • `O(n)` time • `O(n)` space
- **#743 Network Delay Time** • [`NetworkDelayTime.cs`](NetworkDelayTime.cs) • Dijkstra’s Algorithm • Relax non-negative weighted edges using a minimum-priority queue • `O((V + E) log V)` time • `O(V + E)` space
- **#778 Swim in Rising Water** • [`SwimInWater.cs`](SwimInWater.cs) • Dijkstra’s Algorithm • Minimize the maximum elevation encountered while expanding reachable grid cells • `O(n² log n)` time • `O(n²)` space
- **#875 Koko Eating Bananas** • [`MinEatingSpeed.cs`](MinEatingSpeed.cs) • Binary Search on Answer • Test whether a candidate eating speed satisfies the hour constraint • `O(n log m)` time • `O(1)` space
- **#901 Online Stock Span** • [`StockSpanner.cs`](StockSpanner.cs) • Monotonic Stack • Merge consecutive smaller prices into accumulated spans • Amortized `O(1)` per call • `O(n)` space
- **#973 K Closest Points to Origin** • [`KClosest.cs`](KClosest.cs) • Heap or Quickselect • Rank points using squared Euclidean distance • `O(n log k)` heap time • `O(k)` space
- **#994 Rotting Oranges** • [`OrangesRotting.cs`](OrangesRotting.cs) • Multi-Source BFS • Expand simultaneously from every initially rotten orange • `O(rows × columns)` time • `O(rows × columns)` space
- **#1011 Capacity To Ship Packages Within D Days** • [`ShipWithinDays.cs`](ShipWithinDays.cs) • Binary Search on Answer • Simulate shipping days to validate each candidate capacity • `O(n log sum)` time • `O(1)` space

---

## 🧠 Algorithms and Problem-Solving Patterns

### 🗂️ Hash Maps and Hash Sets

- **#1 Two Sum** • [`TwoSum.cs`](TwoSum.cs) • Complement lookup
- **#13 Roman to Integer** • [`RomanToInt.cs`](RomanToInt.cs) • Symbol-to-value mapping
- **#49 Group Anagrams** • [`GroupAnagrams.cs`](GroupAnagrams.cs) • Canonical-key grouping
- **#128 Longest Consecutive Sequence** • [`LongestConsecutive.cs`](LongestConsecutive.cs) • Sequence-boundary detection
- **#347 Top K Frequent Elements** • [`TopKFrequent.cs`](TopKFrequent.cs) • Frequency counting with top-K selection
- **#560 Subarray Sum Equals K** • [`SubarraySum.cs`](SubarraySum.cs) • Prefix-sum frequency tracking

Techniques covered:

- Complement lookup
- Frequency counting
- Membership testing
- Canonical representations
- Prefix-sum frequencies
- Sequence-boundary detection
- Average constant-time insertion and lookup

Hash-based approaches replace repeated scanning by preserving previously calculated or encountered information.

---

### ↔️ Two Pointers

- **#5 Longest Palindromic Substring** • [`LongestPalindrome.cs`](LongestPalindrome.cs) • Center expansion
- **#11 Container With Most Water** • [`MaxArea.cs`](MaxArea.cs) • Opposite-boundary optimization
- **#15 3Sum** • [`ThreeSum.cs`](ThreeSum.cs) • Sorted pair search
- **#19 Remove Nth Node From End of List** • [`RemoveNthFromEnd.cs`](RemoveNthFromEnd.cs) • Fixed pointer gap
- **#42 Trapping Rain Water** • [`Trap.cs`](Trap.cs) • Left and right maximum boundaries
- **#167 Two Sum II** • [`TwoSum2.cs`](TwoSum2.cs) • Sorted-array pair search

Techniques covered:

- Opposite-direction traversal
- Fast and slow linked-list pointers
- Palindrome expansion
- Sorted pair searching
- Boundary-based optimization
- Duplicate elimination
- Constant-space array processing

Pointer movement is determined by the value, boundary or condition currently limiting the answer.

---

### 🪟 Sliding Window

- **#3 Longest Substring Without Repeating Characters** • [`LengthOfLongestSubstring.cs`](LengthOfLongestSubstring.cs) • Duplicate-aware window
- **#76 Minimum Window Substring** • [`MinWindow.cs`](MinWindow.cs) • Minimum valid frequency window
- **#424 Longest Repeating Character Replacement** • [`CharacterReplacement.cs`](CharacterReplacement.cs) • Replacement-budget validation

Techniques covered:

- Dynamic left and right boundaries
- Character-frequency tracking
- Window-validity conditions
- Controlled expansion and contraction
- Minimum and maximum valid ranges
- Incremental substring processing

Sliding windows prevent repeated processing of overlapping contiguous ranges.

---

### 🔎 Binary Search

- **#33 Search in Rotated Sorted Array** • [`Search.cs`](Search.cs) • Sorted-half detection
- **#153 Find Minimum in Rotated Sorted Array** • [`FindMin.cs`](FindMin.cs) • Rotation-pivot detection
- **#300 Longest Increasing Subsequence** • [`LengthOfLIS.cs`](LengthOfLIS.cs) • Binary search over subsequence tails
- **#875 Koko Eating Bananas** • [`MinEatingSpeed.cs`](MinEatingSpeed.cs) • Minimum feasible speed
- **#1011 Capacity To Ship Packages Within D Days** • [`ShipWithinDays.cs`](ShipWithinDays.cs) • Minimum feasible capacity

Techniques covered:

- Search-space reduction
- Rotated-array reasoning
- Pivot identification
- Lower-bound replacement
- Binary search on answer
- Monotonic feasibility validation
- Minimum feasible value selection

Binary search applies when the input is ordered or when candidate answers form monotonic feasible and infeasible regions.

---

### 🌳 Backtracking

- **#17 Letter Combinations of a Phone Number** • [`LetterCombinations.cs`](LetterCombinations.cs) • Recursive choice exploration
- **#39 Combination Sum** • [`CombinationSum.cs`](CombinationSum.cs) • Reusable candidates
- **#40 Combination Sum II** • [`CombinationSum2.cs`](CombinationSum2.cs) • Single-use candidates and duplicate pruning
- **#51 N-Queens** • [`SolveNQueens.cs`](SolveNQueens.cs) • Constraint-based board construction

Techniques covered:

- Decision-tree exploration
- Recursive state construction
- Choice selection and restoration
- Candidate reuse
- Candidate exclusion
- Duplicate-branch prevention
- Constraint-based pruning
- Column and diagonal conflict detection
- Incremental board construction

Backtracking explores valid decisions while abandoning branches that cannot produce a valid result.

---

### 🔢 Bit Manipulation

- **#89 Gray Code** • [`GrayCode.cs`](GrayCode.cs) • Binary-to-Gray-code transformation

Techniques covered:

- Bitwise XOR
- Right-shift operations
- Binary sequence generation
- Consecutive one-bit transitions
- Direct mathematical construction
- Constant-time value generation

The Gray code for an integer `i` can be generated directly using `i ^ (i >> 1)`, ensuring that consecutive values differ by exactly one bit.

---

### 🧮 Dynamic Programming

- **#70 Climbing Stairs** • [`ClimbStairs.cs`](ClimbStairs.cs) • Fibonacci-style state transition
- **#123 Best Time to Buy and Sell Stock III** • [`MaxProfit3.cs`](MaxProfit3.cs) • Transaction state machine
- **#198 House Robber** • [`Rob.cs`](Rob.cs) • Include-or-exclude transition
- **#300 Longest Increasing Subsequence** • [`LengthOfLIS.cs`](LengthOfLIS.cs) • Subsequence-state optimization
- **#322 Coin Change** • [`CoinChange.cs`](CoinChange.cs) • Unbounded minimum-state transition

Techniques covered:

- Overlapping subproblems
- State definitions
- Recurrence relationships
- Bottom-up tabulation
- State compression
- Include-or-exclude decisions
- Unbounded choices
- Minimum and maximum optimization

Dynamic programming derives larger results from previously solved states and avoids repeated computation.

---

### 📚 Monotonic Stack

- **#84 Largest Rectangle in Histogram** • [`LargestRectangleArea.cs`](LargestRectangleArea.cs) • Previous and next smaller boundaries
- **#503 Next Greater Element II** • [`NextGreaterElements.cs`](NextGreaterElements.cs) • Circular next-greater search
- **#739 Daily Temperatures** • [`DailyTemperatures.cs`](DailyTemperatures.cs) • Next warmer value
- **#901 Online Stock Span** • [`StockSpanner.cs`](StockSpanner.cs) • Previous greater boundary and span aggregation

Techniques covered:

- Increasing and decreasing stacks
- Next-greater relationships
- Previous-greater relationships
- Circular-array traversal
- Index preservation
- Span aggregation
- Boundary calculation

Each element enters and leaves the stack at most once, allowing many apparently quadratic problems to run in linear time.

---

### 🌲 Binary Trees

- **#102 Binary Tree Level Order Traversal** • [`LevelOrder.cs`](LevelOrder.cs) • Level-based BFS
- **#124 Binary Tree Maximum Path Sum** • [`BinaryTreeMaxPathSum.cs`](BinaryTreeMaxPathSum.cs) • Postorder gain calculation
- **#543 Diameter of Binary Tree** • [`DiameterOfBinaryTree.cs`](DiameterOfBinaryTree.cs) • Subtree-height aggregation

Techniques covered:

- Breadth-first traversal
- Recursive depth-first traversal
- Postorder aggregation
- Height calculation
- One-sided and two-sided path reasoning
- Global result tracking
- Queue-based level separation

Tree DFS solutions distinguish between the value returned to a parent and the complete result passing through the current node.

---

### 🕸️ Graph Algorithms

- **#133 Clone Graph** • [`CloneGraph.cs`](CloneGraph.cs) • Graph copying with visited mapping
- **#200 Number of Islands** • [`NumIslands.cs`](NumIslands.cs) • Grid-based connected components
- **#207 Course Schedule** • [`CanFinish.cs`](CanFinish.cs) • Cycle detection through topological sorting
- **#210 Course Schedule II** • [`FindOrder.cs`](FindOrder.cs) • Dependency ordering
- **#269 Alien Dictionary** • [`AlienOrder.cs`](AlienOrder.cs) • Character dependency construction
- **#743 Network Delay Time** • [`NetworkDelayTime.cs`](NetworkDelayTime.cs) • Weighted shortest paths
- **#778 Swim in Rising Water** • [`SwimInWater.cs`](SwimInWater.cs) • Minimax grid pathfinding
- **#994 Rotting Oranges** • [`OrangesRotting.cs`](OrangesRotting.cs) • Simultaneous multi-source traversal

Techniques covered:

- Adjacency-list construction
- DFS and BFS traversal
- Visited-state management
- Connected-component counting
- Grid-to-graph modelling
- Directed dependency graphs
- Cycle detection
- Topological sorting
- Weighted shortest paths
- Minimax pathfinding
- Priority-based graph traversal
- Multi-source traversal

Graph problems can model explicit node relationships, dependency structures or implicit connections between neighboring grid cells.

---

### 🔗 Topological Sorting

- **#207 Course Schedule** • [`CanFinish.cs`](CanFinish.cs) • Determine whether a valid ordering exists
- **#210 Course Schedule II** • [`FindOrder.cs`](FindOrder.cs) • Construct a valid ordering
- **#269 Alien Dictionary** • [`AlienOrder.cs`](AlienOrder.cs) • Derive ordering constraints from words

Techniques covered:

- Directed graph construction
- Indegree calculation
- Kahn’s BFS algorithm
- Dependency ordering
- Cycle detection
- Invalid-prefix detection
- Partial-order reconstruction

A processed-node count smaller than the number of graph nodes indicates that a directed cycle prevents a valid ordering.

---

### 🛣️ Dijkstra’s Algorithm

- **#743 Network Delay Time** • [`NetworkDelayTime.cs`](NetworkDelayTime.cs) • Minimum total path distance
- **#778 Swim in Rising Water** • [`SwimInWater.cs`](SwimInWater.cs) • Minimum possible maximum elevation

Techniques covered:

- Weighted adjacency-list construction
- Grid-based graph modelling
- Non-negative edge relaxation
- Minimum-priority queue traversal
- Shortest-distance initialization
- Stale priority-queue entry handling
- Reachability detection
- Minimax distance calculation
- Final shortest-distance calculation

Standard Dijkstra’s algorithm minimizes the total path cost. Its minimax variation tracks the maximum value encountered along a path and selects the path that minimizes that maximum.

---

### 🔝 Heap and Priority Queue

- **#215 Kth Largest Element in an Array** • [`FindKthLargest.cs`](FindKthLargest.cs) • Fixed-size top-K heap
- **#347 Top K Frequent Elements** • [`TopKFrequent.cs`](TopKFrequent.cs) • Frequency-prioritized selection
- **#703 Kth Largest Element in a Stream** • [`KthLargest.cs`](KthLargest.cs) • Streaming order statistics
- **#743 Network Delay Time** • [`NetworkDelayTime.cs`](NetworkDelayTime.cs) • Minimum-distance graph traversal
- **#778 Swim in Rising Water** • [`SwimInWater.cs`](SwimInWater.cs) • Minimum-elevation path traversal
- **#973 K Closest Points to Origin** • [`KClosest.cs`](KClosest.cs) • Distance-prioritized selection

Techniques covered:

- Fixed-size min heaps
- Top-K selection
- Streaming order statistics
- Frequency-based prioritization
- Distance-based prioritization
- Priority-based graph traversal
- Minimax path exploration
- Repeated minimum extraction

Heaps preserve the most relevant candidates without requiring the entire input to remain sorted.

---

### 📏 Intervals and Greedy Selection

- **#56 Merge Intervals** • [`Merge.cs`](Merge.cs) • Merge overlapping ranges
- **#57 Insert Interval** • [`Insert.cs`](Insert.cs) • Insert and merge one new range
- **#435 Non-overlapping Intervals** • [`EraseOverlapIntervals.cs`](EraseOverlapIntervals.cs) • Earliest-finish-time selection

Techniques covered:

- Sorting by start time
- Sorting by end time
- Overlap detection
- Interval insertion
- Interval merging
- Greedy interval retention
- Minimum removal calculation

Sorting exposes relationships between neighboring intervals and enables one-pass overlap processing.

---

### ➕ Prefix Sum

- **#560 Subarray Sum Equals K** • [`SubarraySum.cs`](SubarraySum.cs)

Techniques covered:

- Running cumulative sums
- Prefix-difference relationships
- Prefix-frequency tracking
- Counting multiple valid starting positions
- Supporting arrays with negative values

For a subarray ending at the current position to equal `k`, an earlier prefix sum equal to `currentSum - k` must exist.

---

### 🍊 Multi-Source BFS

- **#994 Rotting Oranges** • [`OrangesRotting.cs`](OrangesRotting.cs)

Techniques covered:

- Queue initialization from multiple origins
- Simultaneous breadth-first expansion
- Level-based time calculation
- Grid boundary validation
- Remaining-state tracking
- Unreachable-cell detection

Multi-source BFS models processes that spread from several starting points simultaneously.

---

## 🔗 Related Problem Progressions

### Stock Trading

```text
#121 Best Time to Buy and Sell Stock
MaxProfit.cs
Single transaction using a running minimum
                ↓
#122 Best Time to Buy and Sell Stock II
MaxProfit2.cs
Unlimited transactions using greedy profit accumulation
                ↓
#123 Best Time to Buy and Sell Stock III
MaxProfit3.cs
At most two transactions using dynamic programming states
```

### Combination Generation and Backtracking

```text
#17 Letter Combinations of a Phone Number
LetterCombinations.cs
Choose one character for every input digit
                ↓
#39 Combination Sum
CombinationSum.cs
Reuse candidates while constructing a target sum
                ↓
#40 Combination Sum II
CombinationSum2.cs
Use each candidate once and eliminate duplicate combinations
                ↓
#51 N-Queens
SolveNQueens.cs
Construct a board while enforcing column and diagonal constraints
```

### Graph Pathfinding

```text
#200 Number of Islands
NumIslands.cs
Traverse unweighted grid components using DFS or BFS
                ↓
#743 Network Delay Time
NetworkDelayTime.cs
Find shortest weighted paths using Dijkstra’s algorithm
                ↓
#778 Swim in Rising Water
SwimInWater.cs
Find a minimax path that minimizes the highest encountered elevation
                ↓
#994 Rotting Oranges
OrangesRotting.cs
Model simultaneous grid expansion using multi-source BFS
```

### Bit Manipulation

```text
#89 Gray Code
GrayCode.cs
Generate a binary-reflected Gray code sequence using i ^ (i >> 1)
```
