using ModuleEmployees.Interfaces;
using System.Text;

namespace ModuleEmployees.Utils
{
    public class ImageWriter : IImageWriter
    {
        public async Task<string> UploadImage(IFormFile file)
        {
            if (CheckIfImageFile(file))
            {
                return await WriteFile(file);
            }
            return "Invalid image file";
        }

        private async Task<string> WriteFile(IFormFile file)
        {
            string fileName;
            try
            {
                var extension = new StringBuilder(".")
                    .Append(file.FileName.Split(".")[file.FileName.Split('.').Length - 1]);
                fileName = new StringBuilder(Guid.NewGuid().ToString()).Append(extension).ToString();
                var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "Resources/img", fileName);
                using (var bits = new FileStream(path, FileMode.Create))
                    await file.CopyToAsync(bits);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return fileName;
        } 

        private bool CheckIfImageFile(IFormFile file)
        {
            byte[] fileBytes;
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                fileBytes = ms.ToArray();
            }
            return WriteHelper.GetImageFormat(fileBytes) != WriteHelper.ImageFormat.unknown;
        }
    }
}
