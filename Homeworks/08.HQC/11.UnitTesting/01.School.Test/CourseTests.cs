namespace _01.School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _01.StudentsAndCourses;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void TestCreateValidCourseShouldNotThrow()
        {
            var course = new Course("C#");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullCourseNameShouldThrow()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEmptyCourseNameShouldThrow()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void TestCourseHasExpectedName()
        {
            var course = new Course("C#");
            Assert.AreEqual("C#", course.Name);
        }

        [TestMethod]
        public void TestCourseAddCorrectStudentShouldNotThrow()
        {
            var course = new Course("C#");
            var student = new Student("Pesho", 10111);
            course.JoinCourse(student);
            Assert.AreEqual(student, course.Students[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseAddNullStudentShouldThrow()
        {
            var course = new Course("C#");
            Student student = null;
            course.JoinCourse(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestCourseAddMoreThanMaxStudentsShouldThrow()
        {
            var course = new Course("C#");

            for (int i = 0; i < 40; i++)
            {
                course.JoinCourse(new Student("Student" + i, 10000 + i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestCourseAddSameStudentShouldThrow()
        {
            var course = new Course("C#");
            var student = new Student("Pesho", 10111);
            course.JoinCourse(student);
            course.JoinCourse(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseRemoveNullStudentShouldThrow()
        {
            var course = new Course("C#");
            Student student = null;
            course.LeaveCourse(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestCourseRemoveNotExistantStudentShouldThrow()
        {
            var course = new Course("C#");
            var student = new Student("Pesho", 10111);
            course.LeaveCourse(student);
        }

        [TestMethod]
        public void TestCourseRemoveExistantStudentShouldNotThrow()
        {
            var course = new Course("C#");
            var student = new Student("Pesho", 10111);
            course.JoinCourse(student);
            course.LeaveCourse(student);

            Assert.IsFalse(course.Students.Contains(student));
        }
    }
}
