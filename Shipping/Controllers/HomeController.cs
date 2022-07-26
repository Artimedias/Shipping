using Microsoft.AspNetCore.Mvc;
using Shipping.Models;
using System.Collections;
using System.Collections.Generic;
using System;
namespace Shipping.Controllers

{
  public class HomeController : Controller
  {

    [Route("/shipOne")]
    public ActionResult Shipping(string Order1, string Order2, string Order3, string Distributor, string Description, string Date)
        {
            
       ShippingVarible newOrder = new ShippingVarible();
            Console.WriteLine(Order1);
        if (Order1 != null)
            { 
                            newOrder.Order = Order1;
                Console.WriteLine(Order1);
            }
                if (Order2 != null)
            { 
                            newOrder.Order = Order2;
                Console.WriteLine(Order2);
            }
                        if (Order3 != null)
            { 
                            newOrder.Order = Order3;
                Console.WriteLine(Order3);
            }
            newOrder.Distributor = Distributor;
            newOrder.Date = Date;
            newOrder.Description = Description;
      return View(newOrder);
        }
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/items/new")]
    public ActionResult CreateOrder()
    {
      return View();
    }

  }
}