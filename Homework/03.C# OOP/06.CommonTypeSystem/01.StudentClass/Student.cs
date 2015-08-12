
namespace _01.StudentClass
{
    using System;

    class Student : ICloneable, IComparable
    {
        public Student()
        {
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public override bool Equals(object st)
        {
            Student otherSt = st as Student;
            if (this.FirstName == otherSt.FirstName
                && this.LastName == otherSt.LastName)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Student st1, Student st2)
        {
            return st1.Equals(st2);
        }

        public static bool operator !=(Student st1, Student st2)
        {
            return !st1.Equals(st2);
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}\nLast Name {1}\nSpecialty: {2}\nSSN: {3}",
                this.FirstName, this.LastName, this.Specialty, this.SSN);
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public object Clone()
        {
            var newSt = new Student()
            {
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                SSN = this.SSN,
                PermanentAddress = this.PermanentAddress,
                MobilePhone = this.MobilePhone,
                Email = this.Email,
                Course = this.Course,
                Specialty = this.Specialty,
                University = this.University,
                Faculty = this.Faculty
            };
            return newSt;
        }

        public int CompareTo(object st)
        {
            var otherSt = st as Student;
            string fullNameSt = otherSt.FirstName + otherSt.MiddleName + otherSt.LastName;
            string fullName = this.FirstName + this.MiddleName + this.LastName;

            if (fullName.CompareTo(fullNameSt) == 0)
            {
                return this.SSN.CompareTo(otherSt.SSN);
            }
            return fullName.CompareTo(fullNameSt);
        }
    }
}
