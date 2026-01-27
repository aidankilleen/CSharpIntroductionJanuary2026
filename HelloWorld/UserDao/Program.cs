

using UserDaoLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("UserDAO");

        UserDao dao = new UserDao();
        List<User> users = dao.GetAll();

        foreach (User user in users)
        {
            Console.WriteLine(user);
        }

        User lastuser = users[users.Count - 1];

        /*
        int count = dao.Delete(lastuser.Id);

        if (count > 0)
        {
            Console.WriteLine("User was deleted");
        }
        */

        lastuser.Name = "Changed";
        lastuser.Email = "changed@gmail.com";
        lastuser.Active = !lastuser.Active;

        int count = dao.Update(lastuser);

        if (count > 0)
        {
            Console.WriteLine("User was updated");
        }

        User newUser = new User
        {
            Name = "New User",
            Email = "new.user@gmail.com",
            Active = true
        };

        User addedUser = dao.Add(newUser);

        // Id is not 0, Id is assigned by the database
        Console.WriteLine(addedUser);

        Console.WriteLine("Found User:");
        User userToFind = dao.GetById(addedUser.Id);
        Console.WriteLine(userToFind);




    }
}

