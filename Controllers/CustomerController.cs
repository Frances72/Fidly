using Microsoft.AspNetCore.Mvc;
using Fidly.Models;

namespace Fidly.Controllers.Customer;

public class CustomerController : Controller
{
    public ViewResult CustomerIndex()
    {
        var customerList = GetCustomers();

        return View(customerList);

    }

    public ActionResult Details(int id)
    {
        var customerDetail = GetCustomers().SingleOrDefault(c => c.Id == id);
        
         if(Response.Equals(NotFound()))
        {
            customerDetail = null; 
        }

        return View(customerDetail);
    }

  private IEnumerable<Customers> GetCustomers()
  {
    return new List<Customers>
    {
        new Customers{Id = 1, Name = "Gielie Maritz"},
        new Customers{Id = 2, Name = "Butter Fly"},
        new Customers{Id = 3, Name = "Billy Goat"},
        new Customers{Id = 4, Name = "Jane Goodman"}
    };

  }
  }