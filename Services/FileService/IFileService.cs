using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.FileService
{
    public interface IFileService
    {
        Task<string> FileUpload(IFormFile file);
    }
}
