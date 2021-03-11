using Dtos;
using Microsoft.AspNetCore.Mvc;
using Models.Response;
using Services.StudentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        // POST api/<StudentController>
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] AddStudentDto studentDto)
        {
            ServiceResponse<int> response = await studentService.StudentInfo(studentDto);
            if (response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

    }
}
