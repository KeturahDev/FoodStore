using System.Collections.Generic;

namespace FoodStore.Models
{
  public class Store
  {
    public Item()
    {
      this.Items = new HashSet<ItemStore>();
    }
    public int StoreId {get;set;}
    public string StoreName { get; set; }
    public string Address { get; set; }
    public virtual ICollection<ItemStore> Items { get; set; }
  }
}