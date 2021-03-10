using Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Response;
using Services.DropdownService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropdownController : ControllerBase
    {
        private readonly IDropdownService dropdownService;

        public DropdownController(IDropdownService dropdownService)
        {
            this.dropdownService = dropdownService;
        }

        [HttpGet("programs")]
        public async Task<IActionResult> GetPrograms()
        {
            var response = await dropdownService.ProgramDropdown();
            if (response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);

        }

        [HttpGet("board")]
        public async Task<IActionResult> GetBoards()
        {
            var response = await dropdownService.BoardDropdown();
            if (response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);

        }

        [HttpGet("hsc")]
        public async Task<IActionResult> GetHscEq()
        {
            var response = await dropdownService.HscEqDropdown();
            if (response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);

        }

        [HttpGet("ssc")]
        public async Task<IActionResult> GetSscEq()
        {
            var response = await dropdownService.SscEqDropdown();
            if (response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);

        }

        [HttpGet("passingyear")]
        public async Task<IActionResult> GetPassingYear()
        {
            var response = await dropdownService.PassingYearDropdown();
            if (response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);

        }
    }
}