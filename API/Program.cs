using Microsoft.EntityFrameworkCore;
using SolidTask.Models;
using SolidTask.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("database")));
builder.Services.AddScoped<IBaseRepository<Animal>, EntityFrameworkRepository<Animal, DataContext>>();
builder.Services.AddScoped<IBaseRepository<Herbavore>, EntityFrameworkRepository<Herbavore, DataContext>>();
builder.Services.AddScoped<IBaseRepository<Carnivore>, EntityFrameworkRepository<Carnivore, DataContext>>();

builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<IHerbavoreRepository, HerbavoreRepository>();
builder.Services.AddScoped<ICarnivoreRepository, CarnivoreRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) //have a database 
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
