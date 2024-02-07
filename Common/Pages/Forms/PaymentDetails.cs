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
using FluentValidation;

namespace BlazorDemos.Models.Form
{

    public class PaymentDetails
    {
        [Required(ErrorMessage = "Please enter your payment amount.")]
        [Display(Name = "Payable Amount")]
        [Range(1, 10000000)]
        public double PaymentAmount { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "Name on card")]
        public string NameOnCard { get; set; }

        [Required(ErrorMessage = "Please enter your card number.")]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Please enter card expiry date.")]
        public DateTime? ExpiryDate { get; set; }

        [Required(ErrorMessage = "Please enter security code.")]
        [Display(Name = "Security Code")]
        public string SecurityCode { get; set; }

        [Required(ErrorMessage = "Please enter your shipping address.")]
        [Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; }

        [Display(Name = "Billing Address")]
        public string BillingAddress { get; set; }

        [Required(ErrorMessage = "Please enter your zip code.")]
        public int? ZipCode { get; set; }

        [Required(ErrorMessage = "Please agree with the terms.")]
        [Display(Name = "Accept terms and conditions")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Please agree with the terms.")]
        public bool AcceptTerms { get; set; }
    }

    public class FluentValidator : AbstractValidator<PaymentDetails>
    {
        public FluentValidator()
        {
            RuleFor(customer => customer.NameOnCard).NotEmpty().WithMessage("Name should not be empty").MinimumLength(5).WithMessage("Name should contains atleast 5 characters").MaximumLength(50).WithMessage("Name should not exceeds 50 characters");
            RuleFor(customer => customer.CardNumber).NotEmpty().WithMessage("Please enter card number").CreditCard().WithMessage("Please enter valid card number");
            RuleFor(customer => customer.ExpiryDate).NotEmpty().WithMessage("Please choose/enter expiry date");
            RuleFor(customer => customer.SecurityCode).NotEmpty().WithMessage("Security code should not be empty").Length(3).WithMessage("Security code should contains 3 digits");
            RuleFor(customer => customer.AcceptTerms).Equal(true).WithMessage("You must accept the terms and conditions to proceed further");
            RuleFor(customer => customer.ZipCode).NotEmpty().WithMessage("Please select the zip code.");
            RuleFor(customer => customer.ShippingAddress).NotEmpty().WithMessage("Please enter shipping address details.");
        }
    }
}