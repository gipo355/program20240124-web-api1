namespace Data;

// using System.Collections.Generic;
using Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;

public class AppDbContext : DbContext
{
  protected readonly IConfiguration Configuration;

  private readonly string connectionString =
    $"Host={Environment.EnvVars["HOST"]};Database={Environment.EnvVars["DATABASE"]};Username={Environment.EnvVars["USERNAME"]};Password={Environment.EnvVars["PASSWORD"]}";

  public AppDbContext(IConfiguration configuration) => this.Configuration = configuration;

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
    // this reads the connectin string from appsettings.json (bad? pushes to git)
    // optionsBuilder.UseNpgsql(this.Configuration.GetConnectionString("DefaultConnection"));

    optionsBuilder.UseNpgsql(this.connectionString);

  public DbSet<Post> Posts { get; set; }
  public DbSet<Blog> Blogs { get; set; }
  public DbSet<Country> Countries { get; set; }
  public DbSet<Animal> Animals { get; set; }
}
