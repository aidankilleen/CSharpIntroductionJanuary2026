
using InheritanceInvestigation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("OO Concepts - Inheritance");

        Person p = new Person("Alice", "Adams");

        p.Display();

        Employee e = new Employee("Bob",
                                    "Burns",
                                    "E12345");

        // all of the features of Person are 
        // available in Employee
        Console.WriteLine(e.FirstName);
        Console.WriteLine(e.LastName);
        Console.WriteLine(e.EmployeeId);

        e.Display();

        Contractor c = new Contractor("Carol",
            "Conway",
            "CPL");

        c.Display();

        Manager m = new Manager("Danielle",
                "Dunne",
                "E5432",
                25);

        m.Display();
    }
}