using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPattern_DesktopApp.Models;

namespace MVCPattern_DesktopApp.Controllers
{
    public interface IStudentController
    {
        List<Student> Add(string name);
        List<Student> Delete(string name);

    }
}
