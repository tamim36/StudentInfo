using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class HscEquivalent
    {
        public int Id { get; set; }
        public HscExamNames HscExamNames { get; set; }
        public string RegNumber { get; set; }
        public PassingYear PassingYear { get; set; } // one to one
        public Board Board { get; set; } // one to one
        public float GPA { get; set; }
        public ExamType ExamType { get; set; }
        public int ExamTypeId { get; set; }
    }
}
