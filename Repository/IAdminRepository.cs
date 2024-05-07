using SMS.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Repository
{
    public interface IAdminRepository
    {
        List<Student> GetAllStudents();
        IQueryable<Student> GetStudentByID(int Id);
        bool CreateNewStudent(Student student);
    }
}
