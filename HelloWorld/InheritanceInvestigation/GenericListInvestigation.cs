using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInvestigation
{
    internal class GenericListInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic List Investigation");

            // List<> is type safe
            // the list is type safe - only Person objects can go in
            // team.Add("this is not a person object");
            // List<> behaves polymorphically
            // I can put items of type Person
            // or any class derived from Person
            List<Person> team = new List<Person>();


            team.Add(new Person("Alice", "Adams"));
            team.Add(new Employee("Bob", "Burns", "E12345"));
            team.Add(new Contractor("Carol", "Conway", "CPL"));
            team.Add(new Manager("Danielle", "Dunne", "E54321", 25));


            foreach (Person person in team)
            {
                person.Display();
            }

            Trainer tr = new Trainer("Eve", "Evans", "E3333");

            tr.Display();
            tr.Teach();


            Tutor tu = new Tutor("Fred", "Finn", "CPL");

            tu.Display();
            tu.Teach();
            Console.WriteLine("=========================");

            List<ITeacher> faculty = new List<ITeacher>();

            faculty.Add(new Trainer("Ger", "Griffin", "E444"));
            faculty.Add(new Tutor("Harriet", "Harding", "CPL"));
            faculty.Add(new Trainer("Ingrid", "Isaac", "E555"));

            foreach (var teacher in faculty)
            {
                //teacher.Display();

                teacher.Teach();

                // we can "cast" the teacher object into a Person
                Person p = (Person)teacher;
                p.Display();
            }










        }
    }
}
