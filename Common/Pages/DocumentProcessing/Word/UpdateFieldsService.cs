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
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class UpdateFieldsService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public UpdateFieldsService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Update fields in the Word document
        /// </summary>
        /// <returns>Return the resultant Word document as stream</returns>
        public MemoryStream UpdateFields(string documentType, string button)
        {            
            if (button == "View Template")
            {
                return fileDataValue["template-update-fields.docx"];
            }
            //Loads the template document.
            WordDocument document = new WordDocument(fileDataValue["template-update-fields.docx"], FormatType.Docx);

            //Create MailMergeDataTable
            MailMergeDataTable mailMergeDataTableStock = GetMailMergeDataTableStock();
            // Execute Mail Merge with groups.
            document.MailMerge.ExecuteGroup(mailMergeDataTableStock);

            //Update fields in the document.
            document.UpdateDocumentFields();

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
        /// <summary>
        /// Gets the mail merge data table.
        /// </summary>       
        private MailMergeDataTable GetMailMergeDataTableStock()
        {
            List<StockDetails> stockDetails = new List<StockDetails>();
            XmlReader reader = XmlReader.Create(fileDataValue["stock-details.xml"]);
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "StockMarket")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            while (reader.LocalName != "StockMarket")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "StockDetails":
                            stockDetails.Add(GetStockDetails(reader));
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "StockMarket") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            MailMergeDataTable dataTable = new MailMergeDataTable("StockDetails", stockDetails);
            reader.Dispose();
            return dataTable;
        }
        /// <summary>
        /// Gets the StockDetails.
        /// </summary>
        /// <param name="reader">The reader.</param>
        private StockDetails GetStockDetails(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
            if (reader.LocalName != "StockDetails")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);
            reader.Read();
            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            StockDetails stockDetails = new StockDetails();
            while (reader.LocalName != "StockDetails")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "TradeNo":
                            stockDetails.TradeNo = reader.ReadElementContentAsString();
                            break;
                        case "CompanyName":
                            stockDetails.CompanyName = reader.ReadElementContentAsString();
                            break;
                        case "CostPrice":
                            stockDetails.CostPrice = reader.ReadElementContentAsString();
                            break;
                        case "SharesCount":
                            stockDetails.SharesCount = reader.ReadElementContentAsString();
                            break;
                        case "SalesPrice":
                            stockDetails.SalesPrice = reader.ReadElementContentAsString();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "StockDetails") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return stockDetails;
        }
        #region HelperMethod
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
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
    public class StockDetails
    {
        #region Fields
        private string m_tradeNo;
        private string m_companyName;
        private string m_costPrice;
        private string m_sharesCount;
        private string m_salesPrice;
        #endregion
        #region Properties
        public string TradeNo
        {
            get { return m_tradeNo; }
            set { m_tradeNo = value; }
        }
        public string CompanyName
        {
            get { return m_companyName; }
            set { m_companyName = value; }
        }
        public string CostPrice
        {
            get { return m_costPrice; }
            set { m_costPrice = value; }
        }
        public string SharesCount
        {
            get { return m_sharesCount; }
            set { m_sharesCount = value; }
        }
        public string SalesPrice
        {
            get { return m_salesPrice; }
            set { m_salesPrice = value; }
        }
        #endregion
        #region Constructor
        public StockDetails(string tradeNo, string companyName, string costPrice, string sharesCount, string salesPrice)
        {
            m_tradeNo = tradeNo;
            m_companyName = companyName;
            m_costPrice = costPrice;
            m_sharesCount = sharesCount;
            m_salesPrice = salesPrice;
        }
        public StockDetails()
        { }
        #endregion
    }
}