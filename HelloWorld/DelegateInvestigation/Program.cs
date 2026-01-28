internal class Program
{

    public static bool CheckEven(int n)
    {
        return n % 2 == 0;
    }
    public static bool CheckOdd(int n)
    {
        return n % 2 == 1;
    }
    public delegate bool CheckFunction(int n);

    public static int CheckValues(int a, int b)
    {
        return a + b;
    }

    public static void ProcessList(int[] numbers, CheckFunction cf)
    {
        foreach (int number in numbers)
        {
            if (cf(number))
            {
                Console.WriteLine(number);
            }
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Delegate Investigation");
        int[] numbers = { 1, 6, 5, 3, 4, 9, 10, 7, 8 };
       
        ProcessList(numbers, CheckOdd);
        Console.WriteLine("================================");
        ProcessList(numbers, CheckEven);

        Console.WriteLine("================================");

        // use LAMBDA syntax to define the delegate inline and anonymous
        ProcessList(numbers, (n) => { 
        
            if (n % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        });
        Console.WriteLine("================================");

        // couple of refinements
        // if the LAMBDA only has a single parameter you can leave out the ()
        // tighten up the logic
        // if the LAMBDA only has a single line then you can remove {}, return and ;
        ProcessList(numbers, n => n % 2 == 0);


        // Debugging tip - add back in the curly brackets and put in a console.writeline to 
        // see that this is a function that is being called.
        ProcessList(numbers, n =>
        {
            Console.WriteLine($"checking {n}");
            return n % 2 == 0;
        });



    }
}