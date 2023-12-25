// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");



if (func1() && func2())
    Console.WriteLine("Pasó");
else
    Console.WriteLine("NO Pasó");


Console.ReadLine();


bool func1()
{
    Console.WriteLine("func1 ");
return false;
}
bool func2()
{
    Console.WriteLine("func2");
return true;
}
