using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInvestigation
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            return "User:" + Id + "\n" 
                + Name + "\n"
                + Email + "\n"
                + (Active ? "Active": "Inactive"); 
        }
    }
}
