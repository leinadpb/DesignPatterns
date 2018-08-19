using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern_DesktopApp.Models
{
    public interface IStudentModel
    {
        List<Student> AddStudent(string name);
        List<Student> DeleteStudent(string name);

    }
}
