using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDaoLibrary
{
    class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public override string ToString()
        {
            //return $"{Id} {Name} {Email} {(Active?"Active":"Inactive")}";
            return $"{Name}";
        }

    }
}
