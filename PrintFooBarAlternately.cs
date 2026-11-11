/* https://leetcode.com/problems/print-foobar-alternately/ | Leetcode #1115 - Print FooBar Alternately */

using System.Threading;
public class FooBar
{
    private int n;
    private SemaphoreSlim fooSemaphore = new SemaphoreSlim(1);
    private SemaphoreSlim barSemaphore = new SemaphoreSlim(0);
    public FooBar(int n) {
        this.n = n;
    }
    public void Foo(Action printFoo) {
        for (int i = 0; i < n; i++) {
            fooSemaphore.Wait();
            printFoo();
            barSemaphore.Release();
        }
    }
    public void Bar(Action printBar) {
        for (int i = 0; i < n; i++) {
            barSemaphore.Wait();
            printBar();
            fooSemaphore.Release();
        }
    }
}

/*
1115. Print FooBar Alternately

Suppose you are given the following code:

class FooBar {
  public void foo() {
    for (int i = 0; i < n; i++) {
      print("foo");
    }
  }

  public void bar() {
    for (int i = 0; i < n; i++) {
      print("bar");
    }
  }
}
The same instance of FooBar will be passed to two different threads:

thread A will call foo(), while
thread B will call bar().
Modify the given program to output "foobar" n times.

 

Example 1:

Input: n = 1
Output: "foobar"
Explanation: There are two threads being fired asynchronously. One of them calls foo(), while the other calls bar().
"foobar" is being output 1 time.
Example 2:

Input: n = 2
Output: "foobarfoobar"
Explanation: "foobar" is being output 2 times.
 

Constraints:

1 <= n <= 1000

Interview Explanation ~

This solution uses a shared boolean flag (fooTurn) and Monitor.Wait()/Monitor.PulseAll() for thread synchronization. The Foo thread runs when fooTurn is true, prints "foo", 
switches the turn to Bar, and wakes waiting threads. Similarly, the Bar thread runs when fooTurn is false, prints "bar", switches the turn back to Foo, and wakes waiting threads.
This guarantees the output is always "foobar" repeated n times regardless of thread scheduling. Time Complexity: O(n), Space Complexity: O(1).

*/
