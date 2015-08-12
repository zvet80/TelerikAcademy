
namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class School
    {
        public School(string name)
        {
            this.Name = name;
            this.Classes = new List<SchoolClass>();
        }

        public string Name { get; set; }
        public List<SchoolClass> Classes { get; set; }

    }
}
