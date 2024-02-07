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
using System.Threading.Tasks;
using BlazorDemos;

namespace ej2_blazor_querybuilderdata
{
    public class HardWareDetails
    {
        public HardWareDetails()
        {

        }
        public HardWareDetails(int TaskID, string Name, string AssignedTo, string Note, string Category, DateTime WEO, string SerialNo, string InvoiceNo, DateTime DOP, string Status)
        {
            this.TaskID = TaskID;
            this.Name = Name;
            this.Note = Note;
            this.AssignedTo = AssignedTo;
            this.WEO = WEO;
            this.Category = Category;
            this.SerialNo = SerialNo;
            this.InvoiceNo = InvoiceNo;
            this.DOP = DOP;
            this.Status = Status;
        }
        public static List<HardWareDetails> GetAllRecords()
        {
            List<HardWareDetails> order = new List<HardWareDetails>();
            int code = 1000;
            for (int i = 1; i < 10; i++)
            {
                order.Add(new HardWareDetails(code + 1, "Lenovo Yoga", "John Doe", "Remarks are noted", "Laptop", new DateTime(2018, 05, 15), "CB27932009", "INV-0984", new DateTime(2021, 7, 16), "Assigned"));
                order.Add(new HardWareDetails(code + 2, "Acer Aspire", "David Anto", "Remarks are noted", "Monitor", new DateTime(2018, 04, 04), "CB35728290", "INV-2712", new DateTime(2020, 9, 11), "In-repair"));
                order.Add(new HardWareDetails(code + 3, "Apple MacBook", "Mary Saveley", "Remarks are noted", "Tablet", new DateTime(2018, 11, 30), "CB35628728", "INV-3782", new DateTime(2021, 10, 7), "Pending"));
                order.Add(new HardWareDetails(code + 4, "Lenovo ThinkPad", "Pascale Cartrain", "Remarks are noted", "Others", new DateTime(2018, 10, 22), "CB56209872", "INV-2980", new DateTime(2021, 12, 30), "Ordered"));
                order.Add(new HardWareDetails(code + 5, "Dell Inspiron", "Paul Henriot", "Remarks are noted", "Laptop", new DateTime(2017, 02, 18), "CB56289036", "INV-2763", new DateTime(2021, 12, 3), "Assigned"));
                order.Add(new HardWareDetails(code + 6, "HP Pavilion", "Mary Saveley", "Remarks are noted", "Tablet", new DateTime(2017, 02, 18), "CB56289305", "INV-3456", new DateTime(2021, 12, 3), "Pending"));
                order.Add(new HardWareDetails(code + 7, "Asus ZenBook", "John Doe", "Remarks are noted", "Monitor", new DateTime(2019, 02, 18), "CB25637891", "INV-2878", new DateTime(2021, 12, 3), "In-repair"));
                code += 7;
            }
            return order;
        }

        public int TaskID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string AssignedTo { get; set; }
        public DateTime WEO { get; set; }
        public string Category { get; set; }
        public string SerialNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime DOP { get; set; }
        public string Status { get; set; }
        public string ShipAddress { get; set; }
    }
}
