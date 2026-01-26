using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person
    {
        // data / member variables
        private int _id;
        //private string name;

        public string Name { get; set; }

        private string email;
        private bool active;
        public int age;

        // C# Property
        public int Id {  
            get {
                Console.WriteLine("get called");
                return _id; 
            } 
            set {
                Console.WriteLine("set called");
                if (value < 0)
                {
                    Console.WriteLine("invalid value");
                } else
                {
                    _id = value; 
                }
            } 
        }




/*        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            if (id > 0)
            {

                this.id = id;
            }
            else
            {
                Console.WriteLine("error");
            }
        }*/
        // constructor
        public Person(int id, string name, 
                        string email, bool active)
        {
            if (id>0)
            {
                this._id = id;

            }
            this.Name = name;
            this.email = email;
            this.active = active;
            
        }

        public void Display()
        {
            Console.WriteLine("Person:" + Id);
            Console.WriteLine(Name);
            Console.WriteLine(email);
            Console.WriteLine(active?"Active":"Inactive");
        }

    }
}
