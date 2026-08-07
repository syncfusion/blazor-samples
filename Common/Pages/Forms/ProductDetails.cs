using System.ComponentModel.DataAnnotations;

namespace BlazorDemos.Models.Form
{
    public class ProductDetails
    {
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the brand.")]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the color.")]
        public string Color { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the size.")]
        public string Size { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the shipping address.")]
        public string ShippingAddress { get; set; } = string.Empty; 

        public string BillingAddress { get; set; } = string.Empty;

        public string DeliveryInstructions { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your contact number.")]
        public string ContactNumber { get; set; } = string.Empty;
    }
}
