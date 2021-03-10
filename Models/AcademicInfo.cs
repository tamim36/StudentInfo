using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class AcademicInfo
    {
        public int Id { get; set; }
        public Student Student { get; set; } // one to one
        public int StudentId { get; set; }
        public ExamType ExamTypes { get; set; } // One to one
    }
}
