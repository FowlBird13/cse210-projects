using System;

class Program
{
    static void Main(string[] args)
    {
        int bmpMagicNum;

        Random bmpRandomGenerator = new Random();
        bool bmpPlayingFlag = true;

        do
        {
            bmpMagicNum = bmpRandomGenerator.Next(1,100);

            // Console.Write("What is the magic number? ");
            // bmpMagicNum = int.Parse(Console.ReadLine());
            
            string bmpOutputMsg;
            bool bmpGuessingFlag = true;
            int bmpGuessNum;
            int bmpGuessCount = 0;

            do 
            {
                Console.Write("What is your guess? ");
                bmpGuessNum = int.Parse(Console.ReadLine());
                bmpGuessCount++;

                if (bmpMagicNum == bmpGuessNum)
                {
                    bmpOutputMsg = "You guessed it!";
                    bmpGuessingFlag = false;
                } else if (bmpGuessNum > bmpMagicNum)
                {
                    
                    bmpOutputMsg = "Lower";
                } else //no if statement here because any number that isn't equal to or greater will be lower
                {
                    bmpOutputMsg = "Higher";
                }
                Console.WriteLine(bmpOutputMsg);
                
            } while (bmpGuessingFlag);
            Console.WriteLine($"It took you {bmpGuessCount} guesses!");
            Console.Write("Do you want to play again? ");
            if (Console.ReadLine().ToLower() == "no")
            {
                bmpPlayingFlag = false;
            }
        } while (bmpPlayingFlag);
    }
}