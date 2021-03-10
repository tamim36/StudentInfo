using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Student
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public Programs Programs { get; set; } // one to many
        public int ProgramsId { get; set; }
        public string ImagePath { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string GuardianName { get; set; }
        public string ContactNo { get; set; }
        public string GuardianContactNo { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public string PresentAddress { get; set; }
        public List<AcademicInfo> AcademicInfo { get; set; } // one to many

    }
}
