using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace ej2_blazor_basedata
{
    public class BaseData
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
     
        
        public static List<TaskData> BaselineData()
        {
            List<TaskData> TaskDataCollection = new List<TaskData>();

            TaskData Record1 = new TaskData()
            {
                TaskId = 1,
                TaskName = "Receive vehicle and create job card",
                BaselineStartDate = new DateTime(2018, 03, 05, 10, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 10, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 10, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 10, 0, 0),
            };
            TaskData Record2 = new TaskData()
            {
                TaskId = 2,
                TaskName = "Allot mechanic and send vehicle to service bay",
                BaselineStartDate = new DateTime(2018, 03, 05, 10, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 10, 15, 0),
                StartDate = new DateTime(2018, 03, 05, 10, 15, 0),
                EndDate = new DateTime(2018, 03, 05, 10, 20, 0),
            };
            TaskData Record3 = new TaskData()
            {
                TaskId = 3,
                TaskName = "Change the receive vehicle and create job cardengine oil",
                BaselineStartDate = new DateTime(2018, 03, 05, 10, 15, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 10, 45, 0),
                StartDate = new DateTime(2018, 03, 05, 10, 20, 0),
                EndDate = new DateTime(2018, 03, 05, 10, 35, 0),
            };
            TaskData Record4 = new TaskData()
            {
                TaskId = 4,
                TaskName = "Replace the oil filter",
                BaselineStartDate = new DateTime(2018, 03, 05, 10, 45, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 15, 0),
                StartDate = new DateTime(2018, 03, 05, 10, 35, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 0, 0),
            };
            TaskData Record5 = new TaskData()
            {
                TaskId = 5,
                TaskName = "Replace the air filter",
                BaselineStartDate = new DateTime(2018, 03, 05, 10, 45, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 15, 0),
                StartDate = new DateTime(2018, 03, 05, 10, 35, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 0, 0),
            };
            TaskData Record6 = new TaskData()
            {
                TaskId = 6,
                TaskName = "Replace the fuel filter",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 15, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 25, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 20, 0),
            };
            TaskData Record7 = new TaskData()
            {
                TaskId = 7,
                TaskName = "Replace the cabin filter",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 30, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 25, 0),
            };
            TaskData Record8 = new TaskData()
            {
                TaskId = 8,
                TaskName = "Replace the spark plugs",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 30, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 25, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 45, 0),
            };
            TaskData Record9 = new TaskData()
            {
                TaskId = 9,
                TaskName = "Check level and refill brake fluid/clutch fluid",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 20, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 11, 40, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 11, 50, 0),
            };
            TaskData Record10 = new TaskData()
            {
                TaskId = 10,
                TaskName = "Check brake pads/liners, brake discs/drums, and replace if worn out",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 40, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 12, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 50, 0),
                EndDate = new DateTime(2018, 03, 05, 12, 20, 0),
            };
            TaskData Record11 = new TaskData()
            {
                TaskId = 11,
                TaskName = "Check level and refill power steering fluid",
                BaselineStartDate = new DateTime(2018, 03, 05, 11, 40, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 12, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 12, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 12, 15, 0),
            };
            TaskData Record12 = new TaskData()
            {
                TaskId = 12,
                TaskName = "Check level and refill automatic/manual transmission fluid",
                BaselineStartDate = new DateTime(2018, 03, 05, 12, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 12, 35, 0),
                StartDate = new DateTime(2018, 03, 05, 11, 50, 0),
                EndDate = new DateTime(2018, 03, 05, 12, 20, 0),
            };
            TaskData Record13 = new TaskData()
            {
                TaskId = 13,
                TaskName = "Grease and lubricate components",
                BaselineStartDate = new DateTime(2018, 03, 05, 12, 20, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 12, 35, 0),
                StartDate = new DateTime(2018, 03, 05, 12, 20, 0),
                EndDate = new DateTime(2018, 03, 05, 12, 45, 0),
            };
            TaskData Record14 = new TaskData()
            {
                TaskId = 14,
                TaskName = "Inspect and replace the timing belt or timing chain if needed",
                BaselineStartDate = new DateTime(2018, 03, 05, 12, 35, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 13, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 12, 45, 0),
                EndDate = new DateTime(2018, 03, 05, 13, 0, 0),
            };
            TaskData Record15 = new TaskData()
            {
                TaskId = 15,
                TaskName = "Wheel balancing",
                BaselineStartDate = new DateTime(2018, 03, 05, 13, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 13, 20, 0),
                StartDate = new DateTime(2018, 03, 05, 13, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 13, 45, 0),
            };
            TaskData Record16 = new TaskData()
            {
                TaskId = 16,
                TaskName = "Wheel alignment",
                BaselineStartDate = new DateTime(2018, 03, 05, 13, 20, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 13, 45, 0),
                StartDate = new DateTime(2018, 03, 05, 13, 45, 0),
                EndDate = new DateTime(2018, 03, 05, 14, 45, 0),
            };
            TaskData Record17 = new TaskData()
            {
                TaskId = 17,
                TaskName = "Check for proper operation of all lights, wipers etc",
                BaselineStartDate = new DateTime(2018, 03, 05, 13, 50, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 14, 30, 0),
                StartDate = new DateTime(2018, 03, 05, 14, 45, 0),
                EndDate = new DateTime(2018, 03, 05, 15, 30, 0),
            };
            TaskData Record18 = new TaskData()
            {
                TaskId = 18,
                TaskName = "Check for any error codes in the ECU and take corrective action",
                BaselineStartDate = new DateTime(2018, 03, 05, 14, 30, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 15, 30, 0),
                StartDate = new DateTime(2018, 03, 05, 15, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 16, 15, 0),
            };
            TaskData Record19 = new TaskData()
            {
                TaskId = 19,
                TaskName = "Use scan tool read trouble code",
                BaselineStartDate = new DateTime(2018, 03, 05, 15, 30, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 16, 45, 0),
                StartDate = new DateTime(2018, 03, 05, 16, 15, 0),
                EndDate = new DateTime(2018, 03, 05, 16, 45, 0),
            };
            TaskData Record20 = new TaskData()
            {
                TaskId = 20,
                TaskName = "Exterior washing",
                BaselineStartDate = new DateTime(2018, 03, 05, 16, 45, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 17, 15, 0),
                StartDate = new DateTime(2018, 03, 05, 16, 45, 0),
                EndDate = new DateTime(2018, 03, 05, 17, 30, 0),
            };
            TaskData Record21 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Interior vacuuming",
                BaselineStartDate = new DateTime(2018, 03, 05, 17, 15, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 17, 45, 0),
                StartDate = new DateTime(2018, 03, 05, 17, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 0, 0),
            };
            TaskData Record22 = new TaskData()
            {
                TaskId = 21,
                TaskName = "Final service inspection",
                BaselineStartDate = new DateTime(2018, 03, 05, 17, 45, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 18, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 18, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 30, 0),
            };
            TaskData Record23 = new TaskData()
            {
                TaskId = 23,
                TaskName = "Vehicle handover",
                BaselineStartDate = new DateTime(2018, 03, 05, 18, 0, 0),
                BaselineEndDate = new DateTime(2018, 03, 05, 18, 0, 0),
                StartDate = new DateTime(2018, 03, 05, 18, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 30, 0),
            };
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
            TaskDataCollection.Add(Record13);
            TaskDataCollection.Add(Record14);
            TaskDataCollection.Add(Record15);
            TaskDataCollection.Add(Record16);
            TaskDataCollection.Add(Record17);
            TaskDataCollection.Add(Record18);
            TaskDataCollection.Add(Record19);
            TaskDataCollection.Add(Record20);
            TaskDataCollection.Add(Record21);
            TaskDataCollection.Add(Record22);
            TaskDataCollection.Add(Record23);
            return TaskDataCollection;
        }
      
    }
}
