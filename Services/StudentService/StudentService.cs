using Dtos;
using Models;
using Models.Response;
using Newtonsoft.Json;
using Repositories;
using Services.FileService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly DataContext dataContext;
        private readonly IFileService fileService;

        public StudentService(DataContext dataContext, IFileService fileService)
        {
            this.dataContext = dataContext;
            this.fileService = fileService;
        }
        public async Task<ServiceResponse<int>> StudentInfo(AddStudentDto studentDto)
        {
            ServiceResponse<int> serviceResponse = new ServiceResponse<int>();
            try
            {
                var imagePath = await fileService.FileUpload(studentDto.File);

                Student student = new Student { FullName = studentDto.FullName, ProgramsId = studentDto.ProgramsId, ImagePath = imagePath };

                dataContext.Students.Add(student);
                dataContext.SaveChanges();

                int studentId = student.id;
                List<AddAcademicInfo> addAcademicInfos = JsonConvert.DeserializeObject<List<AddAcademicInfo>>(studentDto.AcademicInfo);

                foreach (var info in addAcademicInfos)
                {
                    AcademicInfo academicInfo = new AcademicInfo();
                    academicInfo.StudentId = studentId;
                    academicInfo.ExamTypeId = info.ExamTypeId;
                    academicInfo.RegNumber = info.RegNumber;
                    academicInfo.BoardId = info.BoardId;
                    academicInfo.PassingYearId = info.PassingYearId;
                    academicInfo.GPA = info.GPA;

                    await dataContext.AcademicInfos.AddAsync(academicInfo);
                    await dataContext.SaveChangesAsync();
                }

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
