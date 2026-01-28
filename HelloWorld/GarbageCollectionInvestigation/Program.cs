namespace GarbageCollectionInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Garbage Collection Investigation");

            LargeObject lo;

            for (int i = 0;i<10000; i++)
            {
                lo = new LargeObject();

            }

            Console.WriteLine("Finished");
            Console.WriteLine($"Final count: {LargeObject.count}");
        }
    }
}
