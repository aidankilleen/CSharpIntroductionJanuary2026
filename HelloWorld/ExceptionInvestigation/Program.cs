using System.Numerics;

Console.WriteLine("Exception Investigation");


int x = 10;
int y = 0;
int[] list = { 1, 2, 3, 4, 5 };
int answer = -1;

Random rg = new Random();

int r = rg.Next(4);

Exception[] exceptions = { new IndexOutOfRangeException(), new DivideByZeroException() };

foreach (var ex in exceptions)
{
    throw ex;
}



try
{
    if (r==0)
    {
        answer = x / y;
    } else if (r==1)
    {
        answer = Int32.Parse("ninety nine");
    } else if (r == 2)
    {
        answer = list[5];
    } else
    {
        answer = 42;
    }
} 
catch(IndexOutOfRangeException iorex)
{
    Console.WriteLine("Index out of range");
    answer = list[list.Length - 1];
}
catch(DivideByZeroException dex)
{
    Console.WriteLine("You can't divide by zero");
    answer = 1;
}
catch (Exception e)
{
    // catch all exception
    answer = 0;
    Console.WriteLine("Something went wrong");
    Console.WriteLine(e.Message);
}
finally
{
    // gets called regardless of whether an exception occurred or not
    Console.WriteLine(answer);
}

Console.WriteLine("this also gets called after the exception block");


int ProcessNumbers(int a, int b)
{
    if (b == 0)
    {
        throw new InvalidDataException("you sent invalid data");
    }
    return a / b;
}

try
{
    Console.WriteLine(ProcessNumbers(10, 10));
    Console.WriteLine(ProcessNumbers(100, 0));
} catch (Exception ex)
{
    Console.WriteLine("something went wrong");
    Console.WriteLine(ex.Message);
}















// Exception handling 
// try {} you code
// safety net if things go wrong
/*
try
{
    DoSomething();
    DoSomethingElse();

} catch(NetworkException)
{

} catch(USerException ex)
{

}catch(ParameterException)
{

}
*/







// glass is half empty
/*int r = DoSomething();
if (r == -1)
{
    // network error
} else if (r == -2)
{
    // user error
} else if (r == -3)
{
    // parameter error
} else
{
    // actually worked
}
r = DoSomethingElse();
if (r == -1)
{
    // network error
}
else if (r == -2)
{
    // user error
}
else if (r == -3)
{
    // parameter error
}
else
{
    // actually worked
}*/








if (y != 0)
{


}






