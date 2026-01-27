using InheritanceInvestigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal partial class PolymorphismInvestigation
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Polymorphism Investigation");

        // Person[] team = new Person[255];


        Person[] team =
        {
            new Person("Alice", "Adams"),
            new Employee("Bob", "Burns", "E12345"),
            new Contractor("Carol", "Conway", "CPL"),
            new Manager("Danielle", "Dunne", "E54321", 25)
        };


        
        foreach (Person person in team)
        {
            person.Display();
        }
    }
    
}