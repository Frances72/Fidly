using Fidly.Models;
namespace Fidly.ViewModels;

public class NewMovieViewModel
{
    public Movie Movie { get; set; }
    public IEnumerable<Genre> Genre { get; set; }
}