using System.ComponentModel.DataAnnotations;


namespace Fidly.Models;

public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Genre? Genre { get; set; }

    [Required]
    public int GenreId { get; set; }

    [Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Entry Date")]
    public DateTime DateEntered { get; set; }

    [Display(Name = "Number in Stock")]
    public int NumberInStock { get; set; }
}