using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    // student and examtype many to many relationship
    public class ExamType
    {
        public int Id { get; set; }
        public string MainExamNames { get; set; } // HSC SSC JSC PSC
        public string SubExamNames { get; set; } // Dakhli Diploma Equivalent

    }
}
