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

namespace BlazorDemos.Pages.AISamples.TreeGrid
{
    public partial class AdaptiveDataStructuring
    {
        public class TreeData
        {
            public class BusinessObject
            {
                public int CategoryId { get; set; }
                public string CategoryName { get; set; }
                public string Status { get; set; }
                public DateTime OrderDate { get; set; }
                public int? ParentId { get; set; }

            }

            public static List<BusinessObject> GetAdaptiveStructureData()
            {
                List<BusinessObject> BusinessObjectCollection = new List<BusinessObject>();
                BusinessObjectCollection.Add(new BusinessObject() { CategoryId = 1, CategoryName = "Electronics", Status = "Available", OrderDate = new DateTime(2021, 7, 12), ParentId = null });
                BusinessObjectCollection.Add(new BusinessObject() { CategoryId = 2, CategoryName = "Cell phone", Status = "out of Stock", OrderDate = new DateTime(2021, 6, 17), ParentId = 1 });
                BusinessObjectCollection.Add(new BusinessObject() { CategoryId = 3, CategoryName = "Computer", Status = "Available", OrderDate = new DateTime(2021, 7, 12), ParentId = 7 });
                BusinessObjectCollection.Add(new BusinessObject() { CategoryId = 4, CategoryName = "Cloth", Status = "Available", OrderDate = new DateTime(2021, 10, 5), ParentId = null });
                BusinessObjectCollection.Add(new BusinessObject() { CategoryId = 5, CategoryName = "Silk", Status = "Out of Stock", OrderDate = new DateTime(2021, 9, 2), ParentId = 7 });
                BusinessObjectCollection.Add(new BusinessObject() { CategoryId = 6, CategoryName = "Chair", Status = "Available", OrderDate = new DateTime(2021, 3, 3), ParentId = 1 });
                BusinessObjectCollection.Add(new BusinessObject() { CategoryId = 7, CategoryName = "Furniture", Status = "Available", OrderDate = new DateTime(2021, 3, 5), ParentId = null });
                BusinessObjectCollection.Add(new BusinessObject() { CategoryId = 8, CategoryName = "Bed", Status = "Available", OrderDate = new DateTime(2021, 3, 5), ParentId = 7 });
                BusinessObjectCollection.Add(new BusinessObject() { CategoryId = 9, CategoryName = "Fabrics", Status = "Available", OrderDate = new DateTime(2021, 10, 5), ParentId = 4 });
                return BusinessObjectCollection;
            }
        }
    }
}
