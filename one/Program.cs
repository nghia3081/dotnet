using Microsoft.EntityFrameworkCore;
using one.DTOs;
using one.Models;
using one.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SchoolContext>((options) =>
{
    var connectString = builder.Configuration.GetConnectionString("School");
    options.UseSqlServer(connectString);
});
builder.Services.AddAutoMapper(typeof(MyAutoMapper));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
//transient -> 
// scope
//singleton

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
