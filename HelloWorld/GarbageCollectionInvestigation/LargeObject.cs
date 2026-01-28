using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionInvestigation
{
    class LargeObject
    {
        public static int count = 0;
        public string[] info = new string[1000];

        public LargeObject() {
            if (count % 100 == 0)
            {
                Console.WriteLine($"Creating item {count}");
            }
            count++;
        }

        ~LargeObject()
        {
            Console.WriteLine($"Destroying object {count}");
            count--;
        }
    }
}
