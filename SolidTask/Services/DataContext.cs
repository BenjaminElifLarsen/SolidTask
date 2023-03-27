using Microsoft.EntityFrameworkCore;
using SolidTask.Models;

namespace SolidTask.Services;

public class DataContext : DbContext
{

	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{

	}

	internal DbSet<Herbavore> Herbavore { get;set; }
	internal DbSet<Carnivore> Carnivore { get;set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Animal>().UseTpcMappingStrategy();
	}

}
