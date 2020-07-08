using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace ej2_blazor_ganttdata
{
    public class GanttData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public DateTime? BaselineStartDate { get; set; }
            public DateTime? BaselineEndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public List<TaskData> SubTasks { get; set; }
            public object ResourceId { get; set; }
            public string Notes { get; set; }
            public string TaskType { get; set; }
        }
        public class TaskResources
        {
            public int ResourceId { get; set; }
            public string ResourceName { get; set; }
        }
        public static List<TaskResources> EditingResources()
        {
            List<TaskResources> TaskResourcesCollection = new List<TaskResources>();

            TaskResources Record1 = new TaskResources()
            {
                ResourceId = 1,
                ResourceName = "Martin Tamer"
            };
            TaskResources Record2 = new TaskResources()
            {
                ResourceId = 2,
                ResourceName = "Rose Fuller"
            };
            TaskResources Record3 = new TaskResources()
            {
                ResourceId = 3,
                ResourceName = "Margaret Buchanan"
            };
            TaskResources Record4 = new TaskResources()
            {
                ResourceId = 4,
                ResourceName = "Fuller King"
            };
            TaskResources Record5 = new TaskResources()
            {
                ResourceId = 5,
                ResourceName = "Davolio Fuller"
            };
            TaskResources Record6 = new TaskResources()
            {
                ResourceId = 6,
                ResourceName = "Van Jack"
            };
            TaskResources Record7 = new TaskResources()
            {
                ResourceId = 7,
                ResourceName = "Fuller Buchanan"
            };
            TaskResources Record8 = new TaskResources()
            {
                ResourceId = 8,
                ResourceName = "Jack Davolio"
            };
            TaskResources Record9 = new TaskResources()
            {
                ResourceId = 9,
                ResourceName = "Tamer Vinet"
            };
            TaskResources Record10 = new TaskResources()
            {
                ResourceId = 10,
                ResourceName = "Vinet Fuller"
            };
            TaskResources Record11 = new TaskResources()
            {
                ResourceId = 11,
                ResourceName = "Bergs Anton"
            };
            TaskResources Record12 = new TaskResources()
            {
                ResourceId = 12,
                ResourceName = "Construction Supervisor"
            };
            TaskResourcesCollection.Add(Record1);
            TaskResourcesCollection.Add(Record2);
            TaskResourcesCollection.Add(Record3);
            TaskResourcesCollection.Add(Record4);
            TaskResourcesCollection.Add(Record5);
            TaskResourcesCollection.Add(Record6);
            TaskResourcesCollection.Add(Record7);
            TaskResourcesCollection.Add(Record8);
            TaskResourcesCollection.Add(Record9);
            TaskResourcesCollection.Add(Record10);
            TaskResourcesCollection.Add(Record11);
            TaskResourcesCollection.Add(Record12);
            return TaskResourcesCollection;
        }
        public static List<TaskData> EditingData()
        {
            List<TaskData> TaskDataCollection = new List<TaskData>();

            TaskData Record1 = new TaskData()
            {
                TaskId = 1,
                TaskName = "Project initiation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record1Child1 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Identify Site location",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "0",
                Progress = 30,
                ResourceId = new int[] { 1 },
                Notes = "Measure the total property area alloted for construction"
            };
            TaskData Record1Child2 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "4",
                Predecessor = "2",
                ResourceId = new int[] { 2, 3, 5 },
                Notes = "Obtain an engineered soil test of lot where construction is planned.From an engineer or company specializing in soil testing"
            };
            TaskData Record1Child3 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2019, 04, 02),
                Duration = "0",
                Progress = 30,
                Predecessor = "3"
            };
            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);

            TaskData Record2 = new TaskData()
            {
                TaskId = 5,
                TaskName = "Project estimation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record2Child1 = new TaskData()
            {
                TaskId = 6,
                TaskName = "Develop floor plan for estimation",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "4",
                ResourceId = new int[] { 4 },
                Notes = "Develop floor plans and obtain a materials list for estimations"
            };
            TaskData Record2Child2 = new TaskData()
            {
                TaskId = 7,
                TaskName = "List materials",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "6",
                ResourceId = new int[] { 4, 8 },
                Notes = ""
            };
            TaskData Record2Child3 = new TaskData()
            {
                TaskId = 8,
                TaskName = "Estimation approval",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "0",
                Predecessor = "7",
                ResourceId = new int[] { 12, 5 },
                Notes = ""
            };
            Record2.SubTasks.Add(Record2Child1);
            Record2.SubTasks.Add(Record2Child2);
            Record2.SubTasks.Add(Record2Child3);

            TaskData Record3 = new TaskData()
            {
                TaskId = 9,
                TaskName = "Sign contract",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "1",
                Predecessor = "8",
                Progress = 30,
                ResourceId = new int[] { 12 },
                Notes = "If required obtain approval from HOA (homeowners association) or ARC (architectural review committee)"
            };

            TaskData Record4 = new TaskData()
            {
                TaskId = 10,
                TaskName = "Project approval and kick off",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                Duration = "0",
                Predecessor = "9",
            };

            TaskData Record5 = new TaskData()
            {
                TaskId = 11,
                TaskName = "Site work",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record5Child1 = new TaskData()
            {
                TaskId = 12,
                TaskName = "Clear the building site",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Progress = 30,
                Predecessor = "9",
                ResourceId = new int[] { 6, 7 },
                Notes = "Clear the building site (demolition of existing home if necessary)"
            };
            TaskData Record5Child2 = new TaskData()
            {
                TaskId = 13,
                TaskName = "Install temporary power service",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "12",
                ResourceId = new int[] { 6, 7 },
                Notes = ""
            };
            Record5.SubTasks.Add(Record5Child1);
            Record5.SubTasks.Add(Record5Child2);

            TaskData Record6 = new TaskData()
            {
                TaskId = 14,
                TaskName = "Foundation",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record6Child1 = new TaskData()
            {
                TaskId = 15,
                TaskName = "Excavate for foundations",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "13",
                ResourceId = new int[] { 2, 8 },
                Notes = "Excavate the foundation and dig footers (Scope of work is dependent of foundation designed by engineer)"
            };
            TaskData Record6Child2 = new TaskData()
            {
                TaskId = 16,
                TaskName = "Dig footer",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "15FF",
                ResourceId = new int[] { 8 },
                Notes = ""
            };
            TaskData Record6Child3 = new TaskData()
            {
                TaskId = 17,
                TaskName = "Install plumbing grounds",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Progress = 30,
                Predecessor = "15",
                ResourceId = new int[] { 9 },
                Notes = ""
            };
            TaskData Record6Child4 = new TaskData()
            {
                TaskId = 18,
                TaskName = "Pour a foundation and footer with concrete",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "1",
                Predecessor = "17",
                ResourceId = new int[] { 8, 9, 10 },
                Notes = ""
            };
            TaskData Record6Child5 = new TaskData()
            {
                TaskId = 19,
                TaskName = "Cure basement walls",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "4",
                Progress = 30,
                Predecessor = "18",
                ResourceId = new int[] { 10 },
                Notes = ""
            };
            Record6.SubTasks.Add(Record6Child1);
            Record6.SubTasks.Add(Record6Child2);
            Record6.SubTasks.Add(Record6Child3);
            Record6.SubTasks.Add(Record6Child4);
            Record6.SubTasks.Add(Record6Child5);


            TaskData Record7 = new TaskData()
            {
                TaskId = 20,
                TaskName = "Framing",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record7Child1 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Add load-bearing structure",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "19",
                ResourceId = new int[] { 4, 5 },
                Notes = "Build the main load-bearing structure out of thick pieces of wood and possibly metal I-beams for large spans with few supports"
            };
            TaskData Record7Child2 = new TaskData()
            {
                TaskId = 22,
                TaskName = "Install floor joists",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "21",
                ResourceId = new int[] { 2, 3 },
                Notes = "Add floor and ceiling joists and install subfloor panels"
            };
            TaskData Record7Child3 = new TaskData()
            {
                TaskId = 23,
                TaskName = "Add ceiling joists",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "22SS",
                ResourceId = new int[] { 5 },
                Notes = ""
            };
            TaskData Record7Child4 = new TaskData()
            {
                TaskId = 24,
                TaskName = "Install subfloor panels",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "23",
                ResourceId = new int[] { 8, 9 },
                Notes = ""
            };
            TaskData Record7Child5 = new TaskData()
            {
                TaskId = 25,
                TaskName = "Frame floor walls",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "24",
                ResourceId = new int[] { 10 },
                Notes = ""
            };
            TaskData Record7Child6 = new TaskData()
            {
                TaskId = 26,
                TaskName = "Frame floor decking",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "25SS",
                ResourceId = new int[] { 4, 8 },
                Notes = ""
            };
            Record7.SubTasks.Add(Record7Child1);
            Record7.SubTasks.Add(Record7Child2);
            Record7.SubTasks.Add(Record7Child3);
            Record7.SubTasks.Add(Record7Child4);
            Record7.SubTasks.Add(Record7Child5);
            Record7.SubTasks.Add(Record7Child6);

            TaskData Record8 = new TaskData()
            {
                TaskId = 27,
                TaskName = "Exterior finishing",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record8Child1 = new TaskData()
            {
                TaskId = 28,
                TaskName = "Cover outer walls and roof in OSB",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "26",
                ResourceId = new int[] { 2, 8 },
                Notes = "Cover outer walls and roof in OSB or plywood and a water-resistive barrier"
            };
            TaskData Record8Child2 = new TaskData()
            {
                TaskId = 29,
                TaskName = "Add water resistive barrier",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "28",
                ResourceId = new int[] { 1, 10 },
                Notes = "Cover the walls with siding, typically vinyl, wood, or brick veneer but possibly stone or other materials"
            };
            TaskData Record8Child3 = new TaskData()
            {
                TaskId = 30,
                TaskName = "Install roof shingles",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "29",
                ResourceId = new int[] { 8, 9 },
                Notes = "Install roof shingles or other covering for flat roof"
            };
            TaskData Record8Child4 = new TaskData()
            {
                TaskId = 31,
                TaskName = "Install windows",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "29",
                ResourceId = new int[] { 7 },
                Notes = ""
            };
            Record8.SubTasks.Add(Record8Child1);
            Record8.SubTasks.Add(Record8Child2);
            Record8.SubTasks.Add(Record8Child3);
            Record8.SubTasks.Add(Record8Child4);

            TaskData Record9 = new TaskData()
            {
                TaskId = 32,
                TaskName = "Utilities",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record9Child1 = new TaskData()
            {
                TaskId = 33,
                TaskName = "Install internal plumbing",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "26",
                ResourceId = new int[] { 1, 10 },
            };
            TaskData Record9Child2 = new TaskData()
            {
                TaskId = 34,
                TaskName = "Install HVAC",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "33",
                ResourceId = new int[] { 4, 9 },
                Notes = "Add internal plumbing, HVAC, electrical, and natural gas utilities"
            };
            TaskData Record9Child3 = new TaskData()
            {
                TaskId = 35,
                TaskName = "Electrical utilities",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "34",
            };
            TaskData Record9Child4 = new TaskData()
            {
                TaskId = 36,
                TaskName = "Natural gas utilities",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "35",
                ResourceId = new int[] { 11 },
            };
            TaskData Record9Child5 = new TaskData()
            {
                TaskId = 37,
                TaskName = "Install bathroom fixtures",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "35",
                ResourceId = new int[] { 3, 7 },
            };
            Record9.SubTasks.Add(Record9Child1);
            Record9.SubTasks.Add(Record9Child2);
            Record9.SubTasks.Add(Record9Child3);
            Record9.SubTasks.Add(Record9Child4);
            Record9.SubTasks.Add(Record9Child5);

            TaskData Record10 = new TaskData()
            {
                TaskId = 38,
                TaskName = "Interior finsihing",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record10Child1 = new TaskData()
            {
                TaskId = 39,
                TaskName = "Install insulation",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "37",
                ResourceId = new int[] { 1, 8 },
                Notes = "Frame interior walls with wooden 2×4s"
            };
            TaskData Record10Child2 = new TaskData()
            {
                TaskId = 40,
                TaskName = "Install  drywall panels",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "39",
                ResourceId = new int[] { 5 },
                Notes = "Install insulation and interior drywall panels (cementboard for wet areas) and to complete walls and ceilings"
            };
            TaskData Record10Child3 = new TaskData()
            {
                TaskId = 41,
                TaskName = "Spackle",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "40",
                ResourceId = new int[] { 10 },
            };
            TaskData Record10Child4 = new TaskData()
            {
                TaskId = 42,
                TaskName = "Apply primer",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "41",
                ResourceId = new int[] { 10, 11 },
            };
            TaskData Record10Child5 = new TaskData()
            {
                TaskId = 43,
                TaskName = "Paint wall and ceilings",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "42",
                ResourceId = new int[] { 2, 9 },
            };
            TaskData Record10Child6 = new TaskData()
            {
                TaskId = 44,
                TaskName = "Install modular kitchen",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "43",
                ResourceId = new int[] { 5, 7 },
            };
            Record10.SubTasks.Add(Record10Child1);
            Record10.SubTasks.Add(Record10Child2);
            Record10.SubTasks.Add(Record10Child3);
            Record10.SubTasks.Add(Record10Child4);
            Record10.SubTasks.Add(Record10Child5);
            Record10.SubTasks.Add(Record10Child6);


            TaskData Record11 = new TaskData()
            {
                TaskId = 45,
                TaskName = "Flooring",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record11Child1 = new TaskData()
            {
                TaskId = 46,
                TaskName = "Tile kitchen, bathroom and entry walls",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Progress = 30,
                Predecessor = "44",
                ResourceId = new int[] { 4, 9, 3 },
                Notes = "Additional tiling on top of cementboard for wet areas, such as the bathroom and kitchen backsplash"
            };
            TaskData Record11Child2 = new TaskData()
            {
                TaskId = 47,
                TaskName = "Tile floor",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "3",
                Predecessor = "46SS",
                ResourceId = new int[] { 2, 8 },
                Notes = "Installation of final floor covering, such as floor tile, carpet, or wood flooring"
            };
            Record11.SubTasks.Add(Record11Child1);
            Record11.SubTasks.Add(Record11Child2);

            TaskData Record12 = new TaskData()
            {
                TaskId = 48,
                TaskName = "Final acceptance",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record12Child1 = new TaskData()
            {
                TaskId = 49,
                TaskName = "Final inspection",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Progress = 30,
                Predecessor = "47",
                ResourceId = new int[] { 12 },
                Notes = "Ensure the contracted items"
            };
            TaskData Record12Child2 = new TaskData()
            {
                TaskId = 50,
                TaskName = "Cleanup for occupancy",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "2",
                Predecessor = "49",
                ResourceId = new int[] { 1, 5 },
                Notes = "Installation of major appliances"
            };
            TaskData Record12Child3 = new TaskData()
            {
                TaskId = 51,
                TaskName = "Property handover",
                StartDate = new DateTime(2019, 04, 04),
                Duration = "0",
                Predecessor = "50",
                Notes = "Ending the contract"
            };
            Record12.SubTasks.Add(Record12Child1);
            Record12.SubTasks.Add(Record12Child2);
            Record12.SubTasks.Add(Record12Child3);

            TaskDataCollection.Add(Record1);
            TaskDataCollection.Add(Record2);
            TaskDataCollection.Add(Record3);
            TaskDataCollection.Add(Record4);
            TaskDataCollection.Add(Record5);
            TaskDataCollection.Add(Record6);
            TaskDataCollection.Add(Record7);
            TaskDataCollection.Add(Record8);
            TaskDataCollection.Add(Record9);
            TaskDataCollection.Add(Record10);
            TaskDataCollection.Add(Record11);
            TaskDataCollection.Add(Record12);
            return TaskDataCollection;
        }
    }
}
