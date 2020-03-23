namespace FoodStore 
{
  public class ItemStore
  {
    public int ItemStoreId {get; set;}
    public int ItemId {get; set;}
    public int StoreId {get; set;}
    public Item Item {get; set;}
    public Store Store {get; set;}
  }
}