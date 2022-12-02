using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fidly.Models;

namespace Fidly.Controllers;

public class MoviesController : Controller
{
    public ActionResult Random()
    {
        var movie = new Movie() {Name = "Shrek!" };
        return View(movie);
    }
}
