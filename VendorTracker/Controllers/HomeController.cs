using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Order starterOrder = new Order("Add first Order to Vendor history", "", 0, "");
      return View(starterOrder);
    }

    [Route("orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [Route("/orders")]
    public ActionResult Create(string title, string description, int price, string date)
    {
      Order myOrder = new Order(title, description, price, date);
      return View("Index", myOrder);
    }

  }
}