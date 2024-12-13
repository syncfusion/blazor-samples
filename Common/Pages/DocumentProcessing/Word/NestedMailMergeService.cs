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
    public class NestedMailMergeService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public NestedMailMergeService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Update fields in the Word document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream NestedMailMerge(string Group1, string Group2, string documentType, string button)
        {
            //if (Group2 == null || Group3 == null)
            //    return View();
            MemoryStream ms = null;
            if (Group1 == "Report")
                ms = fileDataValue["template-report.doc"];
            else
                ms = fileDataValue["template-letter.doc"];
            if (button == "View Template")
            {
                return ms;
            }
            
            // Creating a new document.
            WordDocument document = new WordDocument();
            // Load template
            document.Open(ms, FormatType.Doc);

            #region Execute Mail merge
            if (Group2 == "Explicit")
            {
                MailMergeDataSet dataSet = GetMailMergeDataSet();
                List<DictionaryEntry> commands = new List<DictionaryEntry>();
                //DictionaryEntry contain "Source table" (KEY) and "Command" (VALUE)
                DictionaryEntry entry = new DictionaryEntry("Employees", string.Empty);
                commands.Add(entry);

                // To retrieve customer details
                entry = new DictionaryEntry("Customers", "EmployeeID = %Employees.EmployeeID%");
                commands.Add(entry);

                // To retrieve order details
                entry = new DictionaryEntry("Orders", "CustomerID = %Customers.CustomerID%");
                commands.Add(entry);

                //Executes nested Mail merge using explicit relational data.
                document.MailMerge.ExecuteNestedGroup(dataSet, commands);
            }
            else
            {
                MailMergeDataTable dataTable = GetMailMergeDataTable();
                //Executes nested Mail merge using implicit relational data.
                document.MailMerge.ExecuteNestedGroup(dataTable);
            }
            #endregion
            #region Document SaveOption
            FormatType formatType = FormatType.Docx;
            //Save as .doc format
            if (documentType == "WordDoc")
                formatType = FormatType.Doc;
            //Save as .xml format
            else if (documentType == "WordML")
                formatType = FormatType.WordML;
            //Save the document as a stream and retrun the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                document.Save(stream, formatType);
                document.Close();
                stream.Position = 0;
                return stream;
            }
            #endregion Document SaveOption            
        }
        #region Mail merge data
        /// <summary>
        /// Gets the mail merge data set.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private MailMergeDataSet GetMailMergeDataSet()
        {
            List<EmployeeDetails> employees = new List<EmployeeDetails>();
            List<CustomerDetails> customers = new List<CustomerDetails>();
            List<OrderDetails> orders = new List<OrderDetails>();


            XmlReader reader = XmlReader.Create(fileDataValue["employees.xml"]);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "EmployeesList")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            while (reader.LocalName != "EmployeesList")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Employees":
                            employees.Add(GetEmployee(reader, customers, orders));
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "EmployeesList") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            reader.Dispose();
            MailMergeDataSet dataSet = new MailMergeDataSet();
            dataSet.Add(new MailMergeDataTable("Employees", employees));
            dataSet.Add(new MailMergeDataTable("Customers", customers));
            dataSet.Add(new MailMergeDataTable("Orders", orders));
            return dataSet;
        }
        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="customers">The customers.</param>
        /// <param name="orders">The orders.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private EmployeeDetails GetEmployee(XmlReader reader, List<CustomerDetails> customers, List<OrderDetails> orders)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "Employees")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            EmployeeDetails employee = new EmployeeDetails();
            while (reader.LocalName != "Employees")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "EmployeeID":
                            employee.EmployeeID = reader.ReadElementContentAsString();
                            break;
                        case "LastName":
                            employee.LastName = reader.ReadElementContentAsString();
                            break;
                        case "FirstName":
                            employee.FirstName = reader.ReadElementContentAsString();
                            break;
                        case "Address":
                            employee.Address = reader.ReadElementContentAsString();
                            break;
                        case "City":
                            employee.City = reader.ReadElementContentAsString();
                            break;
                        case "Country":
                            employee.Country = reader.ReadElementContentAsString();
                            break;
                        case "Extension":
                            employee.Extension = reader.ReadElementContentAsString();
                            break;
                        case "Customers":
                            customers.Add(GetCustomer(reader, orders));
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Employees") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return employee;
        }
        /// <summary>
        /// Gets the customer.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="orders">The orders.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private CustomerDetails GetCustomer(XmlReader reader, List<OrderDetails> orders)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "Customers")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            CustomerDetails customer = new CustomerDetails();
            while (reader.LocalName != "Customers")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "EmployeeID":
                            customer.EmployeeID = reader.ReadElementContentAsString();
                            break;
                        case "CustomerID":
                            customer.CustomerID = reader.ReadElementContentAsString();
                            break;
                        case "CompanyName":
                            customer.CompanyName = reader.ReadElementContentAsString();
                            break;
                        case "ContactName":
                            customer.ContactName = reader.ReadElementContentAsString();
                            break;
                        case "City":
                            customer.City = reader.ReadElementContentAsString();
                            break;
                        case "Country":
                            customer.Country = reader.ReadElementContentAsString();
                            break;
                        case "Orders":
                            orders.Add(GetOrders(reader));
                            break;
                    }
                    reader.Read();
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Customers") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return customer;
        }

        /// <summary>
        /// Gets the mail merge data table.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private MailMergeDataTable GetMailMergeDataTable()
        {
            List<EmployeeDetailsImplicit> employees = new List<EmployeeDetailsImplicit>();


            XmlReader reader = XmlReader.Create(fileDataValue["employees.xml"]);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "EmployeesList")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            while (reader.LocalName != "EmployeesList")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Employees":
                            employees.Add(GetEmployee(reader));
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "EmployeesList") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            reader.Dispose();
            MailMergeDataTable dataTable = new MailMergeDataTable("Employees", employees);
            return dataTable;
        }
        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private EmployeeDetailsImplicit GetEmployee(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "Employees")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            EmployeeDetailsImplicit employee = new EmployeeDetailsImplicit();
            while (reader.LocalName != "Employees")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "EmployeeID":
                            employee.EmployeeID = reader.ReadElementContentAsString();
                            break;
                        case "LastName":
                            employee.LastName = reader.ReadElementContentAsString();
                            break;
                        case "FirstName":
                            employee.FirstName = reader.ReadElementContentAsString();
                            break;
                        case "Address":
                            employee.Address = reader.ReadElementContentAsString();
                            break;
                        case "City":
                            employee.City = reader.ReadElementContentAsString();
                            break;
                        case "Country":
                            employee.Country = reader.ReadElementContentAsString();
                            break;
                        case "Extension":
                            employee.Extension = reader.ReadElementContentAsString();
                            break;
                        case "Customers":
                            employee.Customers.Add(GetCustomer(reader));
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Employees") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return employee;
        }
        /// <summary>
        /// Gets the customer.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private CustomerDetailsImplicit GetCustomer(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "Customers")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            CustomerDetailsImplicit customer = new CustomerDetailsImplicit();
            while (reader.LocalName != "Customers")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "EmployeeID":
                            customer.EmployeeID = reader.ReadElementContentAsString();
                            break;
                        case "CustomerID":
                            customer.CustomerID = reader.ReadElementContentAsString();
                            break;
                        case "CompanyName":
                            customer.CompanyName = reader.ReadElementContentAsString();
                            break;
                        case "ContactName":
                            customer.ContactName = reader.ReadElementContentAsString();
                            break;
                        case "City":
                            customer.City = reader.ReadElementContentAsString();
                            break;
                        case "Country":
                            customer.Country = reader.ReadElementContentAsString();
                            break;
                        case "Orders":
                            customer.Orders.Add(GetOrders(reader));
                            break;
                    }
                    reader.Read();
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Customers") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return customer;
        }
        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">reader</exception>
        /// <exception cref="XmlException">Unexpected xml tag  + reader.LocalName</exception>
        private OrderDetails GetOrders(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "Orders")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            OrderDetails order = new OrderDetails();
            while (reader.LocalName != "Orders")
            {
                if (reader.NodeType != XmlNodeType.EndElement)
                {
                    switch (reader.LocalName)
                    {
                        case "OrderID":
                            order.OrderID = reader.ReadElementContentAsString();
                            break;
                        case "CustomerID":
                            order.CustomerID = reader.ReadElementContentAsString();
                            break;
                        case "OrderDate":
                            order.OrderDate = reader.ReadElementContentAsString();
                            break;
                        case "RequiredDate":
                            order.RequiredDate = reader.ReadElementContentAsString();
                            break;
                        case "ShippedDate":
                            order.ShippedDate = reader.ReadElementContentAsString();
                            break;
                    }
                    reader.Read();
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Orders") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return order;
        }
        #endregion
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

    #region Mailmerge data objects
    public class EmployeeDetailsImplicit
    {
        #region Fields
        private string m_employeeID;
        private string m_lastName;
        private string m_firstName;
        private string m_address;
        private string m_city;
        private string m_country;
        private string m_extension;
        private List<CustomerDetailsImplicit> m_customers;
        #endregion

        #region Properties
        public string EmployeeID
        {
            get { return m_employeeID; }
            set { m_employeeID = value; }
        }
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
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
        public string Extension
        {
            get { return m_extension; }
            set { m_extension = value; }
        }
        public List<CustomerDetailsImplicit> Customers
        {
            get
            {
                if (m_customers == null)
                    m_customers = new List<CustomerDetailsImplicit>();
                return m_customers;
            }
            set
            {
                m_customers = value;
            }
        }
        #endregion

        #region Constructor
        public EmployeeDetailsImplicit()
        {
            m_customers = new List<CustomerDetailsImplicit>();
        }
        #endregion
    }
    public class CustomerDetailsImplicit
    {
        #region Fields
        private string m_employeeID;
        private string m_customerID;
        private string m_companyName;
        private string m_city;
        private string m_country;
        private List<OrderDetails> m_orders;
        #endregion

        #region Properties
        public List<OrderDetails> Orders
        {
            get
            {
                if (m_orders == null)
                    m_orders = new List<OrderDetails>();
                return m_orders;
            }
            set
            {
                m_orders = value;
            }
        }
        public string EmployeeID
        {
            get { return m_employeeID; }
            set { m_employeeID = value; }
        }
        public string CustomerID
        {
            get { return m_customerID; }
            set { m_customerID = value; }
        }
        public string CompanyName
        {
            get { return m_companyName; }
            set { m_companyName = value; }
        }
        public string ContactName
        {
            get { return m_companyName; }
            set { m_companyName = value; }
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
        #endregion

        #region Constructor
        public CustomerDetailsImplicit()
        {
            m_orders = new List<OrderDetails>();
        }
        #endregion
    }
    public class EmployeeDetails
    {
        #region Fields
        private string m_employeeID;
        private string m_lastName;
        private string m_firstName;
        private string m_address;
        private string m_city;
        private string m_country;
        private string m_extension;
        #endregion

        #region Properties
        public string EmployeeID
        {
            get { return m_employeeID; }
            set { m_employeeID = value; }
        }
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
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
        public string Extension
        {
            get { return m_extension; }
            set { m_extension = value; }
        }
        #endregion
    }
    public class CustomerDetails
    {
        #region Fields
        private string m_employeeID;
        private string m_customerID;
        private string m_companyName;
        private string m_city;
        private string m_country;
        #endregion

        #region Properties
        public string EmployeeID
        {
            get { return m_employeeID; }
            set { m_employeeID = value; }
        }
        public string CustomerID
        {
            get { return m_customerID; }
            set { m_customerID = value; }
        }
        public string CompanyName
        {
            get { return m_companyName; }
            set { m_companyName = value; }
        }
        public string ContactName
        {
            get { return m_companyName; }
            set { m_companyName = value; }
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
        #endregion
    }
    public class OrderDetails
    {
        #region Fields
        private string m_orderID;
        private string m_customerID;
        private string m_orderDate;
        private string m_requiredDate;
        private string m_shippedDate;
        #endregion

        #region Properties
        public string OrderID
        {
            get { return m_orderID; }
            set { m_orderID = value; }
        }
        public string CustomerID
        {
            get { return m_customerID; }
            set { m_customerID = value; }
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
        #endregion
    }
    #endregion
}