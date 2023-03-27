using Microsoft.EntityFrameworkCore;
using SolidTask.Models;
using SolidTask.Repositories;
using SolidTask.Repositories.Abstracts;
using SolidTask.Repositories.Context;
using SolidTask.Repositories.Implementations;
using SolidTask.Repositories.UnitOfWorks;
using SolidTask.Services.Carnivore;
using SolidTask.Services.Herbavore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//these would normally be placed in another file 
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("database")));
builder.Services.AddScoped<IBaseRepository<Animal>, EntityFrameworkRepository<Animal, DataContext>>();
builder.Services.AddScoped<IBaseRepository<Herbavore>, EntityFrameworkRepository<Herbavore, DataContext>>();
builder.Services.AddScoped<IBaseRepository<Carnivore>, EntityFrameworkRepository<Carnivore, DataContext>>();

builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<IHerbavoreRepository, HerbavoreRepository>();
builder.Services.AddScoped<ICarnivoreRepository, CarnivoreRepository>();

builder.Services.AddScoped<IUnitOfWork, EntityFrameworkUnitOfWork>();

builder.Services.AddScoped<ICarnivoreService, CarnivoreService>();
builder.Services.AddScoped<IHerbavoreService, HerbavoreService>();


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
