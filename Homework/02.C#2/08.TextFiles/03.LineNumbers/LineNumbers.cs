//Problem 3. Line numbers
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.


using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\file.txt");
        StreamWriter writer = new StreamWriter(@"..\..\ouput.txt");

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                int lineNum = 0;
                while (line != null)
                {
                    lineNum++;
                    writer.WriteLine("{0}. {1}", lineNum, line);
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("ready");
    }
}

