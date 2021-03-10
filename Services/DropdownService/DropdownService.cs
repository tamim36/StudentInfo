using AutoMapper;
using Dtos;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Response;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DropdownService
{
    public class DropdownService : IDropdownService
    {
        private readonly DataContext dataContext;
        private readonly IMapper mapper;

        public DropdownService(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetProgramsDto>>> ProgramDropdown()
        {
            ServiceResponse<List<GetProgramsDto>> response = new ServiceResponse<List<GetProgramsDto>>();
            try
            {
                List<Programs> programs = await dataContext.Programss.ToListAsync();
                response.Data = (programs.Select(p => mapper.Map<GetProgramsDto>(p))).ToList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetBoardDto>>> BoardDropdown()
        {
            ServiceResponse<List<GetBoardDto>> response = new ServiceResponse<List<GetBoardDto>>();
            try
            {
                List<Board> boards = await dataContext.Boards.ToListAsync();
                response.Data = (boards.Select(p => mapper.Map<GetBoardDto>(p))).ToList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetPassingYearDto>>> PassingYearDropdown()
        {
            ServiceResponse<List<GetPassingYearDto>> response = new ServiceResponse<List<GetPassingYearDto>>();
            try
            {
                List<PassingYear> passingYears = await dataContext.PassingYears.ToListAsync();
                response.Data = (passingYears.Select(p => mapper.Map<GetPassingYearDto>(p))).ToList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetHscEqDto>>> HscEqDropdown()
        {
            ServiceResponse<List<GetHscEqDto>> response = new ServiceResponse<List<GetHscEqDto>>();
            try
            {
                List<ExamType> exams = await dataContext.ExamTypes.Where(c => c.MainExamNames == "HSC").ToListAsync();
                response.Data = (exams.Select(p => mapper.Map<GetHscEqDto>(p))).ToList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetSscEqDto>>> SscEqDropdown()
        {
            ServiceResponse<List<GetSscEqDto>> response = new ServiceResponse<List<GetSscEqDto>>();
            try
            {
                List<ExamType> exams = await dataContext.ExamTypes.Where(c => c.MainExamNames == "SSC").ToListAsync();
                response.Data = (exams.Select(p => mapper.Map<GetSscEqDto>(p))).ToList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
