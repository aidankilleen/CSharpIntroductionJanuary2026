using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullInvestigation
{
    class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public bool Active { get; set; }

        /*public User()
        {
            Name = "";
            Email = "";
        }
        */

    }
}
