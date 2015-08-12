//Problem 12. Remove words
//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Linq;

class RemoveWords
{
    static void Main()
    {
        try
        {
            StreamReader textReader = new StreamReader(@"..\..\text.txt");
            StreamReader wordsReader = new StreamReader(@"..\..\words.txt");
            StreamWriter fileWriter = new StreamWriter(@"..\..\ouput.txt");
            string[] words = wordsReader.ReadToEnd().Split(' ', '\n', '\t', '\r');


            using (fileWriter)
            {

                using (textReader)
                {
                    string line = textReader.ReadLine();
                    while (line != null)
                    {
                        string[] text = line.Split(' ');
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (words.Contains(text[i]))
                            {
                                text[i] = "";
                            }
                        }

                        fileWriter.WriteLine(string.Join(" ", text));
                        line = textReader.ReadLine();
                    }
                }
                Console.WriteLine("ready");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

