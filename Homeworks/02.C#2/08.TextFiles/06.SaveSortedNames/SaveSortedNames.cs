//Problem 6. Save sorted names
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.


using System;
using System.Collections.Generic;
using System.IO;

class SaveSortedNames
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
                List<string> names = new List<string>();
                while (line != null)
                {
                    names.Add(line);
                    line = reader.ReadLine();
                }
                names.Sort();
                foreach (string name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }
        Console.WriteLine("ready");
    }
}
