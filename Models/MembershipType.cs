using System.ComponentModel.DataAnnotations;
namespace Fidly.Models;

public class MembershipType
{
    public byte Id { get; set; }
    public short? SignUpFee { get; set; }
    public byte? DurationInMonths { get; set; }
    public byte? DiscountRate { get; set; }
    public string? MembershipName { get; set; }

    public static readonly byte Unknown = 0; //validation for  Min18YearsIfAMember model
    public static readonly byte PayAsYouGo = 1;//validation for  Min18YearsIfAMember model
}