using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        List<Student> studentsList;
        public Form1()
        {
            InitializeComponent();
            studentsList = new List<Student>();
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_StudentName.Text) ||
                string.IsNullOrEmpty(textBox_StudentSurname.Text) ||
                (numericUpDown_StudentCourse.Value + numericUpDown_StudentGroup.Value) <= 0)
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = textBox_StudentName.Text;
            string surname = textBox_StudentSurname.Text;
            bool gender = comboBox_StudentGender.SelectedIndex == 0 ? true : false;
            short course = (short)numericUpDown_StudentCourse.Value;
            short group = (short)numericUpDown_StudentGroup.Value;

            Student student = new Student(name, surname, gender, course, group);
            studentsList.Add(student);

            addToFormCollection(student);
        }
        private void addToFormCollection(Student student)
        {
            string line = $"{student.Name} {student.Surname} {student.Gender} {student.Course} {student.Group}";
            studentCollection.Items.Add(line);
        }
        private void addToFormCollection(List<Student> list)
        {
            studentCollection.Items.Clear();
            foreach (Student student in list)
            {
                string line = $"{student.Name} {student.Surname} {student.Gender} {student.Course} {student.Group}";
                studentCollection.Items.Add(line);
            }
        }
        private void writeToFile(List<Student> students)
        {
            var sortedList = sortBySurname(students);

            using (StreamWriter sw = new StreamWriter("INFO.txt"))
            {
                foreach (var student in sortedList)
                {
                    string line = $"{student.Name} {student.Surname} {student.Gender} {student.Course} {student.Group}";
                    sw.WriteLine(line);
                }
            }
        }

        private void readFromFile(List<Student> studentsList)
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

                        Student student = new Student(name, surname, gender, course, group);
                        studentsList.Add(student);
                    }
                }
            }
        }

        private List<Student> sortBySurname(List<Student> students)
        {
            return students.OrderBy(s => s.Surname).ToList();
        }

        private void btn_WriteToFile_Click(object sender, EventArgs e)
        {
            writeToFile(studentsList);
        }

        private void btn_ReadFromFile_Click(object sender, EventArgs e)
        {
            readFromFile(studentsList);
            addToFormCollection(studentsList);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            studentCollection.Items.Clear();
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public short Course { get; set; }
        public short Group { get; set; }

        public Student(string name, string surname, bool gender, short course, short group)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Course = course;
            Group = group;
        }
    }
}
