using System.ComponentModel.DataAnnotations;

namespace Fidly.Models;

public class Min18YearsIfAMember: ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
       var customer = (Customers)validationContext.ObjectInstance;

       if(customer.MembershipTypeId == MembershipType.PayAsYouGo 
          ||customer.MembershipTypeId == MembershipType.Unknown)
       {
            return ValidationResult.Success;
       }
       
       if(customer.DOB == null)
       {
            return new ValidationResult("Birthdate is required.");
       }
 
       var age = DateTime.Today.Year - customer.DOB.Year;

       return (age >= 18) ? ValidationResult.Success 
       : new ValidationResult("Customer should be 18 years or older for membership contract.");

    }
}