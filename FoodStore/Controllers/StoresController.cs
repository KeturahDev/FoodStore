using Microsoft.AspNetCore.Mvc;
using FoodStore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FoodStore.Controllers
{
  public class StoresController : Controller
  {
    private readonly FoodStoreContext _db;

    public StoresController(FoodStoreContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Store> model = _db.Stores.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Store store)
    {
      _db.Stores.Add(store);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    
    public ActionResult Details(int id)
    {
      var thisStore = _db.Stores
          .Include(store => store.Items)
          .ThenInclude(join => join.Item)
          .FirstOrDefault(store => store.StoreId == id);
      return View(thisStore);
    }  

    public ActionResult Edit(int id)
    {
      var thisStore = _db.Categories.FirstOrDefault(store => store.StoreId == id);
      return View(thisStore);
    }

    [HttpPost]
    public ActionResult Edit(Store store)
    {
      _db.Entry(store).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisStore = _db.Stores.FirstOrDefault(store => store.StoreId == id);
      return View(thisStore);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStore = _db.Stores.FirstOrDefault(store => store.StoreId == id);
      _db.Categories.Remove(thisStore);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}