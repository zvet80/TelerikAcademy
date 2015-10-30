namespace _01.School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _01.StudentsAndCourses;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void TestCreateValidSchoolShouldNotThrow()
        {
            var school = new School("TA");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullSchoolNameShouldThrow()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEmptySchoolNameShouldThrow()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        public void TestSchoolHasExpectedName()
        {
            var school = new School("TA");
            Assert.AreEqual("TA", school.Name);
        }

        [TestMethod]
        public void TestSchoolAddCorrectCourseShouldNotThrow()
        {
            var course = new Course("C#");
            var school = new School("TA");
            school.AddCourse(course);
            Assert.AreEqual(course, school.Courses[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolAddNullCourseShouldThrow()
        {
            var school = new School("TA");
            Course course = null;
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSchoolAddSameCourseShouldThrow()
        {
            var course = new Course("C#");
            var school = new School("TA");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolRemoveNullCourseShouldThrow()
        {
            var school = new School("TA");
            Course course = null;
            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSchoolRemoveNotExistantCourseShouldThrow()
        {
            var course = new Course("C#");
            var school = new School("TA");
            school.RemoveCourse(course);
        }

        [TestMethod]
        public void TestSchoolRemoveExistantCourseShouldNotThrow()
        {
            var course = new Course("C#");
            var school = new School("TA");
            school.AddCourse(course);
            school.RemoveCourse(course);

            Assert.IsFalse(school.Courses.Contains(course));
        }
    }
}
