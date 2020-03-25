using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace ej2_blazor_filterdata
{
    public class FilterData
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
      
        public static List<TaskData> FilteredData()
        {
            List<TaskData> TaskDataCollection = new List<TaskData>();
            TaskData Record1 = new TaskData()
            {
                TaskId = 1,
                TaskName = "Launch and flight to lunar orbit",
                StartDate = new DateTime(1969, 07, 16),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record1Child1 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Apollo 11 blasts off from launch pad",
                StartDate = new DateTime(1969, 07, 16, 3, 32, 0),
                EndDate = new DateTime(1969, 07, 16, 3, 32, 0),
                Duration = "0"
            };
            TaskData Record1Child2 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Entry to Earth’s orbit",
                StartDate = new DateTime(1969, 07, 16, 3, 32, 0),
                EndDate = new DateTime(1969, 07, 16, 3, 44, 0),
                Predecessor = "2"
            };
            TaskData Record1Child3 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Travelling in earth’s orbit",
                StartDate = new DateTime(1969, 07, 16, 3, 44, 0),
                EndDate = new DateTime(1969, 07, 16, 4, 22, 13),
                Predecessor = "3"
            };
            TaskData Record1Child4 = new TaskData()
            {
                TaskId = 5,
                TaskName = "Trajectory change toward the Moon",
                StartDate = new DateTime(1969, 07, 16, 4, 22, 13),
                EndDate = new DateTime(1969, 07, 16, 4, 52, 0),
                Predecessor = "4"
            };
            TaskData Record1Child5 = new TaskData()
            {
                TaskId = 6,
                TaskName = "extraction maneuver performed",
                StartDate = new DateTime(1969, 07, 16, 4, 52, 0),
                EndDate = new DateTime(1969, 07, 16, 4, 52, 0),
                Predecessor = "5"
            };
            TaskData Record1Child6 = new TaskData()
            {
                TaskId = 7,
                TaskName = "Travelling toward moon and entering into lunar orbit",
                StartDate = new DateTime(1969, 07, 16, 4, 52, 0),
                EndDate = new DateTime(1969, 07, 16, 16, 21, 50),
                Predecessor = "6"
            };
            TaskData Record1Child7 = new TaskData()
            {
                TaskId = 8,
                TaskName = "Midcourse correction, sharpening the course and testing the engine",
                StartDate = new DateTime(1969, 07, 16, 23, 22, 0),
                EndDate = new DateTime(1969, 07, 17, 5, 21, 50)
            };
            TaskData Record1Child8 = new TaskData()
            {
                TaskId = 9,
                TaskName = "Reached half the distance spanning between earth and moon",
                StartDate = new DateTime(1969, 07, 17, 5, 22, 0),
                EndDate = new DateTime(1969, 07, 17, 08, 0, 50)
            };
            TaskData Record1Child9 = new TaskData()
            {
                TaskId = 10,
                TaskName = "Reached 3/4th distance spanning between earth and moon",
                StartDate = new DateTime(1969, 07, 17, 20, 02, 0),
                EndDate = new DateTime(1969, 07, 18, 16, 21, 50)
            };
            TaskData Record1Child10 = new TaskData()
            {
                TaskId = 11,
                TaskName = "Reached distance 45000 miles from moon",
                StartDate = new DateTime(1969, 07, 18, 23, 20, 0),
                EndDate = new DateTime(1969, 07, 19, 17, 21, 0)
            };

            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);
            Record1.SubTasks.Add(Record1Child4);
            Record1.SubTasks.Add(Record1Child5);
            Record1.SubTasks.Add(Record1Child6);
            Record1.SubTasks.Add(Record1Child7);
            Record1.SubTasks.Add(Record1Child8);
            Record1.SubTasks.Add(Record1Child9);
            Record1.SubTasks.Add(Record1Child10);
            Record1.SubTasks.Add(Record1Child1);

            TaskData Record2 = new TaskData()
            {
                TaskId = 12,
                TaskName = "Lunar descent",
                StartDate = new DateTime(1969, 07, 19, 17, 21, 50),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record2Child1 = new TaskData()
            {
                TaskId = 13,
                TaskName = "Lunar Orbiting (30 orbits)",
                StartDate = new DateTime(1969, 07, 19, 17, 21, 50),
                EndDate = new DateTime(1969, 07, 20, 12, 52, 0),
                Predecessor = "11"
            };
            TaskData Record2Child2 = new TaskData()
            {
                TaskId = 14,
                TaskName = "Landing site identified",
                StartDate = new DateTime(1969, 07, 20, 12, 52, 0),
                EndDate = new DateTime(1969, 07, 20, 12, 52, 0),
                Predecessor = "13"
            };
            TaskData Record2Child3 = new TaskData()
            {
                TaskId = 15,
                TaskName = "Eagle separated from Columbia",
                StartDate = new DateTime(1969, 07, 20, 17, 44, 0),
                EndDate = new DateTime(1969, 07, 20, 17, 44, 0)
            };
            TaskData Record2Child4 = new TaskData()
            {
                TaskId = 16,
                TaskName = "Eagle’s decent to Moon",
                StartDate = new DateTime(1969, 07, 20, 17, 44, 0),
                EndDate = new DateTime(1969, 07, 20, 20, 16, 40)
            };

            Record2.SubTasks.Add(Record2Child1);
            Record2.SubTasks.Add(Record2Child2);
            Record2.SubTasks.Add(Record2Child3);
            Record2.SubTasks.Add(Record2Child4);

            TaskData Record3 = new TaskData()
            {
                TaskId = 17,
                TaskName = "Landing",
                StartDate = new DateTime(1969, 07, 20, 20, 17, 40),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record3Child1 = new TaskData()
            {
                TaskId = 18,
                TaskName = "Eagle’s touch down",
                StartDate = new DateTime(1969, 07, 20, 20, 17, 40),
                EndDate = new DateTime(1969, 07, 20, 20, 17, 40)
            };
            TaskData Record3Child2 = new TaskData()
            {
                TaskId = 19,
                TaskName = "Radio communication and Performing post landing checklist",
                StartDate = new DateTime(1969, 07, 20, 20, 17, 40),
                EndDate = new DateTime(1969, 07, 20, 23, 43, 0)
            };
            TaskData Record3Child3 = new TaskData()
            {
                TaskId = 20,
                TaskName = "Preparations for EVA (Extra Vehicular Activity)",
                StartDate = new DateTime(1969, 07, 20, 23, 43, 0),
                EndDate = new DateTime(1969, 07, 21, 2, 39, 33)
            };
            TaskData Record3Child4 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Hatch open and climbing down the moon",
                StartDate = new DateTime(1969, 07, 21, 2, 39, 33),
                EndDate = new DateTime(1969, 07, 21, 2, 56, 15)
            };
            TaskData Record3Child5 = new TaskData()
            {
                TaskId = 22,
                TaskName = "Armstrong stepped down on the moon",
                StartDate = new DateTime(1969, 07, 21, 2, 56, 15),
                EndDate = new DateTime(1969, 07, 21, 3, 11, 0)
            };
            Record3.SubTasks.Add(Record3Child1);
            Record3.SubTasks.Add(Record3Child2);
            Record3.SubTasks.Add(Record3Child3);
            Record3.SubTasks.Add(Record3Child4);
            Record3.SubTasks.Add(Record3Child5);

            TaskData Record4 = new TaskData()
            {
                TaskId = 23,
                TaskName = "Lunar surface operations",
                StartDate = new DateTime(1969, 07, 21, 2, 56, 15),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record4Child1 = new TaskData()
            {
                TaskId = 24,
                TaskName = "Soil sample collections",
                StartDate = new DateTime(1969, 07, 21, 2, 56, 15),
                EndDate = new DateTime(1969, 07, 21, 3, 11, 0)
            };
            TaskData Record4Child2 = new TaskData()
            {
                TaskId = 25,
                TaskName = "Aldrin joined Armstrong",
                StartDate = new DateTime(1969, 07, 21, 3, 11, 0),
                EndDate = new DateTime(1969, 07, 21, 3, 41, 0)
            };
            TaskData Record4Child3 = new TaskData()
            {
                TaskId = 26,
                TaskName = "planted the lunar flag assembly",
                StartDate = new DateTime(1969, 07, 21, 3, 41, 0),
                EndDate = new DateTime(1969, 07, 21, 3, 46, 0)
            };
            TaskData Record4Child4 = new TaskData()
            {
                TaskId = 27,
                TaskName = "President Richard Nixon’s telephone-radio transmission",
                StartDate = new DateTime(1969, 07, 21, 3, 48, 0),
                EndDate = new DateTime(1969, 07, 21, 3, 51, 0)
            };
            TaskData Record4Child5 = new TaskData()
            {
                TaskId = 28,
                TaskName = "Collect rock samples, photos and other mission controls",
                StartDate = new DateTime(1969, 07, 21, 3, 52, 0),
                EndDate = new DateTime(1969, 07, 21, 4, 50, 0)
            };
            Record4.SubTasks.Add(Record4Child1);
            Record4.SubTasks.Add(Record4Child2);
            Record4.SubTasks.Add(Record4Child3);
            Record4.SubTasks.Add(Record4Child4);
            Record4.SubTasks.Add(Record4Child5);
            TaskData Record5 = new TaskData()
            {
                TaskId = 29,
                TaskName = "Lunar ascent",
                StartDate = new DateTime(1969, 07, 21, 4, 51, 0),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record5Child1 = new TaskData()
            {
                TaskId = 30,
                TaskName = "Climbing the eagle to ascent",
                StartDate = new DateTime(1969, 07, 21, 4, 51, 0),
                EndDate = new DateTime(1969, 07, 21, 5, 0, 0)
            };
            TaskData Record5Child2 = new TaskData()
            {
                TaskId = 31,
                TaskName = "Hatch closing",
                StartDate = new DateTime(1969, 07, 21, 5, 1, 0),
                EndDate = new DateTime(1969, 07, 21, 5, 1, 0)
            };
            TaskData Record5Child3 = new TaskData()
            {
                TaskId = 32,
                TaskName = "Final housekeeping",
                StartDate = new DateTime(1969, 07, 21, 5, 2, 0),
                EndDate = new DateTime(1969, 07, 21, 8, 0, 0)
            };
            TaskData Record5Child4 = new TaskData()
            {
                TaskId = 33,
                TaskName = "Resting of astronauts",
                StartDate = new DateTime(1969, 07, 21, 8, 0, 0),
                EndDate = new DateTime(1969, 07, 21, 15, 0, 0)
            };
            TaskData Record5Child5 = new TaskData()
            {
                TaskId = 34,
                TaskName = "Preparation for lift off and Ascent engine started",
                StartDate = new DateTime(1969, 07, 21, 15, 0, 0),
                EndDate = new DateTime(1969, 07, 21, 17, 54, 0)
            };
            TaskData Record5Child6 = new TaskData()
            {
                TaskId = 35,
                TaskName = "Eagle lifted off",
                StartDate = new DateTime(1969, 07, 21, 17, 54, 0),
                EndDate = new DateTime(1969, 07, 21, 21, 23, 0)
            };
            TaskData Record5Child7 = new TaskData()
            {
                TaskId = 36,
                TaskName = "Eagle’s travel toward Columbia",
                StartDate = new DateTime(1969, 07, 21, 21, 24, 0),
                EndDate = new DateTime(1969, 07, 21, 21, 35, 0)
            };
            Record5.SubTasks.Add(Record5Child1);
            Record5.SubTasks.Add(Record5Child2);
            Record5.SubTasks.Add(Record5Child3);
            Record5.SubTasks.Add(Record5Child4);
            Record5.SubTasks.Add(Record5Child5);
            Record5.SubTasks.Add(Record5Child6);
            Record5.SubTasks.Add(Record5Child7);

            TaskData Record6 = new TaskData()
            {
                TaskId = 37,
                TaskName = "Return",
                StartDate = new DateTime(1969, 07, 21, 21, 24, 0),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record6Child1 = new TaskData()
            {
                TaskId = 38,
                TaskName = "Eagle docked with Columbia",
                StartDate = new DateTime(1969, 07, 16, 21, 24, 0),
                EndDate = new DateTime(1969, 07, 16, 21, 35, 0)
            };
            TaskData Record6Child2 = new TaskData()
            {
                TaskId = 39,
                TaskName = "Eagle’s ascent stage jettisoned into lunar orbit",
                StartDate = new DateTime(1969, 07, 21, 21, 35, 0),
                EndDate = new DateTime(1969, 07, 21, 23, 41, 0)
            };
            Record6.SubTasks.Add(Record6Child1);
            Record6.SubTasks.Add(Record6Child2);
            TaskData Record7 = new TaskData()
            {
                TaskId = 40,
                TaskName = "Decent toward earth  and Splashdown",
                StartDate = new DateTime(1969, 07, 21),
                SubTasks = new List<TaskData>(),
            };
            TaskData Record7Child1 = new TaskData()
            {
                TaskId = 41,
                TaskName = "Spacecraft reaches 1/4th distance spanning between moon and earth",
                StartDate = new DateTime(1969, 07, 21, 23, 50, 0),
                EndDate = new DateTime(1969, 07, 22, 16, 40, 0)
            };
            TaskData Record7Child2 = new TaskData()
            {
                TaskId = 42,
                TaskName = "Spacecraft travels to midway point of journey",
                StartDate = new DateTime(1969, 07, 22, 16, 0, 0),
                EndDate = new DateTime(1969, 07, 23, 16, 0, 0)
            };
            TaskData Record7Child3 = new TaskData()
            {
                TaskId = 43,
                TaskName = "Spacecraft travels to 3/4th point of journey",
                StartDate = new DateTime(1969, 07, 23, 16, 40, 0),
                EndDate = new DateTime(1969, 07, 24, 10, 0, 0)
            };
            TaskData Record7Child4 = new TaskData()
            {
                TaskId = 44,
                TaskName = "Crew prepares for splashdown",
                StartDate = new DateTime(1969, 07, 24, 11, 47, 0),
                EndDate = new DateTime(1969, 07, 24, 16, 20, 0)
            };
            TaskData Record7Child5 = new TaskData()
            {
                TaskId = 45,
                TaskName = "Command and service modules separates",
                StartDate = new DateTime(1969, 07, 24, 16, 20, 0),
                EndDate = new DateTime(1969, 07, 24, 16, 35, 0)
            };
            TaskData Record7Child6 = new TaskData()
            {
                TaskId = 46,
                TaskName = "Command module re-enters the Earth’s atmosphere",
                StartDate = new DateTime(1969, 07, 24, 16, 35, 0),
                EndDate = new DateTime(1969, 07, 24, 16, 50, 0)
            };
            TaskData Record7Child7 = new TaskData()
            {
                TaskId = 47,
                TaskName = "Spacecraft splashes near USS hornet",
                StartDate = new DateTime(1969, 07, 24, 16, 51, 0),
                EndDate = new DateTime(1969, 07, 24, 16, 51, 0)
            };

            Record7.SubTasks.Add(Record7Child1);
            Record7.SubTasks.Add(Record7Child2);
            Record7.SubTasks.Add(Record7Child3);
            Record7.SubTasks.Add(Record7Child4);
            Record7.SubTasks.Add(Record7Child5);
            Record7.SubTasks.Add(Record7Child6);
            Record7.SubTasks.Add(Record7Child7);

            TaskDataCollection.Add(Record1);
            TaskDataCollection.Add(Record2);
            TaskDataCollection.Add(Record3);
            TaskDataCollection.Add(Record4);
            TaskDataCollection.Add(Record5);
            TaskDataCollection.Add(Record6);
            TaskDataCollection.Add(Record7);
            return TaskDataCollection;
        }
    }
}
