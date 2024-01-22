namespace Fibonacci;
/*
 * Fibonacci series is a series of numbers in which each number is the sum of the two preceding numbers.
 * formula: F(n) = F(n-1) + F(n-2), F(0) = 0, F(1) = 1
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 ...
 */ 
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter nth number: ");
        var n = Convert.ToInt32(Console.ReadLine());
        var fiboIterative = FibonacciIterative(n);
        var fiboRecursive = FibonacciRecursive(n);
        Console.WriteLine("Fibonacci Iterative: " + fiboIterative);
        Console.WriteLine("Fibonacci Recursive: " + fiboRecursive);
    }
    
    // iterative apporach 
    // time complexity: O(n)
    private static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int first = 0, second = 1, result = 0;
        for (var i = 2; i <= n;  i++)
        {
            result = first + second;
            first = second;
            second = result; 
        }
        return result;
    }
    
    // recursive approach
    // time complexity: O(2^n)
    private static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
}