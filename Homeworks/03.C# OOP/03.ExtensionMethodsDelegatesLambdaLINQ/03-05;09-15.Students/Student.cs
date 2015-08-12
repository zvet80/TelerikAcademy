
namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public Student()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Tel = "";
            this.Email = "";

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public long FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Mark { get; set; }
        public int GroupNumber { get; set; }

        //Problem 3. First before last
        public static void FirstBeforeLast(List<Student> list)
        {
            var query =
                from s in list
                where s.FirstName.CompareTo(s.LastName) < 0
                select s;
            query.ForEach(s => Console.WriteLine(s));
        }

        //Problem 4. Age range
        public static void AgeRange(List<Student> list)
        {
            var query =
                from s in list
                where s.Age > 18 && s.Age < 24
                select s;
            query.ForEach(s => Console.WriteLine(s));
        }


        public override string ToString()
        {
            return string.Format("{0} {1}",
                this.FirstName, this.LastName);
        }
    }
}
