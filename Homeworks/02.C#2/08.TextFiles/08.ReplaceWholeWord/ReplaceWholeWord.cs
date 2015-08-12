//Problem 8. Replace whole word
//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;

    class ReplaceWholeWord
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
                        writer.WriteLine(Regex.Replace(line.ToLower(), @"\bstart\b", "finish")); 
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("ready");
        }
    }

