//Problem 11. Prefix "test"
//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.IO;

class PrefixTest
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
                    string[] words = line.Split(' ');
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Substring(0, 4) == "test")
                        {
                            words[i] = "";
                        }
                    }
                    writer.WriteLine(string.Join(" ", words));
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("ready");
    }
}

