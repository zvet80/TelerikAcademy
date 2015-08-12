
namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass : IComment
    {

        public SchoolClass(string classID)
        {
            this.ClassID = classID;
            this.Teachers = new List<Teachers>();
            this.Comment = "";
        }

        public string ClassID { get; private set; }
        public List<Teachers> Teachers { get; set; }
        public string Comment { get; set; }

        public void AddToClass(List<Teachers> inClass, Teachers incomming)
        {
            this.Teachers.Add(incomming);
        }

        public void RemoveFromClass(List<Teachers> outClass, Teachers outgoing)
        {
            this.Teachers.Remove(outgoing);
        }

        public void WriteComment(string text)
        {
            this.Comment = text;
            Console.WriteLine("Class comment: {0}", this.Comment);
        }
    }
}
