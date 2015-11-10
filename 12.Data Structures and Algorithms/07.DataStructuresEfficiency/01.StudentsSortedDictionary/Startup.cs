namespace _01.StudentsSortedDictionary
{
    /*1.A text file students.txt holds information about students and their courses in the following format:
        Using SortedDictionary<K,T> print the courses in alphabetical order and for each of them prints the students ordered by family and then by name:
        Kiril  | Ivanov   | C#
        Stefka | Nikolova | SQL
        Stela  | Mineva   | Java
        Milena | Petrova  | C#
        Ivan   | Grigorov | C#
        Ivan   | Kolev    | SQL
        C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
        Java: Stela Mineva
        SQL: Ivan Kolev, Stefka Nikolova*/

    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            var data = ReadDataFromFile(@"..\..\Students.txt");

            foreach (var course in data)
            {
                Console.WriteLine("{0}: {1}", course.Key, string.Join(", ", course.Value));
            }
        }

        public static SortedDictionary<string, SortedSet<Student>> ReadDataFromFile(string path)
        {
            var reader = new StreamReader(path);
            SortedDictionary<string, SortedSet<Student>> data = new SortedDictionary<string, SortedSet<Student>>();
            using (reader)
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var info = line.Split(new[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Student student = new Student(info[0], info[1]);
                    string course = info[2];
                    if (!data.ContainsKey(course))
                    {
                        data.Add(course, new SortedSet<Student>());
                    }

                    data[course].Add(student);

                    line = reader.ReadLine();
                }
            }

            return data;
        }
    }
}