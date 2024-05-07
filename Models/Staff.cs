using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string? Name {  get; set; }
        public string? AadharNo {  get; set; }
        public char Gender {  get; set; }
        public string? Address {  get; set; }
        public DateTime DOB {  get; set; }
        public DateTime DOJ { get; set; }
        public int DepartmentId {  get; set; }
        public int DesignationId { get; set; }
    }
}
