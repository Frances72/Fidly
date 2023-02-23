using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fidly.Models;

public class Genre
{
    [Display(Name = "Name of Genre")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string? GenreName { get; set; }
}