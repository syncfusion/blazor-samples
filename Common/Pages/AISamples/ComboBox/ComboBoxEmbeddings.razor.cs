#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace BlazorDemos.Pages.AISamples.ComboBox
{
    public partial class ComboBoxEmbeddings
    {
        public class ExpenseCategory
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }
        public static List<ExpenseCategory> GetAllRecords()
        {
            return new List<ExpenseCategory>()
        {
            new ExpenseCategory() { ID = "Category1", Name = "Groceries" },
            new ExpenseCategory() { ID = "Category2", Name = "Utilities" },
            new ExpenseCategory() { ID = "Category3", Name = "Rent" },
            new ExpenseCategory() { ID = "Category4", Name = "Education" },
            new ExpenseCategory() { ID = "Category5", Name = "Car Payment" },
            new ExpenseCategory() { ID = "Category6", Name = "Car Insurance" },
            new ExpenseCategory() { ID = "Category7", Name = "Health Insurance" },
            new ExpenseCategory() { ID = "Category8", Name = "Life Insurance" },
            new ExpenseCategory() { ID = "Category9", Name = "Home Insurance" },
            new ExpenseCategory() { ID = "Category10", Name = "Gas" },
            new ExpenseCategory() { ID = "Category11", Name = "Public Transportation" },
            new ExpenseCategory() { ID = "Category12", Name = "Dining Out" },
            new ExpenseCategory() { ID = "Category13", Name = "Entertainment" },
            new ExpenseCategory() { ID = "Category14", Name = "Travel" },
            new ExpenseCategory() { ID = "Category15", Name = "Clothing" },
            new ExpenseCategory() { ID = "Category16", Name = "Electronics" },
            new ExpenseCategory() { ID = "Category17", Name = "Pet Care" },
            new ExpenseCategory() { ID = "Category18", Name = "Other" }
        };
        }
    }
}
