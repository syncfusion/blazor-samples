#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
namespace blazor_taskdetails
{
    public class TaskDetails
    {
        public TaskDetails(int? TaskID, string Name, String Priority, string Status, String AssignedTo, String Description, DateTime OpenedDays, int DaysOld, String BugSource, String AssociatedFeature, String CreatedBy, String NotificationStatus)
        {
            this.TaskID = TaskID;
            this.Name = Name;
            this.Priority = Priority;
            this.Status = Status;
            this.AssignedTo = AssignedTo;
            this.Description = Description;
            this.OpenedDays = OpenedDays;
            this.DaysOld = DaysOld;
            this.BugSource = BugSource;
            this.AssociatedFeature = AssociatedFeature;
            this.CreatedBy = CreatedBy;
            this.NotificationStatus = NotificationStatus;
        }
        public static List<TaskDetails> GetAllTaskDetails()
        {
            List<TaskDetails> Datas = new List<TaskDetails>();
            {
                Datas.Add(new TaskDetails(10001, "Harder to work during power-saving mode", "High", "In Progress", "Tana", "The app slows down significantly when the device enters power-saving mode.", new DateTime(2019, 06, 15), 505, "Shared by unsigned user", "Battery", "Flynn", "Need to Notify"));
                Datas.Add(new TaskDetails(10002, "Application crash on clicking save button", "High", "In Progress", " Ken", "Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum.", new DateTime(2019, 06, 16), 504, "Found during testing", "Security", "Gillian", "Need to Notify"));

                Datas.Add(new TaskDetails(10003, "Transaction details are lost", "High", "Completed", "Roger", " Praesent mauris. Fusce nec tellus sed augue semper porta. Mauris massa.", new DateTime(2019, 06, 15), 505, "Email issued from William (wiliam@example.com)", "Security", " Michael", "Already Notified"));


                Datas.Add(new TaskDetails(10004, "  Working speed differs with different networks", "Low", "By Design", "Lucy", "Vestibulum lacinia arcu eget nulla. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.", new DateTime(2019, 06, 10), 500, "Reported by unsigned user", "Network", "Anton", "Already Notified"));

                Datas.Add(new TaskDetails(10005, " Does not handle Interrupts Properly", "Critical", "Completed", "Smith", "Curabitur sodales ligula in libero. Sed dignissim lacinia nunc. Curabitur tortor. ", new DateTime(2019, 06, 10), 500, "Found during internal testing", "Notifications", "Anton", "Already Notified"));

                Datas.Add(new TaskDetails(10006, " Takes more than 30 seconds to start", "High", "In Progress", "Lucy", "Pellentesque nibh. Aenean quam. In scelerisque sem at dolor. ", new DateTime(2019, 06, 5), 495, "Shared by customer call", "Speed", " Gillian", "Need to Notify"));

                Datas.Add(new TaskDetails(10007, " No progress indicator", "Critical", "Completed", "Smith", "Maecenas mattis. Sed convallis tristique sem. Proin ut ligula vel nunc egestas porttitor.", new DateTime(2019, 06, 5), 495, "Posted in community forum", "Notification", "Anton", "Already Notified"));

                Datas.Add(new TaskDetails(10008, " Words break when changing screen resolution", "Normal", "In Progress", "Joe", "Morbi lectus risus, iaculis vel, suscipit quis, luctus non, massa.", new DateTime(2019, 06, 15), 505, "Email issued from Jack (jack@example.com)", "Screen", "Isaac", "Need to Notify"));

                Datas.Add(new TaskDetails(10009, "Download files to a private data directory", "Critical", "In Progress", "Jack", "Fusce ac turpis quis ligula lacinia aliquet. Mauris ipsum.", new DateTime(2019, 06, 15), 504, "Email issued from John (john@example.com)", " Security", "Bold", "Need to Notify"));

                Datas.Add(new TaskDetails(10010, "Asking permission to access gallery", "Low", "By Design", "Nick", "Nunc feugiat mi a tellus consequat imperdiet. Vestibulum sapien. Proin quam. Etiam ultrices. Suspendisse in justo eu magna luctus suscipit.", new DateTime(2019, 06, 5), 490, "Posted in forum", "Security", "George", "Already Notified"));


                Datas.Add(new TaskDetails(10011, "Data Leakage", "Critical", "In Progress", "John", "Integer euismod lacus luctus magna. Quisque cursus, metus vitae pharetra auctor, sem massa mattis sem.", new DateTime(2019, 06, 10), 500, "Found internally during testing", "Security", "Anton", "Need to Notify"));

                Datas.Add(new TaskDetails(10012, "Installation error for previous Android versions", "Normal", "By Design", " Lewis", " Nulla metus metus, ullamcorper vel, tincidunt sed, euismod in, nibh. Quisque volutpat condimentum velit.", new DateTime(2019, 06, 15), 504, "Found during testing", "Android", "Kahn", "Already Notified"));


                Datas.Add(new TaskDetails(10013, "Opens after the location is accessed", "Low", "Won't Fix", "Gibson", "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam nec ante.", new DateTime(2019, 06, 5), 495, "Reported by unsigned user", "Security", "Herbert", "Already Notified"));

                Datas.Add(new TaskDetails(10014, "Memory-related issue", "Normal", "In Progress", "Julie", "Sed lacinia, urna non tincidunt mattis, tortor neque adipiscing diam, a cursus ipsum ante quis turpis. Nulla facilisi. Ut fringilla.", new DateTime(2019, 06, 1), 480, "Posted in forum", " Memory", "Isaac", "Need to Notify"));

                Datas.Add(new TaskDetails(10015, "Security questions are not working properly", "High", "Completed", "Lucy", "Sed lacinia, urna non tincidunt mattis, tortor neque adipiscing diam, a cursus ipsum ante quis turpis. Nulla facilisi.", new DateTime(2019, 06, 1), 480, " Email from Andrew (andrew@example.com)", "Security", "Wells", "Already Notified"));

                Datas.Add(new TaskDetails(10016, "Requires a login after the connection lost its strength", "Low", "Cannot Reproduce", "Issac", "Suspendisse potenti. Nunc feugiat mi a tellus consequat imperdiet. Vestibulum sapien. ", new DateTime(2019, 06, 15), 505, "Reported by unsigned user", "Speed", "Mary", "Already Notified"));


                Datas.Add(new TaskDetails(10017, "The app crashes", "High", "In Progress", "John", "Nulla metus metus, ullamcorper vel, tincidunt sed, euismod in, nibh. Quisque volutpat condimentum velit.", new DateTime(2019, 06, 1), 485, "Email issued from Jack (jack@example.com)", "Security", "Anton", "Need to Notify"));

                Datas.Add(new TaskDetails(10018, "Showing wrong error message", "Normal", "Blocked", "William", " Proin quam. Etiam ultrices. Suspendisse in justo eu magna luctus suscipit.", new DateTime(2019, 06, 10), 500, " Posted in community forum", "Notification", " Gillian", "Need to Notify"));

                Datas.Add(new TaskDetails(10019, "Consumes more power when in battery-saving mode", "Critical", "In Progress", "John", "Sed lectus. Integer euismod lacus luctus magna. Quisque cursus, metus vitae pharetra auctor, sem massa mattis sem.", new DateTime(2019, 06, 15), 505, "Email issued from Joe (joe@example.com)", "Battery", "Anton", "Need to Notify"));

                Datas.Add(new TaskDetails(10020, "Security level is low", "Critical", "In Progress", "Lucy", "Quisque volutpat condimentum velit, Integer euismod lacus luctus magna. Quisque cursus, luctus non, massa.", new DateTime(2019, 06, 20), 505, "Email issued from Issac (issac@example.com)", "Security", "Mary", "Already Notified"));




            }
            return Datas;
        }

        public int? TaskID { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string AssignedTo { get; set; }
        public string Description { get; set; }
        public DateTime? OpenedDays { get; set; }
        public int? DaysOld { get; set; }

        public string BugSource { get; set; }
        public string AssociatedFeature { get; set; }
        public string CreatedBy { get; set; }
        public string NotificationStatus { get; set; }
    }
}
