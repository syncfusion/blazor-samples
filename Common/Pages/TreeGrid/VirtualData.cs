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

namespace ej2_blazor_virtualdata
{

    public class SelfReferenceData
    {
        public static List<SelfReferenceData> tree = new List<SelfReferenceData>();
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Progress { get; set; }
        public String Priority { get; set; }
        public int Duration { get; set; }
        public int? ParentItem { get; set; }
        public bool? IsParent { get; set; }
        public SelfReferenceData() { }
        public static List<SelfReferenceData> GetTree()
        {
            if (tree.Count == 0)
            {
                int root = -1;
                for (var t = 1; t <= 10000; t++)
                {
                    int duration = (t % 2 == 0) ? 52 : (t % 5 == 0) ? 14 : (t % 3 == 0) ? 25 : 34;
                    string math = (t % 3) == 0 ? "High" : (t % 2) == 0 ? "Release Breaker" : "Critical";
                    string progr = (t % 3) == 0 ? "Started" : (t % 2) == 0 ? "Open" : "In Progress";
                    root++;
                    int rootItem = tree.Count + root + 1;
                    tree.Add(new SelfReferenceData() { TaskID = rootItem, TaskName = "Parent task " + rootItem.ToString(), StartDate = new DateTime(2021, 06, 07), EndDate = new DateTime(2023, 08, 25), IsParent = true, ParentItem = null, Progress = progr, Priority = math, Duration = duration});
                    int parent = tree.Count;
                    for (var c = 0; c < 2; c++)
                    {
                        root++;
                        string val = ((parent + c + 1) % 3 == 0) ? "Low" : "Critical";
                        int parn = parent + c + 1;
                        progr = (t % 3) == 0 ? "In Progress" : (t % 2) == 0 ? "Open" : "Validated";
                        int iD = tree.Count + root + 1;
                        tree.Add(new SelfReferenceData() { TaskID = iD, TaskName = "Child task " + iD.ToString(), StartDate = new DateTime(2021, 06, 07), EndDate = new DateTime(2023, 08, 25), IsParent = (((parent + c + 1) % 3) == 0), ParentItem = rootItem, Progress = progr, Priority = val, Duration = duration });
                        if ((((parent + c + 1) % 3) == 0))
                        {
                            int immParent = tree.Count;
                            for (var s = 0; s < 2; s++)
                            {
                                root++;
                                string Prior = (immParent % 2 == 0) ? "Validated" : "Normal";
                                tree.Add(new SelfReferenceData() { TaskID = tree.Count + root + 1, TaskName = "Sub task " + (tree.Count + root + 1).ToString(), StartDate = new DateTime(2021, 06, 07), EndDate = new DateTime(2023, 08, 25), IsParent = false, ParentItem = iD, Progress = (immParent % 2 == 0) ? "In Progress" : "Closed", Priority = Prior, Duration = duration });
                            }
                        }
                    }
                }
            }
            return tree;
        }
    }
    public class VirtualData
    {
        public int TaskID { get; set; }
        public string FIELD1 { get; set; }
        public int FIELD2 { get; set; }
        public int FIELD3 { get; set; }
        public int FIELD4 { get; set; }
        public int FIELD5 { get; set; }
        public int FIELD6 { get; set; }
        public int Field7 { get; set; }
        public int Field8 { get; set; }
        public int Field9 { get; set; }
        public int Field10 { get; set; }
        public int Field11 { get; set; }
        public int Field12 { get; set; }
        public int Field13 { get; set; }
        public int Field14 { get; set; }
        public int Field15 { get; set; }
        public int Field16 { get; set; }
        public int Field17 { get; set; }
        public int Field18 { get; set; }
        public int Field19 { get; set; }
        public int Field20 { get; set; }
        public int? ParentID { get; set; }
        public static List<VirtualData> GetTreeVirtualData()
        {
            string[] Names = new string[] { "VINET", "TOMSP", "HANAR", "VICTE", "SUPRD", "HANAR", "CHOPS", "RICSU", "WELLI", "HILAA", "ERNSH", "CENTC",
            "OTTIK", "QUEDE", "RATTC", "ERNSH", "FOLKO", "BLONP", "WARTH", "FRANK", "GROSR", "WHITC", "WARTH", "SPLIR", "RATTC", "QUICK", "VINET",
            "MAGAA", "TORTU", "MORGK", "BERGS", "LEHMS", "BERGS", "ROMEY", "ROMEY", "LILAS", "LEHMS", "QUICK", "QUICK", "RICAR", "REGGC", "BSBEV",
            "COMMI", "QUEDE", "TRADH", "TORTU", "RATTC", "VINET", "LILAS", "BLONP", "HUNGO", "RICAR", "MAGAA", "WANDK", "SUPRD", "GODOS", "TORTU",
            "OLDWO", "ROMEY", "LONEP", "ANATR", "HUNGO", "THEBI", "DUMON", "WANDK", "QUICK", "RATTC", "ISLAT", "RATTC", "LONEP", "ISLAT", "TORTU",
            "WARTH", "ISLAT", "PERIC", "KOENE", "SAVEA", "KOENE", "BOLID", "FOLKO", "FURIB", "SPLIR", "LILAS", "BONAP", "MEREP", "WARTH", "VICTE",
            "HUNGO", "PRINI", "FRANK", "OLDWO", "MEREP", "BONAP", "SIMOB", "FRANK", "LEHMS", "WHITC", "QUICK", "RATTC", "FAMIA" };
            List<VirtualData> DataCollection = new List<VirtualData>();
            var RecordID = 0;
            for (var i = 1; i <= 2000; i++)
            {
                var name = (i % 100);
                VirtualData Parent = new VirtualData()
                {
                    TaskID = ++RecordID,
                    FIELD1 = Names[name],
                    FIELD2 = (i % 2 == 0) ? 1967 + 2 : (i % 5 == 0) ? 1967 + 8 : 1967 + 12,
                    FIELD3 = (i % 2 == 0) ? 395 + 2 : (i % 5 == 0) ? 395 + 1 : 395 + 25,
                    FIELD4 = (i % 2 == 0) ? 87 + 2 : (i % 5 == 0) ? 87 + 1 : 87 + 15,
                    FIELD5 = (i % 2 == 0) ? 410 + 2 : (i % 5 == 0) ? 410 + 1 : 410 + 45,
                    FIELD6 = (i % 2 == 0) ? 67 + 2 : (i % 5 == 0) ? 67 + 1 : 67 + 6,
                    Field7 = (i % 2 == 0) ? 35 + 2  : (i % 5 == 0) ? 24 + 1 : 45 + 12,
                    Field8 = (i % 2 == 0) ? 100 + 2 : (i % 5 == 0) ? 100 + 1 : 100 + 12,
                    Field9 = (i % 2 == 0) ? 35 + 2 : (i % 5 == 0) ? 24 + 1 : 45 + 12,
                    Field10 = (i % 2 == 0) ? 46 + 2 : (i % 5 == 0) ? 46 + 1 : 64 + 6,
                    Field11 = (i % 2 == 0) ? 67 + 2 : (i % 5 == 0) ? 67 + 1 : 67 + 6,
                    Field12 = (i % 2 == 0) ? 100 + 62 : (i % 5 == 0) ? 100 + 41 : 100 + 112,
                    Field13 = (i % 2 == 0) ? 2 + 2 : (i % 5 == 0) ? 1 + 1 : 1 + 6,
                    Field14 = (i % 2 == 0) ? 46 + 2 : (i % 5 == 0) ? 46 + 1 : 64 + 6,
                    Field15 = (i % 2 == 0) ? 1000 + 112 : (i % 5 == 0) ? 1000 + 153 : 1000 + 412,
                    Field16 = (i % 2 == 0) ? 210 + 23 : (i % 5 == 0) ? 210 + 12 : 210 + 621,
                    Field17 = (i % 2 == 0) ? 300 + 533 : (i % 5 == 0) ? 300 + 321 : 300 + 699,
                    Field18 = (i % 2 == 0) ? 400 + 232 : (i % 5 == 0) ? 400 + 153 : 400 + 342,
                    Field19 = (i % 2 == 0) ? 40 + 12 : (i % 5 == 0) ? 40 + 24 : 40 + 25,
                    Field20 = (i % 2 == 0) ? 700 + 423 : (i % 5 == 0) ? 700 + 53 : 700 + 43,
                    ParentID = null
                };
                DataCollection.Add(Parent);
                for (var j = 1; j <= 4; j++)
                {
                    var childName = ((i +j) % 100);
                    DataCollection.Add(new VirtualData()
                    {
                        TaskID = ++RecordID,
                        FIELD1 = Names[childName],
                        FIELD2 = (j % 3 == 0) ? 1967 + (j + 2) : (j % 4 == 0) ? 1967 + (j + 1) : 1967 + j,
                        FIELD3 = (j % 3 == 0) ? 395 + (j + 2) : (j % 4 == 0) ? 395 + (j + 4) : 395 + (j + 13),
                        FIELD4 = (j % 3 == 0) ? 87 + (j + 2) : (j % 4 == 0) ? 87 + (j + 1) : 87 + (j + 12),
                        FIELD5 = (j % 3 == 0) ? 410 + (j + 2) : (j % 4 == 0) ? 410 + (j + 1) : 410 + (j + 14),
                        FIELD6 = (j % 3 == 0) ? 67 + (j + 2) : (j % 4 == 0) ? 67 + (j + 1) : 67 + (j + 7),
                        Field7 = (j % 3 == 0) ? 89 + (j + 2) : (j % 4 == 0) ? 94 + (j + 1) : 23 + (j + 7),
                        Field8 = (j % 3 == 0) ? 76 + (j + 2) : (j % 4 == 0) ? 23 + (j + 1) : 45 + (j + 7),
                        Field9 = (j % 3 == 0) ? 87 + (j + 2) : (j % 4 == 0) ? 87 + (j + 1) : 87 + (j + 12),
                        Field10 = (j % 3 == 0) ? 54 + (j + 2) : (j % 4 == 0) ? 54 + (j + 1) : 54 + (j + 12),
                        Field11 = (j % 3 == 0) ? 280 + (j + 2) : (j % 4 == 0) ? 280 + (j + 1) : 280 + (j + 12),
                        Field12 = (j % 3 == 0) ? 126 + (j + 2) : (j % 4 == 0) ? 116 + (j + 1) : 156 + (j + 12),
                        Field13 = (j % 3 == 0) ? 12 + (j + 2) : (j % 4 == 0) ? 12 + (j + 1) : 12 + (j + 12),
                        Field14 = (j % 3 == 0) ? 54 + (j + 2) : (j % 4 == 0) ? 53 + (j + 1) : 23 + (j + 12),
                        Field15 = (j % 3 == 0) ? 1003 + (j + 2) : (j % 4 == 0) ? 1100 + (j + 1) : 1000 + (j + 12),
                        Field16 = (j % 3 == 0) ? 210 + (j + 2) : (j % 4 == 0) ? 237 + (j + 1) : 290 + (j + 12),
                        Field17 = (j % 3 == 0) ? 300 + (j + 2) : (j % 4 == 0) ? 300 + (j + 1) : 300 + (j + 12),
                        Field18 = (j % 3 == 0) ? 400 + (j + 2) : (j % 4 == 0) ? 400 + (j + 1) : 400 + (j + 12),
                        Field19 = (j % 3 == 0) ? 40 + (j + 2) : (j % 4 == 0) ? 40 + (j + 1) : 40 + (j + 12),
                        Field20 = (j % 3 == 0) ? 700 + (j + 2) : (j % 4 == 0) ? 700 + (j + 1) : 700 + (j + 12),   
                        ParentID = Parent.TaskID
                    }) ;
                }


                

            }
            return DataCollection;

        }

    }
}
