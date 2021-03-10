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
        public ExamType ExamType { get; set; } // One to one
        public int ExamTypeId { get; set; }
        public string RegNumber { get; set; }
        public PassingYear PassingYear { get; set; }
        public int PassingYearId { get; set; }
        public Board Board { get; set; } // one to many
        public int BoardId { get; set; }
        public float GPA { get; set; }
    }
}
