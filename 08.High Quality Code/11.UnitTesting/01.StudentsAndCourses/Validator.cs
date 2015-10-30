namespace _01.StudentsAndCourses
{
    using System;

    public class Validator
    {
        public static void ObjectNotNullValidator(object obj, string message)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(string.Format("{0} cannot be null", message));
            }
        }

        public static void NameValidator(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be empty");
            }
        }

        public static void IdRangeValidator(int id, int min, int max)
        {
            if (id < min || id > max)
            {
                throw new ArgumentOutOfRangeException(string.Format("ID should be in the range [{0},{1}]", min, max));
            }
        }
    }
}
