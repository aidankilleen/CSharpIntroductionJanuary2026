Console.WriteLine("String Investigation");

int x = 10;
int y = 20;
int answer = x + y;

string message = "The answer is " + answer;

Console.WriteLine(message);

message = x + " + " + y + " = " + answer;

Console.WriteLine(message);

// use a templated string
message = $"{ x } + { y } = { answer }";

Console.WriteLine(message);

// note: you can put an expression into the {}
message = $"{ x } + { y } = { x + y }";

Console.WriteLine(message);

bool active = true;

message = $"The user is {(active ? "active" : "inactive")}";

Console.WriteLine(message);


Console.WriteLine("line 1\nline 2\nline 3");

Console.WriteLine("\t is a tab ");

Console.WriteLine("press the \"red\" button - \" is the quotation character");

// use \\ to get a single \ character into the string
string filename = "C:\\my document\\pictures\\img.jpg";

// raw string - ignore all the escape sequences
// use @ in front of the string for a raw string - no escapes recognised
filename = @"C:\my documents\pictures\img.jpg";

Console.WriteLine(filename);
Console.WriteLine(filename);

message = @"
This is a multi line

raw string
";

Console.WriteLine(message);


// you can have a templated raw string

message = @$"
  {x}
+ {y}
=====
  {x + y}
";


Console.WriteLine(message);

Console.WriteLine("=======================================");
message = "    one two three four    ";

var words = message.Trim().Split(" ");

Console.WriteLine(words.Length);

foreach (var word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine("Finished");




