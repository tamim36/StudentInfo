using Dtos;
using Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.StudentService
{
    public interface IStudentService
    {
        Task<ServiceResponse<int>> StudentInfo(AddStudentDto studentDto);
    }
}
