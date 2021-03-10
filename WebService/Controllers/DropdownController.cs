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
    }
}