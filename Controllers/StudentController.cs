using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Admin.Models;
using SMS.Admin.Services;

namespace SMS.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public StudentController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public List<Student> GetAllStudent()
        {
            return _adminService.GetAllStudents();
        }

        [HttpPost]
        public Student CreateNewStudent(Student student)
        {
            var isCreated = _adminService.CreateNewStudent(student);
            return student;
        }
    }
}

//{
//    "id": 1,
//  "name": "Jaydatt",
//  "fatherName": "Natvarlal",
//  "aadharNumber": "123456789012",
//  "age": 29,
//  "gender": "M",
//  "fatherOccupation": "Job",
//  "motherOccupation": "Job",
//  "standerdClass": "10-A",
//  "doa": "2024-04-28T18:44:40.903Z",
//  "bloodGroup": "O",
//  "address": "string",
//  "createdTs": "2024-04-28T18:44:40.903Z",
//  "createdBy": "Admin",
//  "changedTs": "2024-04-28T18:44:40.903Z",
//  "changedBy": "Admin"
//}
