namespace _01.School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _01.StudentsAndCourses;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestCreateValidStudentShouldNotThrow()
        {
            var student = new Student("Pesho", 10111);
        }

        [TestMethod]
        public void TestStudentHasExpectedName()
        {
            var student = new Student("Pesho", 10111);
            Assert.AreEqual("Pesho", student.Name);
        }

        [TestMethod]
        public void TestStudentHasExpectedId()
        {
            var student = new Student("Pesho", 10111);
            Assert.AreEqual(10111, student.StudentId);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullStudentNameShouldThrow()
        {
            var student = new Student(null, 10111);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEmptyStudentNameShouldThrow()
        {
            var student = new Student(string.Empty, 10111);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestInvalidLowStudentIdShouldThrow()
        {
            var student = new Student("Pesho", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestInvalidHighStudentIdShouldThrow()
        {
            var student = new Student("Pesho", 100000);
        }
    }
}
