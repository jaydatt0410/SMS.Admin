using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Admin;
using SMS.Admin.Models;

namespace SMS.Admin.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AdmicnDbContext _context;

        public AdminRepository(AdmicnDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Student.ToList();
        }

        public IQueryable<Student> GetStudentByID(int Id)
        {
            var student = _context.Student.Where(a => a.Id == Id);
            return student;
        }

        public bool CreateNewStudent(Student student)
        {
            try
            {
                var data = _context.Student.Add(student);
                _context.SaveChanges();                
            }            
            catch
            {
                return false;
            }
            return true;
        }
    }
}
