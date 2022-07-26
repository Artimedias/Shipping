using Microsoft.AspNetCore.Mvc;
using Shipping.Models;
namespace Shipping.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/shipOne")]
    public ActionResult Shipping(string Order, string Distributor)
        {
       ShippingVarible newOrder = new ShippingVarible();
      newOrder.Order = Order;
            newOrder.Distributor = Distributor;
      return View(newOrder);
        }
    [Route("/form")]
    public ActionResult Form() { return View(); }

  }
}