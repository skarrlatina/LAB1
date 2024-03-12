using System;

namespace Lab_1.Models
{
    public class StudentVm
    {

        String str1 = "31";
        string str;
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public short Course { get; set; }
        public short Group { get; set; }

        public StudentVm(string name, string surname, bool gender, short course, short group)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Course = course;
            Group = group;
        }
    }
}
