using Microsoft.EntityFrameworkCore;
//Identifying the Database Schema

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public virtual DbSet<Machine> Machines { get; set; } //DBSets are new tables being created. 
    public DbSet<Engineer> Engineers { get; set; }

    public DbSet<MachineEngineer> MachineEnigneer { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { } 
  }
}