using Microsoft.EntityFrameworkCore;
using Azure_02_Web_API_Build_Pipeline.Models;

namespace Azure_02_Web_API_Build_Pipeline.Data
{
  public class AspProjectDatabaseContext : DbContext
  {
    public AspProjectDatabaseContext(DbContextOptions<AspProjectDatabaseContext> options)
      : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; }
  }
}