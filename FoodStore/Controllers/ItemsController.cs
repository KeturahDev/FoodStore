using Microsoft.AspNetCore.Mvc;
using FoodStore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FoodStore.Controllers
{
  public class ItemssController : Controller
  {
    private readonly FoodStoreContext _db;

    public StoresController(FoodStoreContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Item> model = _db.Items.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StoreId = new SelectList(_db.Stores, "StoreId", "StoreName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Item item, int StoreId)
    {
      _db.Items.Add(item)
      if(StoreId != 0)
      {
        _db.ItemStore.Add(new )
      }
      _db.Items.Add(item);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}