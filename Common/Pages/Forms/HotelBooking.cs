using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemos.Models.Form
{
    public enum Preference
    {
        Economic,
        Deluxe,
        UltraDeluxe,
        Suite
    }
    public class HotelBooking
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name" )]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your phone number.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Mail ID")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your address.")]
        [Display(Name = "Address Line")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter adults count.")]
        [Range(1, 5, ErrorMessage = "No of adults should between 1 and 5")]
        [Display(Name = "No of Adults")]
        public int AdultCount { get; set; }

        [Required(ErrorMessage = "Please enter your room preferences.")]
        [Display(Name = "Room Preferences")]
        public Preference RoomPreferences { get; set; }

        [Required(ErrorMessage = "Please enter your check-in date.")]
        [Display(Name = "Check In")]
        public DateTime CheckIn { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Please enter your check-out date.")]
        public DateTime? CheckOut { get; set;}

        [Display(Name = "Feel free to subscribe, and we'll gladly send you periodic emails.")]
        public bool Accept { get; set; }
    }
}
