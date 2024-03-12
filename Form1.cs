using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Lab_1.Models;
using Lab_1;
using Lab_1.Resources;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private List<StudentVm> _studentsList;
        public Form1()
        {
            InitializeComponent();
            _studentsList = new List<StudentVm>();
        }
        private void Btn_AddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_StudentName.Text) ||
                string.IsNullOrEmpty(textBox_StudentSurname.Text) ||
                (numericUpDown_StudentCourse.Value + numericUpDown_StudentGroup.Value) <= 0)
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StudentVm student = new StudentVm(textBox_StudentName.Text, textBox_StudentSurname.Text, comboBox_StudentGender.SelectedIndex == 0 
                ? true : false, (short)numericUpDown_StudentCourse.Value, (short)numericUpDown_StudentGroup.Value);
            _studentsList.Add(student);

            AddToFormCollection(student);
        }
        private void Btn_WriteToFile_Click(object sender, EventArgs e)
        {
            FileManager.WriteToFile(_studentsList);
        }
        private void Btn_ReadFromFile_Click(object sender, EventArgs e)
        {
            FileManager.ReadFromFile(_studentsList);
            AddToFormCollection(_studentsList);
        }
        private void Btn_Clear_Click(object sender, EventArgs e) => studentCollection.Items.Clear();

        //
        private void AddToFormCollection(StudentVm student)
        {
            string line = $"{student.Name} {student.Surname} {student.Gender} {student.Course} {student.Group}";
            studentCollection.Items.Add(line);
        }
        private void AddToFormCollection(List<StudentVm> list)
        {
            studentCollection.Items.Clear();
            foreach (StudentVm student in list)
            {
                string line = $"{student.Name} {student.Surname} {student.Gender} {student.Course} {student.Group}";
                studentCollection.Items.Add(line);
            }
        }
    }
}