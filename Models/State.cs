using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Admin.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId {  get; set; }
        public bool IsEnabled { get; set; }
        public string CreaderBy { get; set; }
        public DateTime CreatedTs { get; set; }
        public string ChangedBy { get; set; }
        public DateTime ChangedTs { get; set; }
    }
}
