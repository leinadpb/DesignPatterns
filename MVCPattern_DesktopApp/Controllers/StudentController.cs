using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPattern_DesktopApp.Models;

namespace MVCPattern_DesktopApp.Controllers
{
    public class StudentController : IStudentController
    {
        private readonly IStudentModel _StudentModel;

        public StudentController()
        {
            this._StudentModel = StudentModel.Instance;
        }

        public List<Student> Add(string name)
        {
            if(name.Equals("") || name == null)
            {
                return StudentModel.AllStudents;
            }
            else
            {
                return _StudentModel.AddStudent(name);
            }
            
        }

        public List<Student> Delete(string name)
        {
            return _StudentModel.DeleteStudent(name);
        }
    }
}
