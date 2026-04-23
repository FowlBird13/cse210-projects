// Incredible code created by Bradley Mark Peterson on 4/23/26 for cs210.
// There was something else I was supposed to put in this header comment
// but I can't remember what...
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your first name? ");
        string bmpfirstName = Console.ReadLine();
        Console.Write("What's your last name? ");
        string bmplastName = Console.ReadLine();
        Console.WriteLine($"Your name is {bmplastName}, {bmpfirstName} {bmplastName}.");
    }
}