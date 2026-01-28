using Microsoft.VisualBasic.FileIO;
using NullInvestigation;

Console.WriteLine("Null Investigation");

int z;


User u = new User {
    Id=1, 
    Name="Alice", 
    Active = true
};

int[] numbers = { 1, 2, 3 };

Console.WriteLine(numbers.Length);
Console.WriteLine(numbers[4]);


// deallocating memory
// new allocates memory in the "heap"  
//string s = new string("sdfasdfasdfs");

//delete s;   // failure to clean up dynamically allocated memory
// causes huge problems in the C/C++ world

// Java solved this using a technique called "garbage collection"
// in order to do this a runtime environment was needed (JVM)

// C# has the exact same idea - GC frees our memory so we don't have to





















/*
int x = 0;
x = null;

string s = "";
s = null;

// you can explicitly make someting nullable using ?
int? y = null;



int answer = z + x;

Console.WriteLine(answer);

*/
