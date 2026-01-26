// Program.cs
// By: Aidan
// Date: 26/1/2026

/*
 *  multi line comments 
 * 
 * 
 * 
 */

// Variables


using HelloWorld;
using System.Collections;
using System.Security.Cryptography;

int i = 10;
double d = 1.23456;
string message = "Welcome to C# Programming";

// variables are strongly typed
//message = 99;

Console.WriteLine(message);
message = "These are the building blocks";
Console.WriteLine(message);

// you must assign a value
// var j;
// j = 99;


// nameing conventions
string name = "Aidan";
string firstName = "Aidan"; // preferred
string Name = "Aidan"; // allowed but not encouraged
string FirstName = "Aidan"; // don't start with a capital
string first_name = "Aidan"; // allowed but don't use _
//string first-name = "Aidan"; // can't use dashes

// in C# we use lower camel case 




// Building Block #3 - expressions

var ii = 10;
var jj = 20;

// PEMDAS
// Parenthesis
// Exponents
// Multiplication
// Division
// Addition
// Subtraction

// strong recommendation - use brackets (parenthesis)
var answer = ((ii * jj) + 10) / 33 - (100 ^ 2);

double danswer = 100 / 3;

Console.WriteLine(danswer);


//  Building Block #4 - loop
// while loop
i = 1;
while (i <= 10) 
{
    Console.WriteLine(i);
    i = i + 1;
}

// for loop
for (var x = 0; x <= 10; x++)
{
    Console.WriteLine(x);
}


// Building block #6
// Conditions

var n = 10;

if (n < 5)
{
    Console.WriteLine("small");
}
else if (n < 7)
{
    Console.WriteLine("medium");
}
else
{
   Console.WriteLine("large");
}

// Ternary operator
message = "The number is " + (n < 5 ? "small" : "large");

// equivalent to
/*if (n < 5)
{
    message = "The number is small";
} 
else
{
    message = "The number is large";
}*/

message = "The number is" + (n<5 ? "small" : n<7 ? "medium" : "large");


// Building Block #7 - array / list
int[] numbers = { 1, 6, 4, 3, 2, 8, 10, 8, 9 };

Console.WriteLine(numbers[1]); // index 1 is the second item!
Console.WriteLine(numbers.Length);
// Console.WriteLine(numbers[numbers.Length]); // numbers[9]

// iterate the items in the list
for (i=0; i<numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}


foreach(var num in numbers)
{
    Console.WriteLine(num);
}

var smaller = Math.Min(10, 20);



// Building Block #8 - Functions
Console.WriteLine();


int ProcessValues(int a, int b)
{
    return a + b;
}

answer = ProcessValues(10, 20);



Console.WriteLine(answer);

// Building Block #9 - Objects

string text = "This is some text";

Console.WriteLine(text);

Console.WriteLine(text.ToUpper());

text = text.ToUpper();

Console.WriteLine(numbers.Length);

//int i = 99;

// instantiate an instance of the Random class
Random rg = new Random();
int r = rg.Next(100);
Console.WriteLine(r);


Console.WriteLine("=========================");
Person p = new Person(1, "Alice", 
            "alice@gmail.com", true);
p.Display();

Person p2 = new Person(-1, "Bob", 
            "bob@gmail.com", false);
p2.Display();

//p2.name = "John";

//Console.WriteLine(p2.getId());

//p2.id = -999;
//p2.setId(-9999);

p2.Display();


//p2.age = 999;

Console.WriteLine(p.Id);
p.Id = 1;

Console.WriteLine(p.Name);
p.Name = "Fred";












Console.WriteLine("Finished");











































