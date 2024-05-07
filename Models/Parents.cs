using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Models
{
    public class Parents
    {
        public int Id { get; set; }
        public int StudentId {  get; set; }
        public string Name { get; set; }
        public string MobileNo {  get; set; }
        public int Income {  get; set; }
        public string PANNumber { get; set; }        
    }
}
