namespace Methods
{
    using System;

    public class Student
    {
        public Student(string firstname, string lastname, DateTime birthday, string city, string hobby = "", string otherInfo = "")
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Birthday = birthday;
            this.City = city;
            this.Hobby = hobby;
            this.OtherInfo = otherInfo;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public string City { get; set; }

        public string Hobby { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student anotherStudent)
        {
            return this.Birthday < anotherStudent.Birthday;
        }
    }
}
