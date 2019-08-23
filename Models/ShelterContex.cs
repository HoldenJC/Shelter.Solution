using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
  public class ShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=holden_clark;");

    public ShelterContext(DbContextOptions options) : base(options)
    {

    }
    public ShelterContext()
    {

    }
  }
}