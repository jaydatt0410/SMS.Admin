namespace SMS.Admin.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string AadharNumber { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string FatherOccupation { get; set; }
        public string MotherOccupation { get; set; }
        public string StanderdClass { get; set; }
        public DateTime DOA { get; set; }
        public char BloodGroup { get; set; }
        public string Address { get; set; }
        public DateTime CreatedTs { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ChangedTs { get; set; }
        public string ChangedBy { get; set; }
    }
}
