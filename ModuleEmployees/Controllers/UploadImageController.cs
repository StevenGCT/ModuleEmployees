using Microsoft.AspNetCore.Mvc;
using ModuleEmployees.Interfaces;

namespace ModuleEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadImageController: ControllerBase
    {
        private readonly IImageHandler _imageHandler;
        public UploadImageController(IImageHandler imageHandler)
        {
            _imageHandler = imageHandler;
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            return await _imageHandler.UploadImage(file);
        }
    }
}
