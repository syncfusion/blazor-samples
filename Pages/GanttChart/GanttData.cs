using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
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
            public string Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }

            public string Notes { get; set; }
            public int? ParentId { get; set; }
        }
        public static List<TaskData> EditingData()
        {
            List<TaskData> Tasks = new List<TaskData>() {

        new TaskData() {
            TaskId = 1,
            TaskName = "Product concept ",
            StartDate = new DateTime(2019, 04, 02),
            EndDate = new DateTime(2019, 04, 08),
            Duration = "5days"
        },
        new TaskData() {
            TaskId = 2,
            TaskName = "Defining the product usage",
            StartDate = new DateTime(2019, 04, 02),
            EndDate = new DateTime(2019, 04, 08),

            Duration = "3",
            Progress = 30,
            ParentId = 1,



        },
        new TaskData() {
            TaskId = 3,
            TaskName = "Defining the Target audience",
            StartDate = new DateTime(2019, 04, 02),
            EndDate = new DateTime(2019, 04, 04),
            Duration = "3",
            Progress = 40,
            ParentId = 1
        },
        new TaskData() {
            TaskId = 4,
            TaskName = "Prepare product sketch and notes",
            StartDate = new DateTime(2019, 04, 05),
            EndDate = new DateTime(2019, 04, 08),
            Duration = "2",
            Progress = 30,
            ParentId = 1,
            Predecessor="2"

        },
        new TaskData() {
            TaskId = 5,
            TaskName = "Concept approval",
            StartDate = new DateTime(2019, 04, 08),
            EndDate = new DateTime(2019, 04, 08),
            Duration="0",
            Predecessor="3,4",



        },
        new TaskData() {
            TaskId = 6,
            TaskName = "Market Research",
            StartDate = new DateTime(2019, 04, 09),
            EndDate = new DateTime(2019, 04, 18),

            Duration = "4",
            Progress = 30,

        },
        new TaskData() {
            TaskId = 7,
            TaskName = "Demand Analysis",
            StartDate = new DateTime(2019, 04, 09),
            EndDate = new DateTime(2019, 04, 12),
            Duration = "4",
            Progress = 40,
            ParentId = 6
        },
        new TaskData() {
            TaskId = 8,
            TaskName = "Customer Strength",
            StartDate = new DateTime(2019, 04, 09),
            EndDate = new DateTime(2019, 04, 12),
            Duration = "4",
            Progress = 30,
            ParentId = 7,
            Predecessor="5"

        }, new TaskData() {
            TaskId = 9,
            TaskName = "Market Opportunity analysis",
            StartDate = new DateTime(2019, 04, 09),
            EndDate = new DateTime(2019, 04, 012),
            Duration="4",
            ParentId= 7,
            Predecessor="5"

        },
        new TaskData() {
            TaskId = 10,
            TaskName = "Competitor analysis",
            StartDate = new DateTime(2019, 04, 15),
            EndDate = new DateTime(2019, 04, 18),

            Duration = "4",
            Progress = 30,
            ParentId= 6,
            Predecessor="7,8"

        },
        new TaskData() {
            TaskId = 11,
            TaskName = "Product Strength Analysis",
            StartDate = new DateTime(2019, 04, 15),
            EndDate = new DateTime(2019, 04, 18),
            Duration = "4",
            Progress = 40,
            ParentId = 6,
            Predecessor="9"
        },
        new TaskData() {
            TaskId = 12,
            TaskName = "Research Completed",
            StartDate = new DateTime(2019, 04, 18),
            EndDate = new DateTime(2019, 04, 18),
            Duration = "0",
            Progress = 30,
            ParentId = 6,
            Predecessor="10",



        },
         new TaskData() {
            TaskId = 13,
            TaskName = "Product design and developement",
            StartDate = new DateTime(2019, 04, 19),
            EndDate = new DateTime(2019, 05, 16),
            Duration="20",


        },
        new TaskData() {
            TaskId = 14,
            TaskName = "Functionality Design",
            StartDate = new DateTime(2019, 04, 19),
            EndDate = new DateTime(2019, 04, 23),

            Duration = "3",
            Progress = 30,
            ParentId = 13,
            Predecessor="12"
        },
        new TaskData() {
            TaskId = 15,
            TaskName = "Quality Design",
            StartDate = new DateTime(2019, 04, 19),
            EndDate = new DateTime(2019, 04, 23),
            Duration = "3",
            Progress = 40,
            ParentId = 13,
            Predecessor="12"
        },
        new TaskData() {
            TaskId = 16,
            TaskName = "Define reliability",
            StartDate = new DateTime(2019, 04, 24),
            EndDate = new DateTime(2019, 04, 25),
            Duration = "2",
            Progress = 30,
            ParentId = 13,
            Predecessor="15"
        },
         new TaskData() {
            TaskId = 17,
            TaskName = "Identifying raw mayerials",
            StartDate = new DateTime(2019, 04, 24),
            EndDate = new DateTime(2019, 04, 25),
            Duration="2",
            ParentId=13,
            Predecessor="15"


        },
        new TaskData() {
            TaskId = 18,
            TaskName = "Define cost plan",
            StartDate = new DateTime(2019, 04, 26),
            EndDate = new DateTime(2019, 04, 29),

            Duration = "2",
            Progress = 30,
            ParentId=13,
            Predecessor="17"

        },
        new TaskData() {
            TaskId = 19,
            TaskName = "Manufacturing cost",
            StartDate = new DateTime(2019, 04, 26),
            EndDate = new DateTime(2019, 04, 29),
            Duration = "2",
            Progress = 40,
            ParentId = 18,
            Predecessor="17"
        },
        new TaskData() {
            TaskId = 20,
            TaskName = "Selling cost",
            StartDate = new DateTime(2019, 04, 26),
            EndDate = new DateTime(2019, 04, 29),
            Duration = "2",
            Progress = 30,
            ParentId = 18,
            Predecessor="17"
        },
         new TaskData() {
            TaskId = 21,
            TaskName = "Developement of final design",
            StartDate = new DateTime(2019, 04, 30),
            EndDate = new DateTime(2019, 05, 08),
            Duration="7",
            ParentId=13

        },
        new TaskData() {
            TaskId = 22,
            TaskName = "Develope dimensions and design",
            StartDate = new DateTime(2019, 04, 30),
            EndDate = new DateTime(2019, 05, 01),

            Duration = "2",
            Progress = 30,
            ParentId=21,
            Predecessor="19,20"

        },
        new TaskData() {
            TaskId = 23,
            TaskName = "Develope designs to meet industry",
            StartDate = new DateTime(2019, 05, 02),
            EndDate = new DateTime(2019, 05, 03),
            Duration = "2",
            Progress = 40,
            ParentId = 21,
            Predecessor="22"
        },
        new TaskData() {
            TaskId = 24,
            TaskName = "Include all the deatails",
            StartDate = new DateTime(2019, 05, 06),
            EndDate = new DateTime(2019, 05, 08),
            Duration = "3",
            Progress = 30,
            ParentId = 21,
            Predecessor="23"
        },
         new TaskData() {
            TaskId = 25,
            TaskName = "CAD computer aided design",
            StartDate = new DateTime(2019, 05, 09),
            EndDate = new DateTime(2019, 05, 13),
            Duration="3",
            Predecessor="24"

        },
        new TaskData() {
            TaskId = 26,
            TaskName = "CAM computer aided manufacturing",
            StartDate = new DateTime(2019, 05, 14),
            EndDate = new DateTime(2019, 05, 16),

            Duration = "3",
            Progress = 30,
            Predecessor="25"

        },
        new TaskData() {
            TaskId = 27,
            TaskName = "Design complete",
            StartDate = new DateTime(2019, 04, 16),
            EndDate = new DateTime(2019, 04, 16),
            Duration = "0",
            Progress = 40,
            Predecessor="26"

        },
        new TaskData() {
            TaskId = 28,
            TaskName = "Prototype testing",
            StartDate = new DateTime(2019, 05, 17),
            EndDate = new DateTime(2019, 05, 22),
            Duration = "4",
            Progress = 30,
            Predecessor="27"


        }, new TaskData() {
            TaskId = 29,
            TaskName = "Include feedback",
            StartDate = new DateTime(2019, 05, 17),
            EndDate = new DateTime(2019, 05, 22),
            Duration="4",
            Predecessor="28ss",



        },
        new TaskData() {
            TaskId = 30,
            TaskName = "Manufacturing",
            StartDate = new DateTime(2019, 05, 23),
            EndDate = new DateTime(2019, 05, 29),

            Duration = "5",
            Progress = 30,
            Predecessor="28,29"

        },
        new TaskData() {
            TaskId = 31,
            TaskName = "Assembling material to finished goods",
            StartDate = new DateTime(2019, 05, 30),
            EndDate = new DateTime(2019, 06, 05),
            Duration = "5",
            Progress = 40,
            Predecessor="30"


        },
        new TaskData() {
            TaskId = 32,
            TaskName = "Final product developement",
            StartDate = new DateTime(2019, 06, 06),
            EndDate = new DateTime(2019, 06, 13),
            Duration = "6",
            Progress = 30,

        }, new TaskData() {
            TaskId =33,
            TaskName = "Important Improvement",
            StartDate = new DateTime(2019, 06, 06),
            EndDate = new DateTime(2019, 06, 10),
            Duration="3",
            ParentId=32,
            Predecessor="31"

        },
        new TaskData() {
            TaskId = 34,
            TaskName = "Customer testing and feedback",
            StartDate = new DateTime(2019, 06, 11),
            EndDate = new DateTime(2019, 06, 13),

            Duration = "3",
            Progress = 30,
            ParentId=32,
            Predecessor="33"

        },
        new TaskData() {
            TaskId = 35,
            TaskName = "Final product developement",
            StartDate = new DateTime(2019, 06, 14),
            EndDate = new DateTime(2019, 06, 19),
            Duration = "4",
            Progress = 40,

        },
        new TaskData() {
            TaskId = 36,
            TaskName = "Important Improvement",
            StartDate = new DateTime(2019, 06, 14),
            EndDate = new DateTime(2019, 06, 19),
            Duration = "4",
            Progress = 30,
            ParentId = 35,
            Predecessor="34"
        },
         new TaskData() {
            TaskId = 37,
            TaskName = "Address any unforeseen issue",
            StartDate = new DateTime(2019, 06, 14),
            EndDate = new DateTime(2019, 06, 19),

            Duration = "4",
            Progress = 30,
            Predecessor="36ss",
            ParentId=35,


        },
        new TaskData() {
            TaskId = 38,
            TaskName = "Final product ",
            StartDate = new DateTime(2019, 06, 20),
            EndDate = new DateTime(2019, 07, 01),
            Duration = "8",
            Progress = 40,

        },
        new TaskData() {
            TaskId = 39,
            TaskName = "Branding product",
            StartDate = new DateTime(2019, 06, 20),
            EndDate = new DateTime(2019, 06, 25),
            Duration = "4",
            Progress = 30,
            ParentId = 38,
            Predecessor="37"
        },
        new TaskData()
        {
            TaskId=40,
            TaskName="Marketing and presales",
            StartDate=new DateTime(2019,06,26),
            EndDate=new DateTime(2019,07,01),
            ParentId=38,
            Duration="4",
            Predecessor="39"
        }
    };
            return Tasks;
        }

    }
}