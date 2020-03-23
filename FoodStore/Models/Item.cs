using System.Collections.Generic;

namespace FoodStore.Models
{
  public class Item
  {
    public Item()
    {
      this.Stores = new HashSet<ItemStore>();
    }
    public int ItemId {get;set;}
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public virtual ICollection<ItemStore> Stores { get; set; }
  }
}