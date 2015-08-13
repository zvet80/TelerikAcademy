/*•	Write a program that parses an URL address given in the format:
         * [protocol]://[server]/[resource] and extracts from it the [protocol],
         * [server] and [resource] elements.*/

using System;

class ParseURL
{
    static void Main()
    {
        Console.WriteLine("Enter URL address");
        string url = Console.ReadLine();
        string protocol = url.Substring(0, url.IndexOf("://"));
        string rest = url.Substring(url.IndexOf("://")+3);
        string server = rest.Substring(0, rest.IndexOf('/'));
        string resource = rest.Substring(rest.IndexOf('/')+1);

        Console.WriteLine(protocol);
        Console.WriteLine(server);
        Console.WriteLine(resource);



    }
}
