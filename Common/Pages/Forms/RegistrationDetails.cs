#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Syncfusion.Blazor.DataForm;

namespace BlazorDemos.Models.Form
{
    public enum City
    {
        NewYork,
        LosAngeles,
        Chicago,
        Houston,
        Phoenix,
        Philadelphia,
        SanAntonio,
        SanDiego,
        Dallas,
        SanJose
    }

    public class BookingDetails
    {
        [Required(ErrorMessage = "Please enter the passenger's name.")]
        [Display(Name = "Passenger name")]
        [DataFormDisplayOptionsAttribute(ColumnSpan = 6)]
        [DataType(DataType.Text)]
        public string PassengerName { get; set; }

        [Required(ErrorMessage = "Please enter a 10-digit phone number.")]
        [Range(typeof(long), "1000000000", "9999999999", ErrorMessage = "Invalid phone number format.")]
        [Display(Name = "Contact number")]
        [DataFormDisplayOptionsAttribute(ColumnSpan = 3)]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email ID")]
        [DataFormDisplayOptionsAttribute(ColumnSpan = 3)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a departure date for your trip.")]
        [Display(Name = "Departure date")]
        [DataFormDisplayOptionsAttribute(ColumnSpan = 3)]
        public DateTime? DepartureDate { get; set; }

        [Required(ErrorMessage = "Please enter the number of tickets.")]
        [Range(1, 10, ErrorMessage = "Number of tickets should be between 1 and 10.")]
        [Display(Name = "Number of tickets")]
        [DataFormDisplayOptionsAttribute(ColumnSpan = 3)]
        public int? NumberOfTickets { get; set; }

        [Required(ErrorMessage = "Please select the departure city.")]
        [DataFormDisplayOptionsAttribute(ColumnSpan = 3)]
        public City? DepartureCity { get; set; }

        [Required(ErrorMessage = "Please select the destination city")]
        [DataFormDisplayOptionsAttribute(ColumnSpan = 3)]
        public City? DestinationCity { get; set; }
    }

    public class RegistrationDetails
    {
        public RegistrationDetails()
        {

        }

        [Required(ErrorMessage = "Email ID is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [RegularExpression(@"^\d{10}$", ErrorMessage = "Please enter a valid 10-digit phone number.")]
        public string PhoneNumber { get; set; }

        public string Job { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        public string ZipCode { get; set; }

        [Required(ErrorMessage = "You must accept the Terms and Conditions.")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the Terms and Conditions")]
        public bool TermsAndConditions { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
