//Problem 9. Delete odd lines
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\file.txt");

        List<string> even = new List<string>();
        int lineNumber = 0;

        using (reader)
        {
            string line = reader.ReadLine();
            Console.WriteLine("Initial file:");
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine(line);
                if ((lineNumber % 2) == 0)
                {
                    even.Add(line);
                }
                line = reader.ReadLine();
            }
        }
        StreamWriter writer = new StreamWriter(@"..\..\file.txt");
        using (writer)
        {
            for (int i = 0; i < even.Count; i++)
            {
                writer.WriteLine(even[i]);
            }
        }
        Console.WriteLine("see result in {0}", Path.GetFullPath(@"..\..\file.txt"));
    }
}

