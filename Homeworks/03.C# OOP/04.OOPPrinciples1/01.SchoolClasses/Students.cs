
namespace _01.SchoolClasses
{
    using System;

    public class Students : Person, IComment
    {
        private int classNumber;

        public Students(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber { get; private set; }

        public string Comment { get; set; }

        public void WriteComment(string text)
        {
            this.Comment = text;
            Console.WriteLine("Student comment: {0}", this.Comment);
        }
    }
}
