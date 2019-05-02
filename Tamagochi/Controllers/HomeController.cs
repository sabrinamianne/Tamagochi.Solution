using Microsoft.AspNetCore.Mvc;
using Tamagochi.Models;

namespace Tamagochi.Controllers
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
