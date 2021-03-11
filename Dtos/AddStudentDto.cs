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
        public string AcademicInfo { get; set; }
    }
}
