using Fidly.Models;

namespace Fidly.ViewModels;

public class NewCustomerViewModel
{
    public IEnumerable<MembershipType> MembershipType { get; set; }
    public Customers Customers { get; set; }
}