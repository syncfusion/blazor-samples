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
using BlazorDemos;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemos.Models.Form
{
    public class ProductDetails
    {
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter the brand.")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Please enter the color.")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Please enter the size.")]
        public string Size { get; set; }

        [Required(ErrorMessage = "Please enter the shipping address.")]
        public string ShippingAddress { get; set; }

        public string BillingAddress { get; set; }

        public string DeliveryInstructions { get; set; }

        [Required(ErrorMessage = "Please enter your contact number.")]
        public string ContactNumber { get; set; }
    }
}
