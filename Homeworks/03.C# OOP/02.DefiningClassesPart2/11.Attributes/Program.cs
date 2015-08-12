using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Attributes
{
    class Program
    {
        static void Main()
        {
            Type type = typeof(Program);
            object[] attr = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}
