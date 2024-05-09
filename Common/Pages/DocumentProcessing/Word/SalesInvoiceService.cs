#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class SalesInvoiceService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public SalesInvoiceService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Update fields in the Word document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream CreateWordDocument(int id, string documentType, string button)
        {
            if (id == 0)
                id = 10248;          
            if (button == "View Template")
            {
                return fileDataValue["sales-invoice-demo.doc"];
            }

            // Create a new document
            WordDocument document = new WordDocument();
            // Load the template.
            document.Open(fileDataValue["sales-invoice-demo.doc"], FormatType.Automatic);
            //Create MailMergeDataTable
            MailMergeDataTable mailMergeDataTableOrder = GetTestOrder(id);
            MailMergeDataTable mailMergeDataTableOrderTotals = GetTestOrderTotals(id);
            MailMergeDataTable mailMergeDataTableOrderDetails = GetTestOrderDetails(id);
            // Execute Mail Merge with groups.
            document.MailMerge.ExecuteGroup(mailMergeDataTableOrder);
            document.MailMerge.ExecuteGroup(mailMergeDataTableOrderTotals);
            // Using Merge events to do conditional formatting during runtime.
            document.MailMerge.MergeField += new MergeFieldEventHandler(MailMerge_MergeField);
            document.MailMerge.ExecuteGroup(mailMergeDataTableOrderDetails);
            FormatType formatType = FormatType.Docx;
            //Save as .doc format
            if (documentType == "WordDoc")            
                formatType = FormatType.Doc;                
            //Save as .xml format
            else if (documentType == "WordML")
                formatType = FormatType.WordML;            
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, formatType);
                document.Close();
                stream.Position = 0;
                return stream;
            }
        }

        private void MailMerge_MergeField(object sender, MergeFieldEventArgs args)
        {
            // Conditionally format data during Merge.
            if (args.RowIndex % 2 == 0)
            {
                args.CharacterFormat.TextColor = Syncfusion.Drawing.Color.DarkBlue;
            }

        }

        private MailMergeDataTable GetTestOrder(int TestOrderId)
        {
            List<TestOrder> orders = new List<TestOrder>();
            XmlReader reader = XmlReader.Create(fileDataValue["test-order.xml"]);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrders")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            while (reader.LocalName != "TestOrders")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "TestOrder":
                            TestOrder testOrder = GetTestOrder(reader);
                            if (testOrder.OrderID == TestOrderId.ToString())
                            {
                                orders.Add(testOrder);
                                break;
                            }
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrders") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }

            MailMergeDataTable dataTable = new MailMergeDataTable("Orders", orders);
            reader.Dispose();
            return dataTable;

        }

        private MailMergeDataTable GetTestOrderDetails(int TestOrderId)
        {
            List<TestOrderDetail> orders = new List<TestOrderDetail>();
            XmlReader reader = XmlReader.Create(fileDataValue["test-order-details.xml"]);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrderDetails")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            while (reader.LocalName != "TestOrderDetails")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "TestOrderDetail":
                            TestOrderDetail testOrder = GetTestOrderDetail(reader);
                            if (testOrder.OrderID == TestOrderId.ToString())
                            {
                                orders.Add(testOrder);
                                break;
                            }
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrderDetails") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }

            MailMergeDataTable dataTable = new MailMergeDataTable("Order", orders);
            reader.Dispose();
            return dataTable;

        }
        private MailMergeDataTable GetTestOrderTotals(int TestOrderId)
        {
            List<TestOrderTotal> orders = new List<TestOrderTotal>();
            XmlReader reader = XmlReader.Create(fileDataValue["order-totals.xml"]);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrderTotals")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            while (reader.LocalName != "TestOrderTotals")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "TestOrderTotal":
                            TestOrderTotal testOrder = GetTestOrderTotal(reader);
                            if (testOrder.OrderID == TestOrderId.ToString())
                            {
                                orders.Add(testOrder);
                                break;
                            }
                            break;
                    }
                    reader.Read();
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrderTotals") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }

            MailMergeDataTable dataTable = new MailMergeDataTable("OrderTotals", orders);
            reader.Dispose();
            return dataTable;
        }

        private TestOrder GetTestOrder(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrder")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            TestOrder testOrder = new TestOrder();
            while (reader.LocalName != "TestOrder")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "ShipName":
                            testOrder.ShipName = reader.ReadElementContentAsString();
                            break;
                        case "ShipAddress":
                            testOrder.ShipAddress = reader.ReadElementContentAsString();
                            break;
                        case "ShipCity":
                            testOrder.ShipCity = reader.ReadElementContentAsString();
                            break;
                        case "ShipPostalCode":
                            testOrder.ShipPostalCode = reader.ReadElementContentAsString();
                            break;
                        case "ShipCountry":
                            testOrder.ShipCountry = reader.ReadElementContentAsString();
                            break;
                        case "PostalCode":
                            testOrder.PostalCode = reader.ReadElementContentAsString();
                            break;
                        case "CustomerID":
                            testOrder.CustomerID = reader.ReadElementContentAsString();
                            break;
                        case "Customers.CompanyName":
                            testOrder.Customers_CompanyName = reader.ReadElementContentAsString();
                            break;
                        case "HomePage":
                            testOrder.Salesperson = reader.ReadElementContentAsString();
                            break;
                        case "Address":
                            testOrder.Address = reader.ReadElementContentAsString();
                            break;
                        case "City":
                            testOrder.City = reader.ReadElementContentAsString();
                            break;
                        case "Country":
                            testOrder.Country = reader.ReadElementContentAsString();
                            break;
                        case "OrderID":
                            testOrder.OrderID = reader.ReadElementContentAsString();
                            break;
                        case "OrderDate":
                            testOrder.OrderDate = reader.ReadElementContentAsString();
                            break;
                        case "RequiredDate":
                            testOrder.RequiredDate = reader.ReadElementContentAsString();
                            break;
                        case "ShippedDate":
                            testOrder.ShippedDate = reader.ReadElementContentAsString();
                            break;
                        case "Shippers.CompanyName":
                            testOrder.Shippers_CompanyName = reader.ReadElementContentAsString();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrders") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return testOrder;
        }
        private ArrayList GetTestOrderID()
        {
            XmlReader reader = XmlReader.Create(fileDataValue["test-order.xml"]);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrders")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            ArrayList orderId = new ArrayList();

            while (reader.LocalName != "TestOrders")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "OrderID":
                            orderId.Add(reader.ReadElementContentAsString());
                            break;
                        default:
                            break;
                    }
                    reader.Read();
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrders") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }

            return orderId;
        }
        private TestOrderDetail GetTestOrderDetail(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrderDetail")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            TestOrderDetail testOrderDetail = new TestOrderDetail();
            while (reader.LocalName != "TestOrderDetail")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "OrderID":
                            testOrderDetail.OrderID = reader.ReadElementContentAsString();
                            break;
                        case "ProductID":
                            testOrderDetail.ProductID = reader.ReadElementContentAsString();
                            break;
                        case "ProductName":
                            testOrderDetail.ProductName = reader.ReadElementContentAsString();
                            break;
                        case "UnitPrice":
                            testOrderDetail.UnitPrice = reader.ReadElementContentAsString();
                            break;
                        case "Quantity":
                            testOrderDetail.Quantity = reader.ReadElementContentAsString();
                            break;
                        case "Discount":
                            testOrderDetail.Discount = reader.ReadElementContentAsString();
                            break;
                        case "ExtendedPrice":
                            testOrderDetail.ExtendedPrice = reader.ReadElementContentAsString();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrderDetail") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return testOrderDetail;
        }
        private TestOrderTotal GetTestOrderTotal(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrderTotal")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            TestOrderTotal testOrderTotal = new TestOrderTotal();
            while (reader.LocalName != "TestOrderTotal")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "OrderID":
                            testOrderTotal.OrderID = reader.ReadElementContentAsString();
                            break;
                        case "Subtotal":
                            testOrderTotal.Subtotal = reader.ReadElementContentAsString();
                            break;
                        case "Freight":
                            testOrderTotal.Freight = reader.ReadElementContentAsString();
                            break;
                        case "Total":
                            testOrderTotal.Total = reader.ReadElementContentAsString();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrderTotal") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return testOrderTotal;
        }
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
        #region HelperMethod
        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item in fileDataValue)
            {
                item.Value.Dispose();
            }
            fileDataValue.Clear();
            
        }
        #endregion
    }

    public class TestOrderDetail
    {
        #region Fields

        private string m_orderID;
        private string m_productID;
        private string m_productName;
        private string m_unitPrice;
        private string m_quantity;
        private string m_discount;
        private string m_extendedPrice;
        #endregion

        #region Properties

        public string OrderID
        {
            get { return m_orderID; }
            set { m_orderID = value; }
        }

        public string ProductID
        {
            get { return m_productID; }
            set { m_productID = value; }
        }
        public string ProductName
        {
            get { return m_productName; }
            set { m_productName = value; }
        }
        public string UnitPrice
        {
            get { return m_unitPrice; }
            set { m_unitPrice = value; }
        }
        public string Quantity
        {
            get { return m_quantity; }
            set { m_quantity = value; }
        }
        public string Discount
        {
            get { return m_discount; }
            set { m_discount = value; }
        }
        public string ExtendedPrice
        {
            get { return m_extendedPrice; }
            set { m_extendedPrice = value; }
        }

        #endregion

        #region Constructor       
        public TestOrderDetail()
        { }
        #endregion
    }
    public class TestOrderTotal
    {
        #region Fields

        private string m_orderID;
        private string m_subTotal;
        private string m_freight;
        private string m_total;
        #endregion

        #region Properties

        public string OrderID
        {
            get { return m_orderID; }
            set { m_orderID = value; }
        }

        public string Subtotal
        {
            get { return m_subTotal; }
            set { m_subTotal = value; }
        }
        public string Freight
        {
            get { return m_freight; }
            set { m_freight = value; }
        }
        public string Total
        {
            get { return m_total; }
            set { m_total = value; }
        }
        #endregion

        #region Constructor       
        public TestOrderTotal()
        { }
        #endregion
    }
    public class TestOrder
    {
        #region Fields

        private string m_orderID;
        private string m_shipName;
        private string m_shipAddress;
        private string m_shipCity;
        private string m_shipPostalCode;
        private string m_shipCountry;
        private string m_customerID;
        private string m_address;
        private string m_postalCode;
        private string m_city;
        private string m_country;
        private string m_salesPerson;
        private string m_customersCompanyName;
        private string m_orderDate;
        private string m_requiredDate;
        private string m_shippedDate;
        private string m_shippersCompanyName;
        #endregion

        #region Properties

        public string ShipName
        {
            get { return m_shipName; }
            set { m_shipName = value; }
        }

        public string ShipAddress
        {
            get { return m_shipAddress; }
            set { m_shipAddress = value; }
        }
        public string ShipCity
        {
            get { return m_shipCity; }
            set { m_shipCity = value; }
        }
        public string ShipPostalCode
        {
            get { return m_shipPostalCode; }
            set { m_shipPostalCode = value; }
        }
        public string PostalCode
        {
            get { return m_postalCode; }
            set { m_postalCode = value; }
        }
        public string ShipCountry
        {
            get { return m_shipCountry; }
            set { m_shipCountry = value; }
        }
        public string CustomerID
        {
            get { return m_customerID; }
            set { m_customerID = value; }
        }
        public string Customers_CompanyName
        {
            get { return m_customersCompanyName; }
            set { m_customersCompanyName = value; }
        }
        public string Address
        {
            get { return m_address; }
            set { m_address = value; }
        }

        public string City
        {
            get { return m_city; }
            set { m_city = value; }
        }

        public string Country
        {
            get { return m_country; }
            set { m_country = value; }
        }
        public string Salesperson
        {
            get { return m_salesPerson; }
            set { m_salesPerson = value; }
        }
        public string OrderID
        {
            get { return m_orderID; }
            set { m_orderID = value; }
        }
        public string OrderDate
        {
            get { return m_orderDate; }
            set { m_orderDate = value; }
        }
        public string RequiredDate
        {
            get { return m_requiredDate; }
            set { m_requiredDate = value; }
        }
        public string ShippedDate
        {
            get { return m_shippedDate; }
            set { m_shippedDate = value; }
        }
        public string Shippers_CompanyName
        {
            get { return m_shippersCompanyName; }
            set { m_shippersCompanyName = value; }
        }
        #endregion

        #region Constructor       
        public TestOrder()
        { }
        #endregion
    }
}