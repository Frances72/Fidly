using System.ComponentModel.DataAnnotations;

namespace Fidly.Models;

public class Customers 
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "Please enter Customer name and surname.")]
    [StringLength(30)]
    public string Name { get; set; }
    public bool IsSubscribedToNewsletter { get; set; }
    public MembershipType? MembershipType { get; set; } //navigation property

    [Required(ErrorMessage = "Please select a membership type.")]
    [Display(Name = "Membership Type")]
    public byte MembershipTypeId { get; set; }//foreign key- EF recognizes this framework

    [Display(Name = "Date of Birth")]
    [Min18YearsIfAMember]
    public DateTime DOB { get; set; }
}