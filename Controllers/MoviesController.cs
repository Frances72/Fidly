using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fidly.Models;

namespace Fidly.Controllers;

public class MoviesController : Controller
{  
   public ActionResult MovieIndex()
   {
      var movies = GetMovies();
   
      return View(movies);

   }

   public ActionResult Details(int id)
   {
        var movie = GetMovies().SingleOrDefault(c => c.Id == id);

        if(Response.Equals(NotFound()))
        {
            movie = null;
        }

       return View(movie); 
   }

   private IEnumerable<Movie> GetMovies()
   {
    return new List<Movie>
    {
        new Movie{Id = 1, Name = "Shrek"},
        new Movie{Id = 2, Name = "Constantine"},
        new Movie{Id = 3, Name = "XXX"},
        new Movie{Id = 4, Name = "No Time To Die"},
        new Movie{Id = 5, Name = "Running Man"},
        new Movie{Id = 6, Name = "Ghost Busters"}       
    };

   }
   
    public ActionResult Index(int? pageIndex, string sortBy)
    {
        if(!pageIndex.HasValue)
        pageIndex = 1;

        if(String.IsNullOrWhiteSpace(sortBy))
            sortBy = "Name";

        return Content(String.Format($"pageIndex={pageIndex}&sortBy={sortBy}"));

    }

//Example of Attribute Routes - uses Program.cs => app.UseRouting();
    [Route("movies/released/{year}/{month}")]
   public ActionResult ByReleaseDate(int year, int month)
   {
        return Content(year + "/" + month);
   } 
   
}
