namespace ModuleEmployees.Interfaces
{
    public interface IImageWriter
    {
        Task<string> UploadImage(IFormFile file, string? fileName);
    }
}
