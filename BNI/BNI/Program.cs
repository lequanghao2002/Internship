using BNI.Data;
using BNI.Respositories.BusinessSectorRepositories.BusinessSectorRepository;
using BNI.Respositories.CategorySupportRepositories.CategorySupportRepository;
using BNI.Respositories.ContactRepositories.ContactRepository;
using BNI.Respositories.LogoRepositories.LogoRepository;
using BNI.Respositories.PlatformRepositories.PlatformRepository;
using BNI.Respositories.PostCategoryRepository;
using BNI.ultils;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString)
);
builder.Services.AddScoped<IBusinessSectorRepository, BusinessSectorRepository>();
builder.Services.AddScoped<ICategorySupportRepository, CategorySupportRepository>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<ILogoRepository, LogoRepository>();
builder.Services.AddScoped<IPlatformRepository, PlatformRepository>();
builder.Services.AddScoped<IPostCategoryRepository, PostCategoryRepository>();
builder.Services.AddScoped<EmailService>();
builder.Services.AddScoped<EmailService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
