//Problem 4. Download file
//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
using System.IO;

class DownloadFile
{
    static string resourceName = "news-img01.png";
    static string internetPath = "http://telerikacademy.com/Content/Images/";
    static string internetResource = internetPath + resourceName;
    

    static void FreeResources()
    {
        File.Delete(resourceName);
    }

    static void Main()
    {        
        WebClient webClient = new WebClient();

        try
        {
            webClient.DownloadFile(internetResource, resourceName);
            Console.WriteLine("downloading to: {0}",Path.GetFullPath(resourceName));
        }
        catch (System.ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        catch (System.Net.WebException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        catch (System.NotSupportedException ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        finally
        {
            FreeResources();
        }
    }
}

