using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}