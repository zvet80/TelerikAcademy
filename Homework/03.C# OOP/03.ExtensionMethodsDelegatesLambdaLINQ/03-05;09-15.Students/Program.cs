
namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            var listOfStudents = new List<Student>
            {
                new Student{FirstName = "Iva", LastName="Angelova", Age=15, GroupNumber = 2, Email="ia@yahoo.com",Tel="02639876", Mark= new List<int>{5,6},FN=1000006},
                new Student{FirstName = "Petar", LastName = "Ivanov", Age=20, GroupNumber=3, Email="pi@gmail.com", Mark=new List<int>{2,2,2,5,3},FN=1000406},
                new Student{FirstName = "Iskren",LastName = "Petrov", Age=34,GroupNumber=1, Email="ip@abv.bg", Mark= new List<int>{2,2,4},FN=1000005},
                new Student{FirstName = "Hristo",LastName = "Chipilov", Age=34,GroupNumber=2, Email="hr@abv.bg",Tel="1236478", Mark= new List<int>{5,6},FN=1052006}
            };
            var StudentGroups = new List<Group> 
            {
                new Group(1,"History"),
                new Group(2,"Mathematics"),
                new Group(3,"Biology")
            };
            Student.FirstBeforeLast(listOfStudents);
            Student.AgeRange(listOfStudents);

            //Problem 5. Order students
            Console.WriteLine("Students sorted by first name and last name in descending order:");

            listOfStudents
                          .OrderBy(s => s.FirstName)
                          .ThenByDescending(s => s.LastName)
                          .ForEach(s => Console.WriteLine(s));

            //Problem 9. Student groups
            Console.WriteLine("students that are from group number 2:");
            var query =
                from s in listOfStudents
                where s.GroupNumber == 2
                orderby s.FirstName
                select s;
            query.ForEach(s => Console.WriteLine(s));

            //Problem 10. Student groups extensions
            listOfStudents
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ForEach(x => Console.WriteLine(x));

            //Problem 11. Extract students by email
            Console.WriteLine("Students that have email in abv.bg:");
            var emailsQ =
                from s in listOfStudents
                where s.Email.Contains("@abv.bg")
                select s;
            emailsQ.ForEach(s => Console.WriteLine(s.FirstName));

            //Problem 12. Extract students by phone
            Console.WriteLine("Students with phones in Sofia:");
            var phonesQ =
                from s in listOfStudents
                where s.Tel.StartsWith("02")
                select s;
            phonesQ.ForEach(s => Console.WriteLine(s.FirstName));

            //Problem 13. Extract students by marks
            Console.WriteLine("Students that have at least one mark Excellent (6):");
            var markQ =
                from s in listOfStudents
                where s.Mark.Contains(6)
                select new
                {
                    FullName = s.FirstName + " " + s.LastName,
                    Marks = s.Mark
                };
            markQ.ForEach(s => Console.WriteLine(s.FullName + " " + string.Join(",", s.Marks)));

            //Problem 14. Extract students with two marks
            Console.WriteLine("students with exactly two marks \"2\":");
            listOfStudents
                .Where(x => x.Mark.FindAll(y => y == 2).Count == 2)
                .Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    Marks = x.Mark
                })
                .ForEach(x => Console.WriteLine(x.FullName + " " + string.Join(",", x.Marks)));

            //Problem 15. Extract marks
            Console.WriteLine("students that enrolled in 2006:");
            listOfStudents
                .Where(x => x.FN.ToString().EndsWith("06"))
                .ForEach(x => Console.WriteLine(x.FirstName + " " + string.Join(",", x.Mark)));

            //Problem 16.* Groups
            Console.WriteLine("All students from \"Mathematics\" department:");
            var groupQ =
                from s in listOfStudents
                join g in StudentGroups on s.GroupNumber equals g.GroupNumber
                where g.DepartmentName == "Mathematics"
                select s;

            groupQ.ForEach(s => Console.WriteLine(s.FirstName + " " + s.LastName));

            listOfStudents
                .Join(StudentGroups,
                s => s.GroupNumber,
                g => g.GroupNumber,
                (s, g) => new { name = s.FirstName, fn = s.FN, dept = g.DepartmentName })
                .Where(x => x.dept == "Mathematics")
                .ForEach(x => Console.WriteLine(x.name + " " + x.fn + " " + x.dept));

            // Problem 18. Grouped by GroupNumber
            var groupbyQ =
                from s in listOfStudents
                group s by s.GroupNumber into gr
                select new
                {
                    Group = gr.Key,
                    Students = gr.ToList()
                };
            foreach (var st in groupbyQ)
            {
                Console.WriteLine("Group: {0} Students:{1}", st.Group, string.Join(",", st.Students));
            }

            //Problem 19. Grouped by GroupName extensions
            var groups = listOfStudents
                .Join(StudentGroups,
                s => s.GroupNumber,
                g => g.GroupNumber,
                (s, g) => new { name = s.FirstName, dept = g.DepartmentName })
                .GroupBy(x => x.dept)
                .ToList();
                
            foreach (var gr in groups)
            {
                Console.WriteLine(gr.Key);
                foreach (var st in gr)
                {
                    Console.WriteLine(st.name);
                }
            }

            var groupedStudents2 = 
                listOfStudents.GroupBy(x => x.GroupNumber).
                Select(g => new { Group = g.Key, Students = g });

            foreach (var g in groupedStudents2)
            {
                Console.WriteLine("Members of {0}", g.Group);

                foreach (var member in g.Students)
                {
                    Console.WriteLine("---{0}", member.FirstName);
                }
            }
            var groupedStudents3 = listOfStudents.GroupBy(x => x.GroupNumber,
                (groupNumber, students) => new { Group = groupNumber, Students = students });

        }
    }
}
