using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Linq;

namespace AnimalShelter.Controllers
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