// See https://aka.ms/new-console-template for more information
using OOInvestigation;

Console.WriteLine("OO Investigation");


User u = new User();
u.Id = 1;
u.Name = "Alice";
u.Email = "alice@gmail.com";
u.Active = true;

// you can instantiate the object and
// assign properties using{}
User u2 = new User
{
    Id = 2,
    Name = "Bob",
    Email = "bob@gmail.com",
    Active = true
};
Console.WriteLine(u.ToString());

// ToString is called implicitly
// any time my object is used but 
// c# needs a string
Console.WriteLine(u);
Console.WriteLine(u2);


