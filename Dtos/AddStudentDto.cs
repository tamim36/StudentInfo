using Microsoft.AspNetCore.Http;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dtos
{
    public class AddStudentDto
    {
        public string FullName { get; set; }
        public int ProgramsId { get; set; }
        public IFormFile File { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string GuardianName { get; set; }
        public string ContactNo { get; set; }
        public string GuardianContactNo { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public string PresentAddress { get; set; }
        public string AcademicInfo { get; set; }
    }
}
