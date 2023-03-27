using Microsoft.EntityFrameworkCore;
using SolidTask.Models;

namespace SolidTask.Repositories.Context;

public class DataContext : DbContext
{

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    internal DbSet<Animal> Animals { get; set; }
    internal DbSet<Herbavore> Herbavores { get; set; }
    internal DbSet<Carnivore> Carnivores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Animal>().UseTpcMappingStrategy();
    }

}
