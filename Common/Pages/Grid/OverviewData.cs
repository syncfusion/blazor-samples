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
using System.Collections.ObjectModel;
using BlazorDemos;
using System.ComponentModel.DataAnnotations;

namespace blazor_overviewdata
{   
    public class OverviewData
    {
        public OverviewData()
        {

        }

        public static List<OverviewData> GetAllRecords(int DataCount)
        {
            string[] employees =  { "Michael", "Kathryn", "Tamer", "Martin", "Davolio", "Nancy", "Fuller", "Leverling", "Peacock",
                                    "Margaret", "Buchanan", "Janet", "Andrew", "Callahan", "Laura", "Dodsworth", "Anne",
                                    "Bergs", "Vinet", "Anton", "Fleet", "Zachery", "Van", "King", "Jack", "Rose"};

            string[] designation = { "Manager", "CFO", "Designer", "Developer", "Program Director", "System Analyst", "Project Lead" };
            string[] mail = { "sample.com", "arpy.com", "rpy.com", "mail.com", "jourrapide.com" };
            string[] location = { "UK", "USA", "Sweden", "France", "Canada", "Argentina", "Austria", "Germany", "Mexico" };
            string[] status = { "Active", "Inactive" };
            string[] trustworthiness = { "Perfect", "Sufficient", "Insufficient" };
            string[] address = {"59 rue de lAbbaye", "Luisenstr. 48", "Rua do Paço, 67", "2, rue du Commerce", "Boulevard Tirou, 255",
                                "Rua do mailPaço, 67", "Hauptstr. 31", "Starenweg 5", "Rua do Mercado, 12", "Carrera 22 con Ave. Carlos Soublette #8-35", "Kirchgasse 6",
                                "Sierras de Granada 9993", "Mehrheimerstr. 369", "Rua da Panificadora, 12", "2817 Milton Dr.", "Kirchgasse 6",
                                "Åkergatan 24", "24, place Kléber", "Torikatu 38", "Berliner Platz 43", "5ª Ave. Los Palos Grandes", "1029 - 12th Ave. S.",
                                "Torikatu 38", "P.O. Box 555", "2817 Milton Dr.", "Taucherstraße 10", "59 rue de lAbbaye", "Via Ludovico il Moro 22",
                                "Avda. Azteca 123", "Heerstr. 22", "Berguvsvägen  8", "Magazinweg 7", "Berguvsvägen  8", "Gran Vía, 1", "Gran Vía, 1",
                                "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Magazinweg 7", "Taucherstraße 10", "Taucherstraße 10",
                                "Av. Copacabana, 267", "Strada Provinciale 124", "Fauntleroy Circus", "Av. dos Lusíadas, 23",
                                "Rua da Panificadora, 12", "Av. Inês de Castro, 414", "Avda. Azteca 123", "2817 Milton Dr." };
            string[] employeeimg = { "usermale", "userfemale" };
            List<OverviewData> virtualData = new List<OverviewData>();
            int empName = 0; int position = 0; int place = 0; int statuscount = 0;
            int trust = 1; int star = 1; int empImage = 0; int salary = 104075;
            int addr = 0; int mailid = 0; int percentage = 0;
            for (var i = 0; i < DataCount; i++)
            {
                empName = empName >= employees.Length ? 0 : empName;
                position = position >= designation.Length ? 0 : position;
                place = place >= location.Length ? 0 : place;
                statuscount = statuscount >= status.Length ? 0 : statuscount;
                empImage = empImage >= employeeimg.Length ? 0 : empImage;
                addr = addr >= address.Length ? 0 : addr;
                mailid = mailid >= mail.Length ? 0 : mailid;
                percentage = i % 3 == 0 ? 27 : i % 6 == 0 ? 60 : i % 9 == 0 ? 92 : i % 2 == 0 ? 45 : 97;
                star = i % 3 == 0 ? 3 : i % 6 == 0 ? 4 : i % 9 == 0 ? 2 : i % 2 == 0 ? 1 : 5;
                trust = i % 3 == 0 ? 2 : i % 2 == 0 ? 1 : 0;
                statuscount = i % 3 == 0 ? 0 : i % 2 == 0 ? 1 : 0;
                virtualData.Add(new OverviewData()
                {
                    EmployeeID = 1000 + i,
                    Employees = employees[empName],
                    Designation = designation[position],
                    Location = location[place],
                    Status = status[statuscount],
                    Trustworthiness = trustworthiness[trust],
                    Rating = star,
                    Software = percentage,
                    EmployeeImg = employeeimg[empImage],
                    CurrentSalary = salary * (i + 1),
                    Mail = getMail(employees[empName], mail[mailid], mail),
                    Address = address[addr],
                });
                empName++; position++; place++; empImage++; addr++; mailid++;
            }
            return virtualData;
        }
        public static string getMail(string EmployeesName, string mailData, string[]mailList)
        {
            int number = mailList[0] == mailData ? 40 : mailList[1] == mailData ? 32 : mailList[2] == mailData ? 17 :
                mailList[3] == mailData ? 52 : mailList[4] == mailData ? 13 : 43;
            string Mail = EmployeesName.ToLower() + number + "@" + mailData;
            return Mail;
        }


        public int EmployeeID { get; set; }
        public string Employees { get; set; }
        public string Designation { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Trustworthiness { get; set; }
        public int Rating { get; set; }
        public int Software { get; set; }
        public string EmployeeImg { get; set; }
        public int CurrentSalary { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
    }

}