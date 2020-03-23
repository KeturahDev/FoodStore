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
  }
}