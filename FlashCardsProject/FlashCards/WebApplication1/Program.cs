using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using BusinessLogic;
using Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = builder.Configuration.GetConnectionString("project1");
builder.Services.AddDbContext<Project1Context>(options => options.UseSqlServer(config));
builder.Services.AddScoped<IFlashCards, Flashcardlogic>();
builder.Services.AddScoped<IEFRepo, EFRepo>();

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
