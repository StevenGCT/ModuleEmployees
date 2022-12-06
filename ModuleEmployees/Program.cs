using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using ModuleEmployees.Context;
using ModuleEmployees.Handler;
using ModuleEmployees.Interfaces;
using ModuleEmployees.Utils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AplicationDBContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IImageHandler, ImageHandler>();
builder.Services.AddTransient<IImageWriter, ImageWriter>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "Resources")),
    RequestPath = "/StaticFiles"
});

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
