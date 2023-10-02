using expenses_report_api;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext 
{
  public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
  public DbSet<Report> Report { get; set; }
  public DbSet<Department> Departments { get; set; }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Department>()
      .HasData(new List<Department>()
      {
        new Department(1, "Serviço Nacional de Aeronáutica", "SENAI", "Curso técnico"),
        new Department(2, "Instituto de Engenharia de Sistemas e Tecnologias da Informação", "IESTI", "Curso Superior"),
        new Department(3, "Cultural Homestay International", "CHI", "Enterprise")
      }); 
  }
}