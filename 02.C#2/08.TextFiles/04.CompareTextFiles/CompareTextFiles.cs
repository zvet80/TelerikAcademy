//Problem 4. Compare text files
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        StreamReader firstFile = new StreamReader(@"..\..\file1.txt");
        StreamReader secondFile = new StreamReader(@"..\..\file2.txt");

        using (firstFile)
        {
            using (secondFile)
            {
                string line1 = firstFile.ReadLine();
                string line2 = secondFile.ReadLine();
                int countDiff = 0;
                int count = 0;
                while (line1 != null)
                {
                    if (line1 != line2)
                    {
                        countDiff++;
                    }
                    line1 = firstFile.ReadLine();
                    line2 = secondFile.ReadLine();
                    count++;
                }
                Console.WriteLine("number of equal lines: {0}\nnumber of different lines: {1}", count - countDiff, countDiff);
            }
        }

    }
}

