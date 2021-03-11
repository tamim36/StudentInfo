using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace Services.FileService
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment hostEnvironment;

        public FileService(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }
        public async Task<string> FileUpload(IFormFile file)
        {
            string filePath = string.Empty;
            try
            {
                if (file != null)
                {
                    string fileName = new String(Path.GetFileNameWithoutExtension(file.FileName).Take(35).ToArray()).Replace(' ', '-');
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(file.FileName);
                    var destinationFolder = Path.Combine(hostEnvironment.ContentRootPath, "FileStorage");
                    if (!Directory.Exists(destinationFolder))
                    {
                        Directory.CreateDirectory(destinationFolder);
                    }

                    filePath = Path.Combine(destinationFolder, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                        fileStream.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return filePath;
        }
    }
}
