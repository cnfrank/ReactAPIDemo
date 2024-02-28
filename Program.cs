using Microsoft.EntityFrameworkCore;
using ReactAPIDemo.Models;
using Microsoft.Extensions.DependencyInjection;
using ReactAPIDemo.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ReactAPIDemoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ReactAPIDemoContext") ?? throw new InvalidOperationException("Connection string 'ReactAPIDemoContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
