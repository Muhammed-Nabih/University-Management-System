using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using UniversityManagementSystem.Service.Abstracts;

namespace UniversityManagementSystem.Service.Implementations
{
    public class FileService : IFileService
    {
        // Fileds
        private readonly IWebHostEnvironment _webHostEnvironment;
        /*******************************************************************************************/
        // Constructors
        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        /*******************************************************************************************/
        // Handle Functions
        public async Task<string> UploadImage(string Location, IFormFile file)
        {
            var path = _webHostEnvironment.WebRootPath+"/"+Location+"/";
            var extention = Path.GetExtension(file.FileName);
            var fileName = Guid.NewGuid().ToString().Replace("-", string.Empty)+extention;
            if (file.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream filestreem = File.Create(path+fileName))
                    {
                        await file.CopyToAsync(filestreem);
                        await filestreem.FlushAsync();
                        return $"/{Location}/{fileName}";
                    }
                }
                catch (Exception)
                {
                    return "FailedToUploadImage";
                }
            }
            else
            {
                return "NoImage";
            }
        }
        /*******************************************************************************************/
    }
}
