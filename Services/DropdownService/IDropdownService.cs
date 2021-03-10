using Dtos;
using Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.DropdownService
{
    public interface IDropdownService
    {
        Task<ServiceResponse<List<GetProgramsDto>>> ProgramDropdown();
        Task<ServiceResponse<List<GetBoardDto>>> BoardDropdown();
        Task<ServiceResponse<List<GetPassingYearDto>>> PassingYearDropdown();
        Task<ServiceResponse<List<GetHscEqDto>>> HscEqDropdown();
        Task<ServiceResponse<List<GetSscEqDto>>> SscEqDropdown();
    }
}
