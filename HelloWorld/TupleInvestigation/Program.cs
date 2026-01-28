internal class Program
{

    public static (int min,int max,int sum) AnalyseList(int[] list)
    {
        int max = list.Max();
        int min = list.Min();
        int sum = list.Sum();
        // use a Tuple to return both values
        return (min, max, sum);
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Tuple Investigation");
        int[] numbers = { 11, 5, 3, 10, 2, 7, 12, 15, 9 };
        // (int, int) answer = AnalyseList(numbers);

        // use var to simplify the return types
        var answer = AnalyseList(numbers);
        Console.WriteLine($"The answer is {answer}");

        Console.WriteLine($"The min is {answer.min}");
        Console.WriteLine($"The max is {answer.max}");
        Console.WriteLine($"The sum is {answer.sum}");

        // you can use tuples to swap two varaibles
        // without using a third temporary variable

        int a = 10;
        int b = 20;

        Console.WriteLine($"{ a } { b }");
        (a, b) = (b, a);
        Console.WriteLine($"{ a } { b }");









    }
}