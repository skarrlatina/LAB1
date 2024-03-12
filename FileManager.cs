using Lab_1.Models;
using System.Collections.Generic;
using System.IO;

namespace Lab_1.Resources
{
    internal class FileManager
    {
        public static void ReadFromFile(List<StudentVm> studentsList)
        {
            studentsList.Clear();
            using (StreamReader sr = new StreamReader("INFO.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');

                    if (parts.Length >= 5)
                    {
                        string name = parts[0];
                        string surname = parts[1];
                        bool gender = bool.Parse(parts[2]);
                        short course = short.Parse(parts[3]);
                        short group = short.Parse(parts[4]);

                        StudentVm student = new StudentVm(name, surname, gender, course, group);
                        studentsList.Add(student);
                    }
                }
            }
        }
        public static void WriteToFile(List<StudentVm> students)
        {
            var sortedList = Sort.SortBySurname(students);

            using (StreamWriter sw = new StreamWriter("INFO.txt"))
            {
                foreach (var student in sortedList)
                {
                    string line = $"{student.Name} {student.Surname} {student.Gender} {student.Course} {student.Group}";
                    sw.WriteLine(line);
                }
            }
        }
    }
}
