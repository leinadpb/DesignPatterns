using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCPattern_DesktopApp.Controllers;
using MVCPattern_DesktopApp.Models;

namespace MVCPattern_DesktopApp.Views
{
    public partial class Form1 : Form
    {
        StudentController _StudentController;
        StudentModel _StudentModel;
        public int StudentCount { get; set; }

        public Form1()
        {
            _StudentModel = StudentModel.Instance;
            _StudentController = new StudentController();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // Delete a user
        {
            string username = Students.GetItemText(Students.SelectedItem);
            if(username == null || username.Equals(""))
            {
                MessageBox.Show("Select a student from the list.");
            }
            else
            {
                _StudentController.Delete(username);
                UpdateStudentCount();
                UpdateListBox(StudentModel.AllStudents);
            }
        }

        private void Form1_Load(object sender, EventArgs e) // Load View Form
        {
            Count.Text = $"{StudentCount} students.";
        }

        private void AddBtn_Click(object sender, EventArgs e) // Add a user
        {
            string username = StudentName.Text.ToUpper();
            if (username.Equals(""))
            {
                MessageBox.Show("Provide a student name.");
            }
            else
            {
                _StudentController.Add(username);
                UpdateStudentCount();
                UpdateListBox(StudentModel.AllStudents);
            }
            StudentName.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateStudentCount()
        {
            StudentCount = StudentModel.AllStudents.Count();
            Count.Text = $"{StudentCount} students.";
        }

        private void UpdateListBox(List<Student> students)
        {
            students.Reverse();
            Students.Items.Clear();
            foreach(var s in students)
            {
                Students.Items.Add(s.Name);
            }
        }
    }
}
