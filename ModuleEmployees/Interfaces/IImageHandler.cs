using Microsoft.AspNetCore.Mvc;

namespace ModuleEmployees.Interfaces
{
    public interface IImageHandler
    {
        Task<IActionResult> UploadImage(IFormFile file, string? fileName);
    }
}
