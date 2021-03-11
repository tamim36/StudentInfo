using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dtos
{
    public class AddAcademicInfo
    {
        public int ExamTypeId { get; set; }
        public string RegNumber { get; set; }
        public int PassingYearId { get; set; }
        public int BoardId { get; set; }
        public float GPA { get; set; }
    }
}
