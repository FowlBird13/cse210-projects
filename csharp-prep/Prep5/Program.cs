using System;

class Program
{
    static void Main(string[] args)
    {
        //Print a nice welcome message to the console.
        static void BmpDisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        //Ask for and return the user's name.
        static string BmpPromptUserName()
        {
            Console.Write("Please enter your name: ");
            string bmpName = Console.ReadLine();
            return bmpName;
        }

        //Ask for and return the user's favorite number.
        static int BmpPromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }

        //Accepts an out integer parameter, prompts the user for their birth year,
        //then sets the parameter to that year.
        static void BmpPromptUserBirthYear(out int year)
        {
            Console.Write("Please enter the year you were born: ");
            year = int.Parse(Console.ReadLine());
        }

        //Square the inputed number
        static int BmpSquareNumber(int bmpNum)
        {
            return bmpNum * bmpNum;
        }

        //Dsiplay the results of the functions created earlier
        static void BmpDisplayResult(string bmpName, int bmpSquaredNum, int bmpBirthYear)
        {
            Console.WriteLine($"{bmpName}, the square of your number is: {bmpSquaredNum}");
            Console.WriteLine($"{bmpName}, you will turn {2026 - bmpBirthYear} this year.");
        }

        //Pull the lever Kronk!
        BmpDisplayWelcome();
        string bmpName = BmpPromptUserName();
        int bmpFavNum = BmpPromptUserNumber();
        int bmpBirthYear;
        BmpPromptUserBirthYear(out bmpBirthYear);
        int bmpSquaredNum = BmpSquareNumber(bmpFavNum);
        BmpDisplayResult(bmpName, bmpSquaredNum, bmpBirthYear);
    }
}