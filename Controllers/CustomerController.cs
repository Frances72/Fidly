using Microsoft.AspNetCore.Mvc;
using Fidly.Models;
using Microsoft.EntityFrameworkCore;
using Fidly.ViewModels;

namespace Fidly.Controllers.Customer;

public class CustomerController : Controller
{
    private readonly FidlyDbContext _context = new FidlyDbContext();//instantiated database context object    
    
    public ViewResult CustomerIndex()
    {
        var customerList = GetCustomerList();

        return View(customerList);

    }

    public ActionResult Details(int id)
    {
        var customerDetail = GetCustomerList().SingleOrDefault(c => c.Id == id);
        
         if(Response.Equals(NotFound()))
        {
            customerDetail = null; 
        }

        return View(customerDetail);
    }

    public IEnumerable<Customers> GetCustomerList()
    {  
            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); //eager loading the Include()
            return customers;
    }
    public ActionResult CustomerForm()
    {
        
        var membershipTypes = _context.MembershipType.ToList();
        var viewModel = new NewCustomerViewModel
        {
            MembershipType = membershipTypes
        };
        return View(viewModel);
    }

    [HttpPost] 
    public IActionResult Create(NewCustomerViewModel viewCustomerModel)
    {
        if(!ModelState.IsValid)
        {     
             var viewModel = new NewCustomerViewModel
             {
                Customers = viewCustomerModel.Customers,
                MembershipType = _context.MembershipType.ToList()
             };
            return View("CustomerForm", viewModel);
        }

        if(viewCustomerModel.Customers.Id == null)
        {
            _context.Customers.Add(viewCustomerModel.Customers);
        }
        else
        {
            var customerInDb = _context.Customers.Single(c => c.Id == viewCustomerModel.Customers.Id);

            customerInDb.Name = viewCustomerModel.Customers.Name;
            customerInDb.DOB = viewCustomerModel.Customers.DOB;
            customerInDb.MembershipTypeId = viewCustomerModel.Customers.MembershipTypeId;
            customerInDb.IsSubscribedToNewsletter = viewCustomerModel.Customers.IsSubscribedToNewsletter;
            //Automapper: Mapper.Map(customer, customerInDb);
        }
        
        try
        {
            _context.SaveChanges();
        }
        catch(DbUpdateException  e)
        {
            System.Console.WriteLine(e);
        }   
            return RedirectToAction("CustomerIndex", "Customer");
    }

    public ActionResult Edit(int Id)
    {
        var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);
        if(customer == null)
        {
            return NotFound();
        }

        var viewModel = new NewCustomerViewModel
        {
            Customers = customer,
            MembershipType = _context.MembershipType.ToList()
        };

        return View("CustomerForm", viewModel);
    }
  }