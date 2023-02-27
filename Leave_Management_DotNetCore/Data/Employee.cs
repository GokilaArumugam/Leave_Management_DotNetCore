using Microsoft.AspNetCore.Identity;
namespace Leave_Management_DotNetCore.Data
{
    public class Employee:IdentityUser
    {
        public string? FristName { get; set; }
        public string? LastName { get; set;}
        public string? TaxId { get; set;}
        public DateTime DateOfBirth { get; set; }
        public DateTime JoiningDate { get; set; }

    }
}
