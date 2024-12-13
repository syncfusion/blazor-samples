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
namespace ej2_blazor_taskbartemplatedata
{
    public class TaskbarTemplateData
    {
        public class TaskData
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Duration { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public int? ParentId { get; set; }
        }
        public class TaskProperties
        {
            public string TaskName { get; set; }
            public double Duration { get; set; }
        }
        public class TaskbarData : TaskData
        {
            public string Performance { get; set; }
            public string Winner { get; set; }
            public string Movie { get; set; }
        }
        public static List<TaskbarData> TaskTemplateData()
        {
            List<TaskbarData> TaskDataCollection = new List<TaskbarData>() 
            {
                new TaskbarData() { TaskId = 1, TaskName = "Oscar Moments", StartDate = new DateTime(2021, 03, 05, 18, 0, 0), EndDate = new DateTime(2021, 03, 05, 18, 15, 0), Winner = "", Performance = "90th Academy awards kicks-off and Jimmy Kimmel hosts the show" },
                new TaskbarData() { TaskId = 2, TaskName = "Actor in Supporting Role", StartDate = new DateTime(2021, 03, 05, 18, 16, 0), EndDate = new DateTime(2021, 03, 05, 18, 25, 0), Predecessor = "1", Winner = "Sam Rockwell", Movie = "Three Billboards Outside Ebbing, Missouri" },
                new TaskbarData() { TaskId = 3, TaskName = "Hair and Makeup", StartDate = new DateTime(2021, 03, 05, 18, 26, 0), EndDate = new DateTime(2021, 03, 05, 18, 32, 0), Predecessor = "2", Movie = "Darkest Hour" },
                new TaskbarData() { TaskId = 4, TaskName = "Costume Design", StartDate = new DateTime(2021, 03, 05, 18, 33, 0), EndDate = new DateTime(2021, 03, 05, 18, 40, 0), Predecessor = "3", Winner = "Mark Bridges", Movie = "Phantom Thread" },
                new TaskbarData() { TaskId = 5, TaskName = "Documentary Feature", StartDate = new DateTime(2021, 03, 05, 18, 41, 0), EndDate = new DateTime(2021, 03, 05, 18, 58, 0), Predecessor = "4", Winner = "Bryan Fogel", Movie = "Icarus" },
                new TaskbarData() { TaskId = 6, TaskName = "Best Sound Editing and Sound Mixing", StartDate = new DateTime(2021, 03, 05, 18, 59, 0), EndDate = new DateTime(2021, 03, 05, 19, 10, 0), Predecessor = "5", Winner = "Richard King and Alex Gibson", Movie = "Dunkirk" },
                new TaskbarData() { TaskId = 7, TaskName = "Production Design", StartDate = new DateTime(2021, 03, 05, 19, 11, 0), EndDate = new DateTime(2021, 03, 05, 19, 15, 0), Predecessor = "6", Movie = "The Shape of Water" },
                new TaskbarData() { TaskId = 8, TaskName = "Oscar Performance", StartDate = new DateTime(2021, 03, 05, 19, 16, 0), EndDate = new DateTime(2021, 03, 05, 19, 23, 0), Predecessor = "7", Performance = "Second performance of the night is 'Remember Me' from Coco" },
                new TaskbarData() { TaskId = 9, TaskName = "Best Foreign Language Film goes to", StartDate = new DateTime(2021, 03, 05, 19, 24, 0), EndDate = new DateTime(2021, 03, 05, 19, 29, 0), Predecessor = "8", Movie = "A Fantastic Woman" },
                new TaskbarData() { TaskId = 10, TaskName = "Best Supporting Actress", StartDate = new DateTime(2021, 03, 05, 19, 30, 0), EndDate = new DateTime(2021, 03, 05, 19, 35, 0), Predecessor = "9", Winner = "Allison Janney", Movie = "I, Tonya" },
                new TaskbarData() { TaskId = 11, TaskName = "Best Animated Short", StartDate = new DateTime(2021, 03, 05, 19, 36, 0), EndDate = new DateTime(2021, 03, 05, 19, 45, 0), Predecessor = "10", Winner = "Kobe Bryant", Movie = "Dear Basketball" },
                new TaskbarData() { TaskId = 12, TaskName = "Award for Best Animated Feature", StartDate = new DateTime(2021, 03, 05, 19, 46, 0), EndDate = new DateTime(2021, 03, 05, 19, 52, 0), Predecessor = "11", Movie = "Coco" },
                new TaskbarData() { TaskId = 13, TaskName = "Best Visual Effects", StartDate = new DateTime(2021, 03, 05, 19, 53, 0), EndDate = new DateTime(2021, 03, 05, 19, 56, 0), Predecessor = "12", Movie = "Blade Runner 2049" },
                new TaskbarData() { TaskId = 14, TaskName = "Achievement in Film Editing", StartDate = new DateTime(2021, 03, 05, 19, 57, 0), EndDate = new DateTime(2021, 03, 05, 19, 59, 0), Predecessor = "13", Movie = "Dunkirk" },
                new TaskbarData() { TaskId = 15, TaskName = "Oscar Moments", StartDate = new DateTime(2021, 03, 05, 20, 0, 0), EndDate = new DateTime(2021, 03, 05, 20, 09, 0), Predecessor = "14", Performance = "Jimmy Kimmel surprises moviegoers along with celebrities" },
                new TaskbarData() { TaskId = 16, TaskName = "Best Documentary Short", StartDate = new DateTime(2021, 03, 05, 20, 10, 0), EndDate = new DateTime(2021, 03, 05, 20, 12, 0), Predecessor = "15", Movie = "Heaven is a traffic jam on the 405" },
                new TaskbarData() { TaskId = 17, TaskName = "Best Live Action Short Film", StartDate = new DateTime(2021, 03, 05, 20, 13, 0), EndDate = new DateTime(2021, 03, 05, 20, 15, 0), Predecessor = "16", Movie = "The Silent Child" },
                new TaskbarData() { TaskId = 18, TaskName = "Oscar Performance", StartDate = new DateTime(2021, 03, 05, 20, 0, 0), EndDate = new DateTime(2021, 03, 05, 20, 09, 0), Predecessor = "17", Performance = "Jimmy Kimmel and Andra Day performs 'Stand Up for Something' by 'Marshall'" },
                new TaskbarData() { TaskId = 19, TaskName = "Oscar Moments", StartDate = new DateTime(2021, 03, 05, 20, 26, 0), EndDate = new DateTime(2021, 03, 05, 20, 29, 0), Predecessor = "18", Performance = "The Oscars are showcasing the #MeToo and #TimesUp movements with a montage and interviews with actors and filmmakers" },
                new TaskbarData() { TaskId = 20, TaskName = "Oscar for Best Adapted Screenplay", StartDate = new DateTime(2021, 03, 05, 20, 30, 0), EndDate = new DateTime(2021, 03, 05, 20, 35, 0), Predecessor = "19", Winner = "James Ivory", Movie = "Call Me By Your Name" },
                new TaskbarData() { TaskId = 21, TaskName = "Oscar for Best Original Screenplay", StartDate = new DateTime(2021, 03, 05, 20, 36, 0), EndDate = new DateTime(2021, 03, 05, 20, 44, 0), Predecessor = "20", Winner = "Jordan Peele", Movie = "Get Out" },
                new TaskbarData() { TaskId = 22, TaskName = "Oscar Moments", StartDate = new DateTime(2021, 03, 05, 20, 40, 0), EndDate = new DateTime(2021, 03, 05, 20, 45, 0), Predecessor = "21", Performance = "Who’s trending on Twitter at the Oscars? Actors Timothée Chalamet, Chadwick Boseman, Tom Holland, Lupita Nyong’o and Adam Rippon." },
                new TaskbarData() { TaskId = 23, TaskName = "Best Cinematography", StartDate = new DateTime(2021, 03, 05, 20, 46, 0), EndDate = new DateTime(2021, 03, 05, 20, 48, 0), Predecessor = "22", Winner = "Roger A. Deakins", Movie = "Blade Runner 2049" },
                new TaskbarData() { TaskId = 24, TaskName = "Oscar Performance", StartDate = new DateTime(2021, 03, 05, 20, 49, 0), EndDate = new DateTime(2021, 03, 05, 20, 54, 0), Predecessor = "23", Performance = "Keala Settle performs the nominated song 'This is Me' from 'The Greatest Showman'." },
                new TaskbarData() { TaskId = 25, TaskName = "Best Original Score", StartDate = new DateTime(2021, 03, 05, 20, 55, 0), EndDate = new DateTime(2021, 03, 05, 20, 59, 0), Predecessor = "24", Movie = "The Shape of Water" },
                new TaskbarData() { TaskId = 26, TaskName = "Award for Original Song", StartDate = new DateTime(2021, 03, 05, 21, 0, 0), EndDate = new DateTime(2021, 03, 05, 21, 07, 0), Predecessor = "25", Winner = "Remember Me", Movie = "Coco" },
                new TaskbarData() { TaskId = 27, TaskName = "Oscar Moments", StartDate = new DateTime(2021, 03, 05, 21, 05, 0), EndDate = new DateTime(2021, 03, 05, 21, 11, 0), Predecessor = "26", Performance = "Time to pay tribute to those in the cinema world we lost last year" },
                new TaskbarData() { TaskId = 28, TaskName = "Oscar for Best Director", StartDate = new DateTime(2021, 03, 05, 21, 12, 0), EndDate = new DateTime(2021, 03, 05, 21, 19, 0), Predecessor = "27", Winner = "Guillermo del Toro", Movie = "The Shape of Water" },
                new TaskbarData() { TaskId = 29, TaskName = "Best Actor in a Leading Role", StartDate = new DateTime(2021, 03, 05, 21, 20, 0), EndDate = new DateTime(2021, 03, 05, 21, 29, 0), Predecessor = "28", Winner = "Gary Oldman", Movie = "The Shape of Water" },
                new TaskbarData() { TaskId = 30, TaskName = "Best Leading Actress", StartDate = new DateTime(2021, 03, 05, 21, 30, 0), EndDate = new DateTime(2021, 03, 05, 21, 44, 0), Predecessor = "29", Winner = "Frances McDormand", Movie = "Three Billboards Outside Ebbing, Missouri" },
                new TaskbarData() { TaskId = 31, TaskName = "Oscar for Best Picture", StartDate = new DateTime(2021, 03, 05, 21, 20, 0), EndDate = new DateTime(2021, 03, 05, 21, 29, 0), Predecessor = "30", Movie = "The Shape of Water" },
                new TaskbarData() { TaskId = 32, TaskName = "90th Academy Awards Wind-Up", StartDate = new DateTime(2021, 03, 05, 21, 30, 0), EndDate = new DateTime(2021, 03, 05, 21, 30, 0), Predecessor = "31", Duration = "0", Performance = "90th Academy Awards Wind-Up" }

            };
            return TaskDataCollection;
        } 
    }
}