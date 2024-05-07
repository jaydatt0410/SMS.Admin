using Microsoft.Identity.Client;
using SMS.Admin.Models;
using SMS.Admin.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public List<Student> GetAllStudents()
        {
            return _adminRepository.GetAllStudents();
        }

        public IQueryable<Student> GetStudentById(int Id)
        {
            return _adminRepository.GetStudentByID(Id);            
        }

        public bool CreateNewStudent(Student student)
        {
            return _adminRepository.CreateNewStudent(student);            
        }

        public string ValidateCreateRequest(Student student)
        {
            if(!string.IsNullOrEmpty(student.Name))
            {
                return "Name should not empty.";
            }
        }
    }
}
