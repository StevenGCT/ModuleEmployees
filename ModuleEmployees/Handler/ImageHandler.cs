using Microsoft.AspNetCore.Mvc;
using ModuleEmployees.Interfaces;

namespace ModuleEmployees.Handler
{
    public class ImageHandler: IImageHandler
    {
        private readonly IImageWriter _imageWriter;

        public ImageHandler(IImageWriter imageWriter)
        {
            _imageWriter = imageWriter;
        }

        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            var result = await _imageWriter.UploadImage(file);
            return new ObjectResult(result);
        }
    }
}
