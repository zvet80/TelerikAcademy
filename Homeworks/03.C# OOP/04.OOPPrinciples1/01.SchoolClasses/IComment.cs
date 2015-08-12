using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public interface IComment
    {
        string Comment { get;}
        void WriteComment(string text);
    }
}
