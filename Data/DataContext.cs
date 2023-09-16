using expenses_report_api;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext 
{
  public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
  public DbSet<Report> Report { get; set; }
  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Report>()
      .HasData(new List<Report>()
      {
        new Report(1, 100.00, "SENAI"),
        new Report(2, 1000.00, "MARATONA"),
        new Report(3, 125.10, "CHI")
      }); 
  }
}