using System.ComponentModel.DataAnnotations;

namespace BlazorFormApp.Models;

public class UserModel
{
    [Required(ErrorMessage = "First name is required.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Must be 2–50 characters.")]
    public string FirstName { get; set; } = "";

    [Required(ErrorMessage = "Last name is required.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Must be 2–50 characters.")]
    public string LastName { get; set; } = "";

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = "";
}