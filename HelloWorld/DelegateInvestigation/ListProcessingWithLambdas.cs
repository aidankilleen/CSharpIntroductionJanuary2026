using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDaoLibrary;

namespace DelegateInvestigation
{
    internal class ListProcessingWithLambdas
    {
        static void MyAction(User u)
        {
            Console.WriteLine(u.Name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("List Processing With Lambdas");

            var dao = new UserDao();

            var users = dao.GetAll();

            // you could define the Action as a separate function
            users.ForEach(MyAction);

            // more norally you would use a LAMBDA
            users.ForEach(user => Console.WriteLine(user));

            Console.WriteLine("================================");

            User u = users.Find(user => user.Name.Equals("Alice"));

            Console.WriteLine(u);

            var activeUsers = users.FindAll(user => user.Active);

            foreach (var au in activeUsers)
            {
                Console.WriteLine(au);
            }

            Console.WriteLine("================================");
            Console.WriteLine("Sorting");
            users.Sort((a, b) =>
            {
                Console.WriteLine($"Comparing {a.Name} - {b.Name}");
                if (b.Id < a.Id)
                {
                    return -1;
                } else if (a.Id == b.Id)
                {
                    return 0;
                } else
                {
                    return 1;
                }
            });

            foreach (var us in users)
            {
                Console.WriteLine(us);
            }


            Console.WriteLine("================================");
            Console.WriteLine("Sorting");
            users.Sort((a, b) => (int)(a.Id - b.Id));

            foreach (var us in users)
            {
                Console.WriteLine(us);
            }

            // you can often chain these together
            users.FindAll(user => user.Active)
                .ForEach(user => Console.WriteLine(user));

            // you can't chain the Sort() because Sort() returns void
        }
    }
}
