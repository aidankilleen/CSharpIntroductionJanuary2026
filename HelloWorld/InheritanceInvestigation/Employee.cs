using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInvestigation
{
    internal class Employee : Person
    {
        public string EmployeeId { get; set; }

        public Employee()
        {
        }

        public Employee(string firstName, 
            string lastName, 
            string employeeId)
            : base(firstName, lastName)
        {
            EmployeeId = employeeId;
        }

        public override void Display()
        {
            Console.WriteLine("Employee:");
            //Console.WriteLine($"{ FirstName } {LastName}");
            base.Display(); // call the Person Display() method
            Console.WriteLine($"EmployeeID:{ EmployeeId }");
        }
    }
}
