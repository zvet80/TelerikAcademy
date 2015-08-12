
namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teachers : Person, IComment
    {
        private List<Disciplines> disciplines;

        public Teachers(string name, List<Disciplines> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        public List<Disciplines> Disciplines { get; set; }

        public string Comment { get; set; }

        public void WriteComment(string text)
        {
            this.Comment = text;
            Console.WriteLine("Teacher comment: {0}", this.Comment);
        }
    }
}
