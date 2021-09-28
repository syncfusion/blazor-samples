using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace ej2_blazor_selfdata
{
    public class SelfReferenceData
    {
        public static List<SelfReferenceData> tree = new List<SelfReferenceData>();
        [Key]
        public int? TaskID { get; set; }
        public string TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public String Progress { get; set; }
        public String Priority { get; set; }
        public double? Duration { get; set; }
        public int? ParentID { get; set; }
        public bool? isParent { get; set; }
        public bool? Approved { get; set; }
        public int? ParentItem { get; set;}
        public SelfReferenceData() { }
        public static List<SelfReferenceData> GetTree()
        {
                tree.Clear();
                int root = -1;
                int TaskNameID = 0;
                int ChildCount = -1;
                int SubTaskCount = -1;
                for (var t = 1; t <= 60; t++)
                {
                Random gen = new Random();
                Random ran = new Random();
                DateTime start = new DateTime(1992, 06, 07);
                int range = (DateTime.Today - start).Days;
                DateTime startingDate = start.AddDays(gen.Next(range));
                DateTime end = new DateTime(1994, 08, 25);
                int endrange = (DateTime.Today - end).Days;
                DateTime endingDate = end.AddDays(gen.Next(endrange));

                string math = (ran.Next() % 3) == 0 ? "High" : (ran.Next() % 2) == 0 ? "Low" : "Critical";
                    string progr = (ran.Next() % 3) == 0 ? "Started" : (ran.Next() % 2) == 0 ? "Open" : "In Progress";
                    bool appr = (ran.Next() % 3) == 0 ? true : (ran.Next() % 2) == 0 ? false : true;
                    root++; TaskNameID++;
                    int rootItem = root + 1;
                    tree.Add(new SelfReferenceData() { TaskID = rootItem, TaskName = "Parent Task " + TaskNameID.ToString(), StartDate = startingDate, EndDate = endingDate, isParent = true, ParentID = null, Progress = progr, Priority = math, Duration = ran.Next(1, 50), Approved = appr });
       
                    int parent = tree.Count;
                    for (var c = 0; c < 2; c++)
                    {
                    DateTime start1 = new DateTime(1992, 07, 09);
                    int range1 = (DateTime.Today - start1).Days;
                    DateTime startingDate1 = start1.AddDays(gen.Next(range1));
                    DateTime end1 = new DateTime(1993, 08, 23);
                    int endrange1 = (DateTime.Today - end1).Days;
                    DateTime endingDate1 = end1.AddDays(gen.Next(endrange1));
                    root++; ChildCount++;
                        string val = ((parent + c + 1) % 3 == 0) ? "Low" : "Critical";
                        int parn = parent + c + 1;
                        progr = (ran.Next() % 3) == 0 ? "In Progress" : (ran.Next() % 2) == 0 ? "Open" : "Validated";
                        appr = (ran.Next() % 3) == 0 ? true : (ran.Next() % 2) == 0 ? false : true;
                        int iD = root + 1;
                        tree.Add(new SelfReferenceData() { TaskID = iD, TaskName = "Child Task " + (ChildCount + 1).ToString(), StartDate = startingDate1, EndDate = endingDate1, isParent = (((parent + c + 1) % 3) == 0), ParentID = rootItem, Progress = progr, Priority = val, Duration = ran.Next(1, 50), Approved = appr });
                        
                        if ((((parent + c + 1) % 3) == 0))
                        {
                        int immParent = tree.Count;
                            for (var s = 0; s < 3; s++)
                            {
                            DateTime start2 = new DateTime(1992, 05, 05);
                            int range2 = (DateTime.Today - start2).Days;
                            DateTime startingDate2 = start2.AddDays(gen.Next(range2));
                            DateTime end2 = new DateTime(1993, 06, 16);
                            int endrange2 = (DateTime.Today - end2).Days;
                            DateTime endingDate2 = end2.AddDays(gen.Next(endrange2));
                            root++; SubTaskCount++;
                                string Prior = (immParent % 2 == 0) ? "Validated" : "Normal";
                                tree.Add(new SelfReferenceData() { TaskID = root + 1, TaskName = "Sub Task " + (SubTaskCount + 1).ToString(), StartDate = startingDate2, EndDate = endingDate2, isParent = false, ParentID = iD, Progress = (immParent % 2 == 0) ? "On Progress" : "Closed", Priority = Prior, Duration = ran.Next(1, 50), Approved = appr });
                            }
                        }
                    }
                }
            return tree;
        }
    }
}
