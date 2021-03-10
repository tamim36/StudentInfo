using AutoMapper;
using Dtos;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Programs, GetProgramsDto>();
            CreateMap<Board, GetBoardDto>();
            CreateMap<ExamType, GetHscEqDto>();
            CreateMap<ExamType, GetSscEqDto>();
            CreateMap<PassingYear, GetPassingYearDto>();
        }
    }
}
