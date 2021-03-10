using Dtos;
using Models;
using Models.Response;
using Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly DataContext dataContext;

        public StudentService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task<ServiceResponse<int>> StudentInfo(AddStudentDto studentDto)
        {
            ServiceResponse<int> serviceResponse = new ServiceResponse<int>();
            try
            {
                Student student = new Student { FullName = studentDto.FullName, ProgramsId = studentDto.ProgramsId };

                dataContext.Students.Add(student);
                dataContext.SaveChanges();

                int studentId = student.id;

                AcademicInfo academicInfo = new AcademicInfo();
                academicInfo.ExamTypeId = studentDto.ExamTypeId;
                academicInfo.BoardId = studentDto.BoardId;
                academicInfo.PassingYearId = studentDto.PassingYearId;
                academicInfo.GPA = studentDto.GPA;
                academicInfo.StudentId = studentId;

                await dataContext.AcademicInfos.AddAsync(academicInfo);
                await dataContext.SaveChangesAsync();


                serviceResponse.Data = student.id;
                serviceResponse.Message = "Student Info added to the database successfully";
                return serviceResponse;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }
    }
}
