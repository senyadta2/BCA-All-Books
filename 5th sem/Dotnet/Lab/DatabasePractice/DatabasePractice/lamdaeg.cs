using System;

class Program
{
    // Lambda expression with no parameters
    private static Action NoParameterLambda = () => Console.WriteLine("Hello from a lambda with no parameters.");

    // Lambda expression with one parameter
    private static Action<string> SingleParameterLambda = (name) => Console.WriteLine($"Hello, {name}!");

    // Lambda expression with multiple parameters
    private static Func<int, int, int> AddLambda = (a, b) => a + b;

    // Lambda expression with statement body
    private static Func<int, int, int> MultiplyLambda = (a, b) =>
    {
        int result = a * b;
        return result;
    };

    public static void Main(string[] args)
    {
        Console.WriteLine("Rikin Tuladhar");
        // Execute lambda expressions
        NoParameterLambda();

        SingleParameterLambda("Ravi");

        int sum = AddLambda(5, 3);
        Console.WriteLine($"Sum: {sum}");

        int product = MultiplyLambda(4, 6);
        Console.WriteLine($"Product: {product}");
    }
}
