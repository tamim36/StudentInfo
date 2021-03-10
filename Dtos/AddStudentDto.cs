using System;
using System.Collections.Generic;
using System.Text;

namespace Dtos
{
    public class AddStudentDto
    {
        public string FullName { get; set; }
        public int ProgramsId { get; set; }
        public int ExamTypeId { get; set; }
        public int BoardId { get; set; }
        public int PassingYearId { get; set; }
        public float GPA { get; set; }
    }
}
