//Problem 2. Concatenate text files
//Write a program that concatenates two text files into another text file.


using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader firstFile = new StreamReader(@"..\..\file1.txt");
        StreamReader secondFile = new StreamReader(@"..\..\file2.txt");
        StreamWriter fileWriter = new StreamWriter(@"..\..\ouput.txt");

        using (fileWriter)
        {

            using (firstFile)
            {
                string line = firstFile.ReadLine();
                while (line != null)
                {
                    fileWriter.WriteLine(line);
                    line = firstFile.ReadLine();
                }
            }
            using (secondFile)
            {
                string line = secondFile.ReadLine();
                while (line != null)
                {
                    fileWriter.WriteLine(line);
                    line = secondFile.ReadLine();
                }
            }
        }
        Console.WriteLine("ready");        
    }
}

