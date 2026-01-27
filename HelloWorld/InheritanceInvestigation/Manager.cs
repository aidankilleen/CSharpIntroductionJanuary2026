using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInvestigation
{
    internal class Manager : Employee
    {
        public int HeadCount { get; set; }

        public Manager() { }

        public Manager(string firstName, 
            string lastName, 
            string employeeId, 
            int headCount)
            :base(firstName, lastName, employeeId)
        {
            HeadCount = headCount;
        }

        public override void Display()
        {
            Console.WriteLine("Manager:");
            base.Display();
            Console.WriteLine($"HeadCount:{ HeadCount }");
        }
    }
}
