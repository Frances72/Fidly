using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fidly.Models;
using Microsoft.EntityFrameworkCore;
using Fidly.ViewModels;

namespace Fidly.Controllers;

public class MoviesController : Controller
{  
   private FidlyDbContext _context = new FidlyDbContext();
   public ActionResult MovieIndex()
   {
      var movies = GetMoviesList();
   
      return View(movies);

   }

   public ActionResult Details(int id)
   {
        var movie = GetMoviesList().SingleOrDefault(c => c.Id == id);

        if(Response.Equals(NotFound()))
        {
            movie = null;
        }

       return View(movie); 
   }
   
    private IEnumerable<Movie> GetMoviesList()
    {
            var movieList = _context.Movie.Include(m => m.Genre).ToList();
            return movieList;
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

   public ViewResult New()
   {
        var genre = _context.Genre.ToList();

        var movieViewModel = new NewMovieViewModel
        {
            Genre = genre
        };

        return View("MovieForm",movieViewModel);
   }

    public ActionResult Edit(int id)
    {
        var movie = _context.Movie.SingleOrDefault(c => c.Id == id);

        if(movie == null)
        {
            return NotFound();
        }
        var viewModel = new NewMovieViewModel
        {
            Movie = movie,
            Genre = _context.Genre.ToList()
        };

        return View("MovieForm", viewModel);
    }

    [HttpPost]
    public ActionResult Save(Movie movie)
    {
        if(movie.Id == 0)
        {
            movie.DateEntered = DateTime.Now;
            _context.Movie.Add(movie);
        }
        else
        {
            var movieInDb = _context.Movie.Single(m => m.Id == movie.Id);
            movieInDb.Name = movie.Name;
            movieInDb.GenreId = movie.GenreId;
            movieInDb.NumberInStock = movie.NumberInStock;
            movieInDb.ReleaseDate = movie.ReleaseDate;
        }
         _context.SaveChanges();
        
        return RedirectToAction("MovieIndex", "Movies");
    }
   
   
}
