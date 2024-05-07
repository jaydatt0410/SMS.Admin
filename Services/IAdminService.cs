using SMS.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Services
{
    public interface IAdminService
    {
        public List<Student> GetAllStudents();
        public IQueryable<Student> GetStudentById(int Id);
        bool CreateNewStudent(Student student);
    }
}
