using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    class Program
    {
        static void Main()
        {
            string[] arr = new string[] { "www", "rtr", "wwwwwww", "qqaa", "op" };

            var longest =
                from x in arr                
                orderby  x.Length descending
                select x;
            Console.WriteLine(longest.FirstOrDefault());
            

           
        }
    }
}
