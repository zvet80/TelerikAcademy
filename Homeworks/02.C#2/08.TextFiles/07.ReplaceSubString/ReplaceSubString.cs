//Problem 7. Replace sub-string
//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

    class ReplaceSubString
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\input.txt");
            StreamWriter writer = new StreamWriter(@"..\..\ouput.txt");

            using (writer)
            {
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(line.ToLower().Replace("start", "finish"));
                        line = reader.ReadLine();
                    }                    
                }
            }
            Console.WriteLine("ready");
        }
    }

