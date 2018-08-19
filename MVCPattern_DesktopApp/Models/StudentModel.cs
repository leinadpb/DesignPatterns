using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern_DesktopApp.Models
{
    public sealed class StudentModel : IStudentModel
    {
        public static List<Student> AllStudents = new List<Student>();

        private static StudentModel instance = null;
        private static Object obj = new object();

        public StudentModel()
        { }

        public static StudentModel Instance {
            get
            {
                if(instance == null)
                {
                    lock (obj)
                    {
                        instance = new StudentModel();
                    }
                }
                return instance;
            }
        }

        public List<Student> AddStudent(string name)
        {
            Student student = new Student();
            student.Name = name.ToUpper();
            AllStudents.Add(student);
            return AllStudents;
        }

        public List<Student> DeleteStudent(string name)
        {
            Student student = null;
            foreach(Student s in AllStudents)
            {
                if (s.Name.ToUpper().Equals(name.ToUpper()))
                {
                    student = s;
                }
            }
            if(student == null)
            {
                return null;
            }
            AllStudents.Remove(student);
            return AllStudents;
        }
    }
}
