using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemos.Models.Form
{
    public class OrderDetails
    {
        public OrderDetails()
        {

        }

        // Group 1
        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Mail ID")]
        public string EmailID { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your phone number.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please agree with the terms.")]
        [Display(Name = "Terms and Conditions")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Please agree with the terms.")]
        public bool AcceptTerms { get; set; }

        //Group-2 Shipping Address
        [Required(ErrorMessage = "Please enter your shipping date.")]
        public DateTime? ShippedDate { get; set; }

        [Required(ErrorMessage = "Please enter your country.")]
        [Display(Name = "Country")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your city.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your address.")]
        public string AddressLine { get; set; } = string.Empty;

        public string AddressLine2 { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the product name.")]
        public string ProductName { get; set; } = string.Empty;
    }
}
