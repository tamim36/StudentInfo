using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    // student and examtype many to many relationship
    public class ExamType
    {
        public int Id { get; set; }
        public HscEquivalent HscEquivalent { get; set; }
        public SscEquivalent SscEquivalent { get; set; }
        public AcademicInfo AcademicInfo { get; set; }
        public int AcademicInfoID { get; set; }

    }
}
