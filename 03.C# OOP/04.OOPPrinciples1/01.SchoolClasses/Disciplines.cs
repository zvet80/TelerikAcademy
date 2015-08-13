
namespace _01.SchoolClasses
{
    using System;

    public class Disciplines : IComment
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;


        public Disciplines(string name, int lectures, int exercises, string comment = "")
        {
            this.DisciplineName = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises;
            this.Comment = comment;
        }

        public string DisciplineName { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }

        public string Comment { get; set; }

        public void WriteComment(string text)
        {
            this.Comment = text;
            Console.WriteLine("Discipline comment {0}", this.Comment);
        }
    }
}
