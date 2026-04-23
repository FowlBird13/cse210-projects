/*
This incredible code was created by Bradley Mark Peterson on 4/23/26
for his cs210 class. There was definitely another thing I needed to 
add to this header comment, but I can't remember what...
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent? ");
        float bmppercent = -1;
        bool bmpflag = true;
        while (bmpflag)
        {
            try
            {
                bmppercent = float.Parse(Console.ReadLine());
                bmpflag = false;
            } catch (FormatException e)
            {
                Console.WriteLine("The input was unable to be be converted to a number. Please enter a number");
            }
        }
        string bmpletterGrade;
        if (bmppercent < 0)
        {
            throw new ArgumentException("Percentage argument is below 0 or was incorrectly evaluated.");
        } else if (bmppercent >= 90)
        {
            bmpletterGrade = "A";
        }
        else if (bmppercent >= 80)
        {
            bmpletterGrade = "B";
        }
        else if (bmppercent >= 70)
        {
            bmpletterGrade = "C";
        }
        else if (bmppercent >= 60)
        {
            bmpletterGrade = "D";
        }
        else
        {
            bmpletterGrade = "F";
        }

        // This line might be the most scuffed piece of comprehension I've ever done
        // but I'm still learning C# so it's okay for now.
        string bmpmodifierChar = ((bmppercent % 10) >= 7) ? "+" : 
            (((bmppercent % 10) < 3) ? "-" : "");

        //Remove the "+" modifier if the grade is an "A" because there are no A+'s in 
        // this school. Also, remove all modifiers from any "F" grade.
        if ((bmpletterGrade == "A" && bmpmodifierChar == "+")||(bmpletterGrade == "F"))
        {
            bmpmodifierChar = "";
        }

        Console.WriteLine($"Your letter grade is {bmpletterGrade}{bmpmodifierChar}");

        if (bmppercent >= 70)
        {
            Console.WriteLine("You passed the class! Well done!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Better luck next time.");
        }
    }
}