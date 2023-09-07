using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AddressBook.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required,Phone]
        public string MobileNumber { get; set; }
        [Phone]
        public string? LandlineNumber { get; set; }
        [Required,Url]
        public string Website { get; set; }
        [Required]
        public string Address { get; set; }
    }
}