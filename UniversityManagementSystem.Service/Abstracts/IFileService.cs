using Microsoft.AspNetCore.Http;

namespace UniversityManagementSystem.Service.Abstracts
{
    public interface IFileService
    {
        public Task<string> UploadImage(string Location, IFormFile file);
    }
}
