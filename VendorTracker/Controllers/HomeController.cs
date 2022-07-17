using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Order>allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string title, string description, int price, string date)
    {
      Order myOrder = new Order(title, description, price, date);
      return RedirectToAction("Index");
    }

  }
}