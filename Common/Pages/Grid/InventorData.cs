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
namespace blazor_inventordata
{
    public class InventorDetails
    {
        public InventorDetails()
        {

        }
        public InventorDetails(string Active, string country, string Inventor, string Mainfieldsofinvention, int NumberofINPADOCpatents, int NumberofPatentFamilies)
        {
            this.NumberofPatentFamilies = NumberofPatentFamilies;
            this.Inventor = Inventor;
            this.NumberofINPADOCpatents = NumberofINPADOCpatents;
            this.Active = Active;
            this.Country = country;
            this.Mainfieldsofinvention = Mainfieldsofinvention;
        }
        public static List<InventorDetails> GetAllRecords()
        {
            List<InventorDetails> inventor = new List<InventorDetails>();
            inventor.Add(new InventorDetails("1994-2016", "Australia", "Kia Silverbrook", "Printing, Digital paper, Internet, Electronics,Lab-on-a-chip, MEMS, Mechanical, VLSI", 9839, 4737));
            inventor.Add(new InventorDetails("1976-2016", "Japan", "Shunpei Yamazaki", "Thin film transistors, Liquid crystal displays, Solar cells, Flash memory, OLED", 10000, 4677));
            inventor.Add(new InventorDetails("1977-2016", "USA", "Lowell L. Wood, Jr.", "Mosquito laser, Nuclear weapons", 1332, 1419));
            inventor.Add(new InventorDetails("2000-2016", "Australia", "Paul Lapstun", "Printing, Digital paper, Internet, Electronics, CGI, VLSI", 3099, 1281));
            inventor.Add(new InventorDetails("1991-2016", "India", "Gurtej Sandhu", "Thin film processes and materials, VLSI, Semiconductor device fabrication", 2038, 1255));
            inventor.Add(new InventorDetails("1991-2016", "Japan", "Jun Koyama", "Thin film transistors, Liquid crystal displays, OLED", 4126, 1240));
            inventor.Add(new InventorDetails("2001-2016", "USA", "Roderick A. Hyde", "Various", 3360, 1240));
            inventor.Add(new InventorDetails("1991-2016", "Canada", "Leonard Forbes", "Semiconductor Memories, CCDs, Thin film processes and materials, VLSI", 1398, 1093));
            inventor.Add(new InventorDetails("1847(b)-1931(d)", "USA", "Thomas Edison", "Electric power, Lighting, Batteries, Phonograph, Cement, Telegraphy, Mining", 2332, 1084));
            inventor.Add(new InventorDetails("1976-2015", "USA", "Donald E. Weder", "Florist supplies", 1993, 999));
            inventor.Add(new InventorDetails("1882(b)-1961(d)", "Canada", "George Albert Lyon", "Automotive, Stainless steel products", 23, 993));
            inventor.Add(new InventorDetails("1864(b)-1938(d)", "USA", "John F. O'Connor", "Railway draft gearing", 23, 949));
            inventor.Add(new InventorDetails("1895(b)-1963(d)", "USA", "Melvin De Groote", "Chemical de-emulsifiers", 23, 925));
            inventor.Add(new InventorDetails("1998-2016", "USA", "Jay S. Walker", "Gaming machines", 2206, 918));
            inventor.Add(new InventorDetails("1996-2016", "USA", "Edward K. Y. Jung", "Various", 2254, 911));
            inventor.Add(new InventorDetails("1850(b)-19??(d)", "USA", "Francis H. Richards", "Mechanical, automation", 45, 894));
            inventor.Add(new InventorDetails("2004-2016", "USA", "Kangguo Cheng", "Semiconductor device fabrication, Semiconductor memory, Semiconductor device", 1314, 884));
            inventor.Add(new InventorDetails("2000-2016", "USA", "Clarence T. Tegreene", "Various", 2255, 872));
            inventor.Add(new InventorDetails("2002-2016", "USA", "Ahmadreza Rofougaran", "Radio Frequency Integrated Circuits", 1396, 808));
            inventor.Add(new InventorDetails("2006-2016", "China", "Shou-Shan Fan", "Carbon nanotubes and applications of carbon nanotubes", 2120, 805));
            inventor.Add(new InventorDetails("1977-2016", "USA", "Michael J. Sullivan", "Golf balls", 1560, 788));
            inventor.Add(new InventorDetails("1999-2016", "USA", "Rick Allen Hamilton II", "Various", 1064, 773));
            inventor.Add(new InventorDetails("1990-2016", "USA", "Warren Farnworth", "Semiconductor packaging", 931, 770));
            inventor.Add(new InventorDetails("1876(b)-1941(d)", "USA", "Carleton Ellis", "Margarine, Polyester, Anti-knock gasoline, Paint stripper", 234, 753));
            inventor.Add(new InventorDetails("1994-2016", "USA", "William H. Eby", "Transgenic soybeans", 758, 733));
            inventor.Add(new InventorDetails("1983-2016", "Japan", "Hideo Ando", "Optical recording", 2588, 728));
            inventor.Add(new InventorDetails("1995-2016", "USA", "Salman Akram", "Semiconductor packaging", 915, 728));
            inventor.Add(new InventorDetails("1976-1998", "USA", "George Spector", "Gadgets, Toys", 747, 722));
            inventor.Add(new InventorDetails("1996-2016", "USA", "Jeyhan Karaoguz", "Wireless communications, Computer networks", 1530, 721));
            inventor.Add(new InventorDetails("1853(b)-1937(d)", "UK", "Elihu Thomson", "Electric power, Arc lamp, Electric motors, Lightning arrester, Arc welder", 2423, 696));
            inventor.Add(new InventorDetails("1999-2016", "USA", "Austin L. Gurney", "Proteins, Antibodies", 3909, 695));
            inventor.Add(new InventorDetails("1987-2015", "Japan", "Tetsujiro Kondo", "Signal processing, Image processing", 4158, 684));
            inventor.Add(new InventorDetails("1994-2016", "USA", "Nathan Myhrvold", "Various", 1690, 661));
            inventor.Add(new InventorDetails("1981-2016", "USA", "William I. Wood", "Proteins, Antibodies", 3560, 653));
            inventor.Add(new InventorDetails("1995-2015", "Australia", "Simon R. Walmsley", "Printing, Electronics, VLSI, Cryptography", 1249, 651));
            inventor.Add(new InventorDetails("1997-2016", "USA", "Mark Malamud", "Various", 1759, 632));
            inventor.Add(new InventorDetails("1997-2016", "USA", "Royce A. Levien", "Various", 1799, 630));
            inventor.Add(new InventorDetails("1997-2014", "USA", "Audrey D. Goddard", "Proteins, Antibodies", 3416, 622));
            inventor.Add(new InventorDetails("2002-2016", "USA", "Muriel Y. Ishikawa", "Various", 1660, 619));
            inventor.Add(new InventorDetails("2003-2016", "USA", "Robert W. Lord", "Various", 1708, 618));
            inventor.Add(new InventorDetails("1923(b)-1997(d)", "USA", "Jerome Lemelson", "Toys, Industrial robots, Cordless telephones, Fax machines, Videocassette recinventor", 1313, 606));
            inventor.Add(new InventorDetails("1907(b)-1997(d)", "Austria", "BÃ©la BarÃ©nyi", "Passive safety in automobiles", 1244, 595));
            inventor.Add(new InventorDetails("1976-2016", "USA", "Kie Y Ahn", "Thin film processes and materials, VLSI, Semiconductor device fabrication", 709, 593));
            inventor.Add(new InventorDetails("1981-2016", "Japan", "Tadahiro Ohmi", "Thin film processes and materials, Semiconductor device fabrication", 2691, 592));
            inventor.Add(new InventorDetails("1992-2016", "USA", "Jordin T. Kare", "Various", 1559, 585));
            inventor.Add(new InventorDetails("1994-2014", "USA", "Paul J. Godowski", "Proteins, Antibodies", 2605, 579));
            inventor.Add(new InventorDetails("1976-2002", "Germany", "Artur Fischer", "Fasteners, Construction toys", 3097, 570));
            inventor.Add(new InventorDetails("1979-2016", "USA", "Edward J. Nowak", "Semiconductor device fabrication, Semiconductor memory, Semiconductor device", 1145, 564));
            inventor.Add(new InventorDetails("1988-2016", "USA", "Louis L. Hsu", "Various", 914, 551));
            inventor.Add(new InventorDetails("1909(b)-1991(d)", "USA", "Edwin H. Land", "Instant photography, Polarizing film", 1236, 535));
            inventor.Add(new InventorDetails("1882(b)-1944(d)", "Switzerland", "Henri Dreyfus", "Polymers, Synthetic fibers, Dyes", 2117, 524));
            inventor.Add(new InventorDetails("1995-2016", "USA", "Bruce B. Doris", "Integrated Circuits, CMOS, DRAM, Semiconductor device fabrication", 867, 522));
            inventor.Add(new InventorDetails("18??(b)-19??(d)", "USA", "Clyde C. Farmer", "Railway air brakes", 830, 513));
            inventor.Add(new InventorDetails("1976-2013", "Germany", "Heinz Focke", "Cigarette packaging", 2896, 512));
            inventor.Add(new InventorDetails("1994-2010", "USA", "Mark I. Gardner", "Consumer electronics, Energy, Computers, Semiconductors, Physics", 587, 511));
            inventor.Add(new InventorDetails("1992-2016", "India", "Ravi K. Arimilli", "Computer architecture, Semiconductor memory, Cache coherence, Symmetric multiprocessing", 767, 506));
            inventor.Add(new InventorDetails("18??(b)-19??(d)", "USA", "Louis H. Morin", "Fasteners, Locks, Bobbins", 720, 503));
            inventor.Add(new InventorDetails("2000-2015", "Australia", "Tobin A. King", "Printing, Digital paper, Mechanical", 1218, 497));
            inventor.Add(new InventorDetails("2006-2016", "USA", "Eric C. Leuthardt", "Medical devices", 1274, 495));
            inventor.Add(new InventorDetails("2011-2016", "USA", "Ali Khakifirooz", "Integrated Circuits, CMOS, Semiconductor device fabrication", 737, 489));
            inventor.Add(new InventorDetails("1987-2014", "USA", "Jack A. Mandelman", "Various", 889, 481));
            inventor.Add(new InventorDetails("1992-2016", "USA", "Jeffrey P. Gambino", "MEMS, CMOS, BiCMOS, DRAM, Image Sensors, RF, Biosensors, 3D Integrated Circuits", 798, 479));
            inventor.Add(new InventorDetails("2001-2016", "USA", "John M. Santosuosso", "Various", 683, 473));
            inventor.Add(new InventorDetails("1988-2016", "USA", "James M. Hart", "Motor vehicle transmission", 1145, 464));
            inventor.Add(new InventorDetails("1979-2015", "Germany", "Eberhard Ammermann", "Fungicides", 5178, 451));
            inventor.Add(new InventorDetails("1860(b)-1929(d)", "USA", "Thomas E. Murray", "Electrical, HVAC, Wheels, Metal working, Light dimmer", 462, 449));
            inventor.Add(new InventorDetails("1980-2016", "Australia", "Akira Nakazawa", "Printing, Mechanical", 1340, 445));
            inventor.Add(new InventorDetails("1993-2016", "Japan", "Hongyong Zhang", "Thin film transistors, Liquid crystal displays", 858, 440));
            inventor.Add(new InventorDetails("1986-2016", "USA", "Ronald S. John", "OLED displays; image processing", 747, 436));
            inventor.Add(new InventorDetails("1983-2016", "USA", "Imad K. Stamper", "Biotechnology, Drug delivery, Tissue engineering", 1759, 430));
            inventor.Add(new InventorDetails("2001-2016", "USA", "Scott H. Wittkopp", "Motor vehicle transmission", 1010, 429));
            inventor.Add(new InventorDetails("1888(b)-1965(d)", "USA", "John Hays Hammond, Jr.", "Radio control, Radio communications, Torpedoes", 460, 417));
            inventor.Add(new InventorDetails("1976-2010", "Germany", "Wilhelm Brandes", "Fungicides", 2923, 411));
            inventor.Add(new InventorDetails("1998-2016", "USA", "Anthony K. Stamper", "MEMS, CMOS, BiCMOS, Silicon-germanium", 726, 411));
            inventor.Add(new InventorDetails("1993-2016", "USA", "Hossein Eslambolchi", "Telecommunications, Network intelligence, information Technology, communications technology", 631, 410));
            inventor.Add(new InventorDetails("1922(b)-2012(d)", "USA", "Stanford R. Ovshinsky", "Batteries, Solar cells, Liquid crystal displays, Hydrogen fuel cells, Computer data storage", 1649, 400));
            inventor.Add(new InventorDetails("2009-2016", "USA", "Victoria Y. H. Wood", "Various", 1045, 400));
            inventor.Add(new InventorDetails("1976-2016", "Austria", "Josef Theurer", "Railroad maintenance machines", 5085, 388));
            inventor.Add(new InventorDetails("1994-2016", "USA", "Cary L. Bates", "Programming tools, DBX, Memory debuggers", 570, 384));
            inventor.Add(new InventorDetails("1992-2016", "USA", "David V. Horak", "Various", 616, 380));
            inventor.Add(new InventorDetails("2006-2016", "China", "Kai-Li Jiang", "Carbon nanotubes and applications of carbon nanotubes", 829, 379));
            inventor.Add(new InventorDetails("1986-2013", "Germany", "Hans-Joachim Santel", "Herbicides, Pesticides, Organic chemistry", 2623, 377));
            inventor.Add(new InventorDetails("1997-2017", "USA", "Xuemin (Sherman) Chen", "Computer networks, Integrated Circuits, Signal Processing", 1151, 377));
            inventor.Add(new InventorDetails("1983-2016", "China", "George P. Liang", "Gas turbine cooling", 508, 375));
            inventor.Add(new InventorDetails("1990-2015", "Germany", "Gisela Lorenz", "Fungicides, Organic chemistry", 4155, 374));
            inventor.Add(new InventorDetails("2001-2016", "Australia", "Garry R. Jackson", "Printing, Mechanical", 656, 367));
            inventor.Add(new InventorDetails("1984-2015", "USA", "Paul W. Dent", "Wireless communications", 2252, 362));
            inventor.Add(new InventorDetails("1846(b))-1914(d)", "USA", "George Westinghouse", "Electric power, Electricity meter, Railway air brake, Steam engines", 232, 361));
            inventor.Add(new InventorDetails("2003-2016", "USA", "Wael W. Diab", "Computer networks", 774, 358));
            inventor.Add(new InventorDetails("1983-2016", "India", "Devendra K. Sadana", "Solar cells, OLED, Integrated Circuits, CMOS, DRAM, LEDs", 794, 356));
            inventor.Add(new InventorDetails("1999-2016", "USA", "Vincent J. Zimmer", "Computer software and firmware", 972, 354));
            inventor.Add(new InventorDetails("1971-2005", "Germany", "Robert R. Schmidt", "Herbicides, Fungicides, Organic chemistry", 2467, 350));
            inventor.Add(new InventorDetails("2006-2016", "Australia", "Norman M. Berry", "Printing, Mechanical", 516, 347));
            inventor.Add(new InventorDetails("2003-2016", "USA", "Chih-Chao Yang", "Integrated Circuits", 690, 345));
            inventor.Add(new InventorDetails("2008-2016", "USA", "Gregory J. Boss", "Various", 588, 345));
            inventor.Add(new InventorDetails("1987-2016", "USA", "Mark W. Kroll", "Implantable medical devices", 460, 343));
            inventor.Add(new InventorDetails("2009-2016", "USA", "Brian M. O'Connell", "Various", 592, 331));
            inventor.Add(new InventorDetails("1986-2016", "USA", "William Daniel Hillis", "Various", 229, 328));
            inventor.Add(new InventorDetails("2001-2016", "USA", "Brent A. Anderson", "Semiconductor device fabrication, Semiconductor memory, Semiconductor device", 454, 323));
            inventor.Add(new InventorDetails("1994-2016", "USA", "Jeffrey E. Stahmann", "Medical devices", 640, 321));
            inventor.Add(new InventorDetails("1994-2016", "USA", "Carl J. Radens", "Integrated Circuits, CMOS, DRAM, Semiconductor device fabrication", 636, 317));
            inventor.Add(new InventorDetails("1992-2016", "USA", "Clifford A. Pickover", "Various", 653, 317));
            inventor.Add(new InventorDetails("2005-2016", "China", "Liang Liu", "Carbon nanotubes and applications of carbon nanotubes", 777, 310));
            inventor.Add(new InventorDetails("1995-2016", "USA", "Steven L. Teig", "Integrated Circuits", 366, 307));
            inventor.Add(new InventorDetails("2006-2016", "USA", "Victoria Smith", "Proteins, Antibodies", 2040, 305));
            inventor.Add(new InventorDetails("1888(b)-1969(d)", "USA", "Robert G. LeTourneau", "Earthworks (engineering), Heavy Equipment, Industrial Machinery", 56, 299));
            inventor.Add(new InventorDetails("1994-2016", "USA", "William R. Tonti", "Integrated Circuits, CMOS, DRAM, Semiconductor device fabrication", 441, 291));
            inventor.Add(new InventorDetails("2003-2016", "Saudi Arabia", "Keith R. Walker", "Various", 318, 282));
            inventor.Add(new InventorDetails("1982-2016", "USA", "Victor S. Moore", "Various", 428, 280));
            inventor.Add(new InventorDetails("1987-2016", "USA", "Hanson S. Gifford III", "Medical Devices", 795, 276));
            inventor.Add(new InventorDetails("1982-2016", "USA", "Daniel J. Winarski", "Various", 506, 275));
            inventor.Add(new InventorDetails("1968-2016", "Romania", "Adam Heller", "Solar cells, Glucose meters, Lasers", 711, 272));
            inventor.Add(new InventorDetails("2009-2016", "USA", "Lisa Seacat DeLuca", "Various", 385, 271));
            inventor.Add(new InventorDetails("1994-2016", "USA", "Brent Keeth", "Integrated Circuits, CMOS, DRAM", 470, 270));
            inventor.Add(new InventorDetails("1976-2010", "USA", "Hartley Owen", "Fluid catalytic cracking", 751, 267));
            inventor.Add(new InventorDetails("2001-2017", "USA", "Michael A. Rothman", "Computer software and firmware", 687, 256));
            inventor.Add(new InventorDetails("1994-2015", "Japan", "Yoshihiro Kikuchi", "Video processing", 1120, 255));
            inventor.Add(new InventorDetails("2003-2016", "USA", "Kulvir S. Bhogal", "Various", 486, 252));
            inventor.Add(new InventorDetails("2000-2017", "Sweden", "Bengt Lindoff", "Wireless communications", 1658, 248));
            inventor.Add(new InventorDetails("1979-2015", "Japan", "Nobuyuki Taniguchi", "Cameras", 967, 245));
            inventor.Add(new InventorDetails("1979-2016", "USA", "Dean L. Kamen", "Battery-powered electric vehicles, Medical devices, Stirling engines, Water purification, Wheelchairs", 1186, 243));
            inventor.Add(new InventorDetails("1982-2016", "USA", "Philip S. Yu", "Various", 158, 236));
            inventor.Add(new InventorDetails("1986-2016", "USA", "Rajiv V. Joshi", "Electronics, analytics", 354, 235));
            inventor.Add(new InventorDetails("1996-2017", "USA", "Lawrence A. Clevenger", "Semiconductor, Cognitive, Memory, Security, Analytics", 526, 235));
            inventor.Add(new InventorDetails("1996-2016", "USA", "Johnny M. Shieh", "Various", 444, 231));
            inventor.Add(new InventorDetails("1995-2016", "Japan", "Takeshi Chujoh", "Video processing", 1065, 229));
            inventor.Add(new InventorDetails("1986-2017", "USA", "Bran Ferren", "Computers, Consumer Electronics, Optical Systems, Medical, User Interfaces, Automotive", 589, 225));
            inventor.Add(new InventorDetails("2008-2016", "Australia", "Paul Ian Mackey", "Printing, Mechanical", 246, 220));
            inventor.Add(new InventorDetails("1995-2016", "USA", "Louis Rosenberg", "Augmented Reality, Virtual Reality, A.I., HCI", 444, 218));
            inventor.Add(new InventorDetails("1992-2016", "USA", "Thomas J. Kennedy III", "Sporting Goods, Wind Turbines", 513, 218));
            inventor.Add(new InventorDetails("1997-2016", "USA", "Gerald F. McBrearty", "Various", 387, 213));
            inventor.Add(new InventorDetails("2000-2017", "USA", "Esmael H. Dinan", "Communication Networks", 344, 208));
            inventor.Add(new InventorDetails("2007-2017", "USA", "Imad Libbus", "Medical devices", 472, 207));
            inventor.Add(new InventorDetails("1997-2015", "Japan", "Hiroshi (You) Yoshioka", "Cameras", 181, 205));
            inventor.Add(new InventorDetails("1999-2016", "USA", "Patrick B. Usoro", "Transmissions, Hybrid Powertrains, Vehicle Thermal Management", 343, 205));
            inventor.Add(new InventorDetails("2003-2014", "Australia", "Gregory McAvoy", "Printing, MEMS", 433, 205));
            inventor.Add(new InventorDetails("1989-2017", "USA", "Sebastian T Ventrone", "Semiconductor, Logic, Architecture", 283, 204));
            inventor.Add(new InventorDetails("2003-2017", "USA", "Dorin Comaniciu", "Machine Intelligence, Medical Imaging, Image-Guided Surgery, Computer Vision", 452, 200));
            return inventor;
        }
        public int? NumberofPatentFamilies { get; set; }
        public string Inventor { get; set; }
        public int? NumberofINPADOCpatents { get; set; }
        public string Country { get; set; }
        public string Mainfieldsofinvention { get; set; }
        public string Active { get; set; }
    }
}