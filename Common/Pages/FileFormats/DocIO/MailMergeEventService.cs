#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Xml;

namespace BlazorDemos.Data.FileFormats.DocIO
{
    public class MailMergeEventService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public MailMergeEventService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public MemoryStream MailMergeEvent(string Group1, string Button)
        {
            string basePath = @"wwwroot/";
            string dataPath = basePath + @"data/docio/mail-merge-event-template.doc";
            FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            
            if (Button == "View Template")
            {
                MemoryStream ms = new MemoryStream();
                fileStream.Position = 0;
                fileStream.CopyTo(ms);
                fileStream.Close();
                return ms;
            }
            fileStream.Dispose();
            fileStream = null;

            try
            {
                // Load the template.                
                FileStream fileStreamPath = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                WordDocument document = new WordDocument(fileStreamPath, FormatType.Doc);
                fileStreamPath.Dispose();
                fileStreamPath = null;

                // Using Merge events to do conditional formatting during runtime.
                document.MailMerge.MergeField += new MergeFieldEventHandler(AlternateRows_MergeField);
                document.MailMerge.MergeImageField += new MergeImageFieldEventHandler(MergeField_ProductImage);

                //Create MailMergeDataTable
                MailMergeDataTable mailMergeDataTablePriceList = GetMailMergeDataTablePriceList();
                MailMergeDataTable mailMergeDataTableProductData = GetMailMergeDataTableProductData();

                // Execute Mail Merge with groups.
                document.MailMerge.ExecuteGroup(mailMergeDataTablePriceList);
                document.MailMerge.ExecuteGroup(mailMergeDataTableProductData);
                FormatType type = FormatType.Docx;
                #region Document SaveOption
                //Save as .doc format
                if (Group1 == "WordDoc")
                {
                    type = FormatType.Doc;
                }
                //Save as .xml format
                else if (Group1 == "WordML")
                {
                    type = FormatType.WordML;
                }
                #endregion Document SaveOption
                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Word document to MemoryStream
                    document.Save(stream, type);
                    document.Close();
                    stream.Position = 0;
                    return stream;
                }
            }
            catch (Exception)
            { return null; }
           
        }
        private void AlternateRows_MergeField(object sender, MergeFieldEventArgs args)
        {
            // Conditionally format data during Merge.
            if (args.RowIndex % 2 == 0)
            {
                args.CharacterFormat.TextColor = Syncfusion.Drawing.Color.FromArgb(255, 102, 0);
            }
        }

        private void MergeField_ProductImage(object sender, MergeImageFieldEventArgs args)
        {
            // Get the image from disk during Merge.
            if (args.FieldName == "ProductImage")
            {
                string ProductFileName = args.FieldValue.ToString();
                FileStream fs = new FileStream(@"wwwroot/images/docio/" + ProductFileName, FileMode.Open, FileAccess.Read);
                args.ImageStream = fs;
            }
        }

        /// <summary>
        /// Gets the mail merge data table.
        /// </summary>       
        private MailMergeDataTable GetMailMergeDataTablePriceList()
        {
            List<Product_PriceList> product_PriceList = new List<Product_PriceList>();
            FileStream fs = new FileStream(@"wwwroot/data/docio/product-price-list.xml", FileMode.Open, FileAccess.Read);
            XmlReader reader = XmlReader.Create(fs);
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "Products")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            while (reader.LocalName != "Products")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Product_PriceList":
                            product_PriceList.Add(GetProduct_PriceList(reader));
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Products") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            MailMergeDataTable dataTable1 = new MailMergeDataTable("Product_PriceList", product_PriceList);
            reader.Dispose();
            fs.Dispose();
            return dataTable1;
        }
        /// <summary>
        /// Gets the product price list.
        /// </summary>
        /// <param name="reader">The reader.</param>       
        private Product_PriceList GetProduct_PriceList(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "Product_PriceList")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            Product_PriceList product_PriceList = new Product_PriceList();
            while (reader.LocalName != "Product_PriceList")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "ProductName":
                            product_PriceList.ProductName = reader.ReadElementContentAsString();
                            break;
                        case "Price":
                            product_PriceList.Price = reader.ReadElementContentAsString();
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Product_PriceList") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return product_PriceList;
        }
        /// <summary>
        /// Gets the mail merge data table.
        /// </summary>        
        private MailMergeDataTable GetMailMergeDataTableProductData()
        {
            List<ProductDetail> productDetail = new List<ProductDetail>();
            FileStream fs = new FileStream(@"wwwroot/data/docio/product.xml", FileMode.Open, FileAccess.Read);
            XmlReader reader = XmlReader.Create(fs);
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "ProductList")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            while (reader.LocalName != "ProductList")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Products":
                            productDetail.Add(GetProductDetail(reader));
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "ProductList") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            MailMergeDataTable dataTable2 = new MailMergeDataTable("ProductDetail", productDetail);
            reader.Dispose();
            fs.Dispose();
            return dataTable2;
        }
        /// <summary>
        /// Gets the product details.
        /// </summary>
        /// <param name="reader">The reader.</param>
        private ProductDetail GetProductDetail(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "Products")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            ProductDetail productDetail = new ProductDetail();
            while (reader.LocalName != "Products")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "SNO":
                            productDetail.SNO = reader.ReadElementContentAsString();
                            break;
                        case "ProductName":
                            productDetail.ProductName = reader.ReadElementContentAsString();
                            break;
                        case "ProductImage":
                            productDetail.ProductImage = reader.ReadElementContentAsString();
                            break;

                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "Products") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return productDetail;
        }
    }
    public class Product_PriceList
    {
        #region Fields
        private string m_productName;
        private string m_price;

        #endregion
        #region Properties
        public string ProductName
        {
            get { return m_productName; }
            set { m_productName = value; }
        }
        public string Price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        #endregion
        #region Constructor
        public Product_PriceList(string productName, string price)
        {
            m_productName = productName;
            m_price = price;

        }
        public Product_PriceList()
        { }
    }
    #endregion
    public class ProductDetail
    {
        #region Fields
        private string m_sNO;
        private string m_productName;
        private string m_productImage;

        #endregion
        #region Properties
        public string SNO
        {
            get { return m_sNO; }
            set { m_sNO = value; }
        }
        public string ProductName
        {
            get { return m_productName; }
            set { m_productName = value; }
        }
        public string ProductImage
        {
            get { return m_productImage; }
            set { m_productImage = value; }
        }

        #endregion
        #region Constructor
        public ProductDetail(string sNO, string productName, string productImage)
        {
            m_sNO = sNO;
            m_productName = productName;
            m_productImage = productImage;

        }
        public ProductDetail()
        { }
        #endregion
    }
}