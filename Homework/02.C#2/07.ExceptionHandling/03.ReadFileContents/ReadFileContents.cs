//Problem 3. Read file contents
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.


using System;
using System.Net;
using System.IO;

class ReadFileContents
{    
    static void Main()
    {
        Console.WriteLine("Enter full file path");
        string filePath = Console.ReadLine();        

        try
        {
            Console.WriteLine("text:\n {0}", File.ReadAllText(filePath));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        catch (System.IO.PathTooLongException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        catch (System.IO.IOException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        catch (System.Security.SecurityException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
    }
}


