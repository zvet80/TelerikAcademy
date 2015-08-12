//Problem 10. Extract text from XML
//Write a program that extracts from given XML file all the text without the tags.
//Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

using System;
using System.Collections.Generic;
using System.IO;

class ExtractTextFromXML
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        List<string> info = new List<string>();

        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                int i = 0;
                while (i < line.Length - 1)
                {
                    if ((line.IndexOf('>', i) != -1)
                        && (line.IndexOf('>', i) != line.Length - 1)
                        && (line.IndexOf('<', line.IndexOf('>', i)) != line.IndexOf('>', i) + 1))
                    {
                        info.Add(line.Substring(line.IndexOf('>', i) + 1,
                            line.IndexOf('<', line.IndexOf('>', i)) - 1 - line.IndexOf('>', i)));
                        i = line.IndexOf('<', line.IndexOf('>', i)) + 1;
                    }
                    else
                    {
                        i++;
                    }
                }
                line = reader.ReadLine();
            }
        }
        Console.WriteLine(string.Join(",", info));
    }
}
