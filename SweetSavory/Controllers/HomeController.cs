using Microsoft.AspNetCore.Mvc;

namespace SweetSavory.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}