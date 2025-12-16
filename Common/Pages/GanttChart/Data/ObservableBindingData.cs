#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BlazorDemos.Pages.GanttChart.Data
{
    public class ObservableBindingData
    {
        /// <summary>
        /// Gets or sets the task name and triggers property change notification.
        /// </summary>
        public class TaskData : INotifyPropertyChanged
        {
            public int TaskId { get; set; }
            private string taskName { get; set; }
            public string TaskName
            {
                get { return taskName; }
                set
                {
                    if (value != taskName)
                    {
                        taskName = value;
                        NotifyPropertyChanged("TaskName");
                    }
                }
            }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public int? ParentId { get; set; }
            public event PropertyChangedEventHandler? PropertyChanged;

            /// <summary>
            /// Notifies listeners that a property value has changed.
            /// </summary>
            private void NotifyPropertyChanged(String propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }

        /// <summary>
        /// Generates and returns a observable collection of Gantt task data.
        /// </summary>
        public static ObservableCollection<TaskData> ProjectNewData()
        {
            ObservableCollection<TaskData> Tasks = new ObservableCollection<TaskData>() {
                new TaskData() {TaskId = 1,TaskName = "Product concept ",StartDate = new DateTime(2021, 04, 02),EndDate = new DateTime(2021, 04, 08),Duration = "5days"},
                new TaskData() {TaskId = 2,TaskName = "Define the product usage",StartDate = new DateTime(2021, 04, 02),EndDate = new DateTime(2021, 04, 08),Duration = "3",Progress = 30,ParentId = 1},
                new TaskData() {TaskId = 3,TaskName = "Define the target audience",EndDate = new DateTime(2021, 04, 04),Progress = 40,ParentId = 1},
                new TaskData() {TaskId = 4,TaskName = "Prepare product sketch and notes",StartDate = new DateTime(2021, 04, 05),Duration = "2",Progress = 30,ParentId = 1},
                new TaskData() {TaskId = 5,TaskName = "Concept approval",StartDate = new DateTime(2021, 04, 08),EndDate = new DateTime(2021, 04, 08),Duration="0",ParentId = 1},
                new TaskData() {TaskId = 6,TaskName = "Market research",StartDate = new DateTime(2021, 04, 09),EndDate = new DateTime(2021, 04, 18),Duration = "4",Progress = 30},
                new TaskData() {TaskId = 7,TaskName = "Demand analysis",Duration = "4",Progress = 40,ParentId = 6},
                new TaskData() {TaskId = 8,TaskName = "Customer strength",StartDate = new DateTime(2021, 04, 09),EndDate = new DateTime(2021, 04, 12),Duration = "4",Progress = 30,ParentId = 7},
                new TaskData() {TaskId = 9,TaskName = "Market opportunity analysis",StartDate = new DateTime(2021, 04, 09),EndDate = new DateTime(2021, 04, 012),Duration="4",ParentId= 7},
                new TaskData() {TaskId = 10,TaskName = "Competitor analysis",StartDate = new DateTime(2021, 04, 15),EndDate = new DateTime(2021, 04, 18),Duration = "4",Progress = 30,ParentId= 6},
                new TaskData() {TaskId = 11,TaskName = "Product strength analysis",StartDate = new DateTime(2021, 04, 15),EndDate = new DateTime(2021, 04, 18),Duration = "4",Progress = 40,ParentId = 6},
                new TaskData() {TaskId = 12,TaskName = "Research completed",StartDate = new DateTime(2021, 04, 18),EndDate = new DateTime(2021, 04, 18),Duration = "0",Progress = 30,ParentId = 6},
                new TaskData() {TaskId = 13,TaskName = "Product design and development",StartDate = new DateTime(2021, 04, 19),EndDate = new DateTime(2021, 05, 16),Duration="20"},
                new TaskData() {TaskId = 14,TaskName = "Functionality design",StartDate = new DateTime(2021, 04, 19),EndDate = new DateTime(2021, 04, 23),Duration = "3",Progress = 30,ParentId = 13},
                new TaskData() {TaskId = 15,TaskName = "Quality design",StartDate = new DateTime(2021, 04, 19),EndDate = new DateTime(2021, 04, 23),Duration = "3",Progress = 40,ParentId = 13},
                new TaskData() {TaskId = 16,TaskName = "Define reliability",StartDate = new DateTime(2021, 04, 24),EndDate = new DateTime(2021, 04, 25),Duration = "2",Progress = 30,ParentId = 13},
                new TaskData() {TaskId = 17,TaskName = "Identifying raw materials",StartDate = new DateTime(2021, 04, 24),EndDate = new DateTime(2021, 04, 25),Duration="2",ParentId=13},
                new TaskData() {TaskId = 18,TaskName = "Define cost plan",StartDate = new DateTime(2021, 04, 26),EndDate = new DateTime(2021, 04, 29),Duration = "2",Progress = 30,ParentId=13},
                new TaskData() {TaskId = 19,TaskName = "Estimate manufacturing cost",StartDate = new DateTime(2021, 04, 26),EndDate = new DateTime(2021, 04, 29),Duration = "2",Progress = 40,ParentId = 18},
                new TaskData() {TaskId = 20,TaskName = "Estimate selling cost",StartDate = new DateTime(2021, 04, 26),EndDate = new DateTime(2021, 04, 29),Duration = "2",Progress = 30,ParentId = 18},
                new TaskData() {TaskId = 21,TaskName = "Development of final design",StartDate = new DateTime(2021, 04, 30),EndDate = new DateTime(2021, 05, 08),Duration="7",ParentId=13},
                new TaskData() {TaskId = 22,TaskName = "Develop dimensions and design",StartDate = new DateTime(2021, 04, 30),EndDate = new DateTime(2021, 05, 01),Duration = "2",Progress = 30,ParentId=21},
                new TaskData() {TaskId = 23,TaskName = "Develop designs to meet industry",StartDate = new DateTime(2021, 05, 02),EndDate = new DateTime(2021, 05, 03),Duration = "2",Progress = 40,ParentId = 21},
                new TaskData() {TaskId = 24,TaskName = "Include all the details",StartDate = new DateTime(2021, 05, 06),EndDate = new DateTime(2021, 05, 08),Duration = "3",Progress = 30,ParentId = 21},
                new TaskData() {TaskId = 25,TaskName = "CAD - Computer Aided Design",StartDate = new DateTime(2021, 05, 09),EndDate = new DateTime(2021, 05, 13),Duration="3"},
                new TaskData() {TaskId = 26,TaskName = "CAM - Computer Aided Manufacturing",StartDate = new DateTime(2021, 05, 14),EndDate = new DateTime(2021, 05, 16),Duration = "3",Progress = 30},
                new TaskData() {TaskId = 27,TaskName = "Finalize the design",StartDate = new DateTime(2021, 04, 16),EndDate = new DateTime(2021, 04, 16),Duration = "0",Progress = 40},
                new TaskData() {TaskId = 28,TaskName = "Prototype testing",StartDate = new DateTime(2021, 05, 17),EndDate = new DateTime(2021, 05, 22),Duration = "4",Progress = 30},
                new TaskData() {TaskId = 29,TaskName = "Include feedback",StartDate = new DateTime(2021, 05, 17),EndDate = new DateTime(2021, 05, 22),Duration="4"},
                new TaskData() {TaskId = 30,TaskName = "Manufacturing",StartDate = new DateTime(2021, 05, 23),EndDate = new DateTime(2021, 05, 29),Duration = "5",Progress = 30},
                new TaskData() {TaskId = 31,TaskName = "Assembling material into finished goods",StartDate = new DateTime(2021, 05, 30),EndDate = new DateTime(2021, 06, 05),Duration = "5",Progress = 40},
                new TaskData() {TaskId = 32,TaskName = "Final product development",StartDate = new DateTime(2021, 06, 06),EndDate = new DateTime(2021, 06, 13),Duration = "6",Progress = 30},
                new TaskData() {TaskId =33,TaskName = "Important improvement",StartDate = new DateTime(2021, 06, 06),EndDate = new DateTime(2021, 06, 10),Duration="3",ParentId=32},
                new TaskData() {TaskId = 34,TaskName = "Customer testing and feedback",StartDate = new DateTime(2021, 06, 11),EndDate = new DateTime(2021, 06, 13),Duration = "3",Progress = 30,ParentId=32},
                new TaskData() {TaskId = 35,TaskName = "Final product development",StartDate = new DateTime(2021, 06, 14),EndDate = new DateTime(2021, 06, 19),Duration = "4",Progress = 40},
                new TaskData() {TaskId = 36,TaskName = "Important improvement",StartDate = new DateTime(2021, 06, 14),EndDate = new DateTime(2021, 06, 19),Duration = "4",Progress = 30,ParentId = 35},
                new TaskData() {TaskId = 37,TaskName = "Address any unforeseen issues",StartDate = new DateTime(2021, 06, 14),EndDate = new DateTime(2021, 06, 19),Duration = "4",Progress = 30,ParentId=35},
                new TaskData() {TaskId = 38,TaskName = "Finalize the product ",StartDate = new DateTime(2021, 06, 20),EndDate = new DateTime(2021, 07, 01),Duration = "8",Progress = 40},
                new TaskData() {TaskId = 39,TaskName = "Branding the product",StartDate = new DateTime(2021, 06, 20),EndDate = new DateTime(2021, 06, 25),Duration = "4",Progress = 30,ParentId = 38},
                new TaskData() {TaskId=40,TaskName="Marketing and presales",StartDate=new DateTime(2021,06,26),EndDate=new DateTime(2021,07,01),ParentId=38,Duration="4"}
            };
            return Tasks;
        }
    }
}
