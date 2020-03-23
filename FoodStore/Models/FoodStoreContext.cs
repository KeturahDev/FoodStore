using Microsoft.EntityFrameworkCore;

namespace FoodStore.Models
{
  public class FoodStoreContext : DbContext
  {
    public virtual DbSet<Store> Stores { get; set;}
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemStore> ItemStore { get; set; }

    public FoodStoreContext(DbContextOptions options) : base(options) { }

  }
}

  