using StaticInvestigation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Static Investigation");

        Message m = new Message("Message 1",
            "This is the message");
        Console.WriteLine(Message.count);

        Message m2 = new Message("Message 2",
            "This is the message");
        Console.WriteLine(Message.count);

        // we don't instantiate Console
        //Console c = new Console();
        //c.WriteLine()

        // all the functions in the Math object
        // are static
        Math.Sin(90);

        // static values are often used for constants
        Console.WriteLine(Math.PI);


        int n = int.Parse("99");
        double d = double.Parse("99.1231223");
        bool b = bool.Parse("true");


        
    }
}