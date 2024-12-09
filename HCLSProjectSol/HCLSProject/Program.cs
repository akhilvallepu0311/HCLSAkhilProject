using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DataAccess.Repositories;
using HCLSProject.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<HCLSDBContext>(Options =>Options.UseSqlServer("Server=AKHIL\SQLEXPRESS;Uid=sa;password=123;database=HCLSDB;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true"))
builder.Services.AddDbContext<HCLSDBContext>(Options=>Options.UseSqlServer(builder.Configuration.GetConnectionString("ConStrLocal")));
//builder.Services.AddTransient<IAdminTypesRepository,AdminTypesRepository>();
//builder.Services.AddScoped<IAdminTypesRepository, AdminTypesRepository>();
builder.Services.AddSingleton<IAdminTypesRepository,AdminTypesRepository>();
builder.Services.AddSingleton<IAdminRepository, AdminRepository>(); 

var app = builder.Build();
// Add services to the container.

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
