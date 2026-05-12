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
            bmpOutputFile.WriteLine("This will be the first line in the file");

            // You can use the $ and include variables just like with Console.WriteLine
            string bmpColor = "Blue";
            bmpOutputFile.WriteLine($"My favorite color is {bmpColor}");

        }
        
    }
}