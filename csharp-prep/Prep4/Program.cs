using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> bmpNumbers = new List<int>();

        bool bmpAddNumFlag = true;
        int bmpNewNum;
        do
        {
            Console.Write("Enter number: ");
            bmpNewNum = int.Parse(Console.ReadLine());

            if (bmpNewNum == 0)
            {
                bmpAddNumFlag = false;
            } else
            {
                bmpNumbers.Add(bmpNewNum);
            }
        } while (bmpAddNumFlag);

        //compute the sum of the numbers list
        float bmpSum = 0;
        foreach (int bmpNum in bmpNumbers)
        {
            bmpSum+=bmpNum;
        }

        //Compute the average of the numbers list
        float bmpAverage = bmpSum / bmpNumbers.Count();

        //compare each number to the previous most large number in the list
        //to determine the largest number. Starts with the first index.
        int bmpLargest = bmpNumbers[0];
        foreach (int bmpNum in bmpNumbers)
        {
            if (bmpLargest < bmpNum)
            {
                bmpLargest = bmpNum;
            }
        }

        Console.WriteLine($"The sum is {bmpSum}");
        Console.WriteLine($"The average is {bmpAverage}");
        Console.WriteLine($"The largest number is {bmpLargest}");

        //Stretch challenges
        //find the closest positive number to zero
        //Oh no! You're telling me I can't map(), filter(), and sort() like in Python!?
        //I have to do it with loops!? I miss my list comprehension...
        List<int> bmpPositiveNums = new List<int>();
        
        //filter out the positive numbers
        foreach (int bmpNum in bmpNumbers)
        {
            if (bmpNum > 0)
            {
                bmpPositiveNums.Add(bmpNum);
            }
        }

        //find the smallest number
        //I want to add a conditional to check if all of the numbers are NOT positive but I 
        //don't think it matters too much
        int bmpClosestToZero = bmpPositiveNums[0];
        foreach (int bmpNum in bmpPositiveNums)
        {
            if (bmpClosestToZero > bmpNum)
            {
                bmpClosestToZero = bmpNum;
            }
        }
        
        Console.WriteLine($"The smallest positive number is: {bmpClosestToZero}");

        //sort the list from smallest to largest
        //little tiny bubble sort algorithm
        List<int> bmpSortedNums = bmpNumbers;
        bool bmpDidSort;
        do
        {
            bmpDidSort = false;
            for (int i=0; i < (bmpSortedNums.Count() - 1);i++)
            {
                if (bmpSortedNums[i] > bmpSortedNums[i + 1])
                {
                    //swap the two numbers if the first is larger than the second
                    int bmpStoredNum = bmpSortedNums[i];
                    bmpSortedNums[i] = bmpSortedNums[i+1];
                    bmpSortedNums[i+1] = bmpStoredNum;
                    bmpDidSort = true;
                }
            }
        } while (bmpDidSort);

        //print the sorted numbers
        foreach (int bpmNum in bmpSortedNums)
        {
            Console.WriteLine(bpmNum);
        }

    }
}