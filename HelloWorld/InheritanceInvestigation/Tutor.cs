using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInvestigation
{
    internal class Tutor : Contractor, ITeacher
    {
        public Tutor() { }

        public Tutor(string firstName, 
            string lastName, 
            string agency) 
            : base(firstName, lastName, agency)
        {
        }

        public void Teach()
        {
            Console.WriteLine("Tutorial starting...");
        }
    }
}
