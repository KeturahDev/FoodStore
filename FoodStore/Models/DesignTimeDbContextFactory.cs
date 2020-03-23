using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FoodStore.Models
{
  public class FoodStoreContextFactory : IDesignTimeDbContextFactory<FoodStoreContext>
  {
    FoodStoreContext IDesignTimeDbContextFactory<FoodStoreContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<FoodStoreContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new FoodStoreContext(builder.Options);
    }
  }
}
