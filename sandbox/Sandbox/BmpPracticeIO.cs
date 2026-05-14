// This lets C# know where to find the StreamWriter class
using System;
using System.IO;

class BmpPracticeIO
{
    static void Main(string[] args)
    {
        string bmpFileName = "bmpMyFile.txt";

        using (StreamWriter bmpOutputFile = new StreamWriter(bmpFileName))
        {
            // You can add text to the file with the WriteLine method
            bmpOutputFile.WriteLine("What do a hamster and a cigarette have in common?");

            // You can use the $ and include variables just like with Console.WriteLine
            // string bmpColor = "Blue";
            bmpOutputFile.WriteLine($"They're both harmless until you light them on fire and stick them in your mouth.");

        }
        
        string[] bmpLines = System.IO.File.ReadAllLines(bmpFileName);
        

        string bmpJoke = bmpLines[0];
        string bmpPunchline = bmpLines[1];

        //This loop is for splitting lines into more parts but not useful for this practice
        //      foreach (string bmpLine in bmpLines)
        //      {
        //          string[] parts = bmpLine.Split(",");
        //      }


        Console.WriteLine(bmpJoke);
        Console.WriteLine(bmpPunchline);
    }
}