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
            List<TaskbarData> TaskDataCollection = new List<TaskbarData>();

            TaskbarData Record2 = new TaskbarData()
            {
                TaskId = 1,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 18, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 15, 0),
                Winner = "",
                Performance = "90th Academy awards kicks-off and Jimmy kimmel hosts the show"
            };
            TaskbarData Record3 = new TaskbarData()
            {
                TaskId = 2,
                TaskName = "Actor in a supporting role",
                StartDate = new DateTime(2018, 03, 05, 18, 16, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 25, 0),
                Predecessor = "1",
                Winner = "Sam Rockwell",
                Movie = "Three Billboards Outside Ebbing, Missouri."
            };
            TaskbarData Record4 = new TaskbarData()
            {
                TaskId = 3,
                TaskName = "Hair and makeup",
                StartDate = new DateTime(2018, 03, 05, 18, 26, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 32, 0),
                Predecessor = "2",
                Movie = "Darkest Hour"
            };
            TaskbarData Record5 = new TaskbarData()
            {
                TaskId = 4,
                TaskName = "Costume design",
                StartDate = new DateTime(2018, 03, 05, 18, 33, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 40, 0),
                Predecessor = "3",
                Winner = "Mark Bridges",
                Movie = "Phantom Thread"
            };
            TaskbarData Record6 = new TaskbarData()
            {
                TaskId = 5,
                TaskName = "Documentary feature",
                StartDate = new DateTime(2018, 03, 05, 18, 41, 0),
                EndDate = new DateTime(2018, 03, 05, 18, 58, 0),
                Predecessor = "4",
                Winner = "Bryan Fogel",
                Movie = "Icarus"
            };
            TaskbarData Record7 = new TaskbarData()
            {
                TaskId = 6,
                TaskName = "Best sound editing and sound mixing",
                StartDate = new DateTime(2018, 03, 05, 18, 59, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 10, 0),
                Predecessor = "5",
                Winner = "Richard King and Alex Gibson",
                Movie = "Dunkirk"
            };
            TaskbarData Record8 = new TaskbarData()
            {
                TaskId = 7,
                TaskName = "Production design",
                StartDate = new DateTime(2018, 03, 05, 19, 11, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 15, 0),
                Predecessor = "6",
                Movie = "The Shape of Water"
            };
            TaskbarData Record9 = new TaskbarData()
            {
                TaskId = 8,
                TaskName = "Oscar performance",
                StartDate = new DateTime(2018, 03, 05, 19, 16, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 23, 0),
                Predecessor = "7",
                Performance = "Second performance of the night is 'Remember Me' from Coco",
            };
            TaskbarData Record10 = new TaskbarData()
            {
                TaskId = 9,
                TaskName = "Best foreign language film goes",
                StartDate = new DateTime(2018, 03, 05, 19, 24, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 29, 0),
                Predecessor = "8",
                Movie = "A Fantastic Woman"
            };
            TaskbarData Record11 = new TaskbarData()
            {
                TaskId = 10,
                TaskName = "Best supporting actress",
                StartDate = new DateTime(2018, 03, 05, 19, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 35, 0),
                Predecessor = "9",
                Winner = "Allison Janney",
                Movie = "I, Tonya"
            };
            TaskbarData Record12 = new TaskbarData()
            {
                TaskId = 11,
                TaskName = "Best animated short",
                StartDate = new DateTime(2018, 03, 05, 19, 36, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 45, 0),
                Predecessor = "10",
                Winner = "Kobe Bryant",
                Movie = "Dear Basketball"
            };
            TaskbarData Record13 = new TaskbarData()
            {
                TaskId = 12,
                TaskName = "Award for best animated feature.",
                StartDate = new DateTime(2018, 03, 05, 19, 46, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 52, 0),
                Predecessor = "11",
                Movie = "Coco"
            };
            TaskbarData Record14 = new TaskbarData()
            {
                TaskId = 13,
                TaskName = "Best visual effects.",
                StartDate = new DateTime(2018, 03, 05, 19, 53, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 56, 0),
                Predecessor = "12",
                Movie = "Blade Runner 2049"
            };
            TaskbarData Record15 = new TaskbarData()
            {
                TaskId = 14,
                TaskName = "Achievement in film editing",
                StartDate = new DateTime(2018, 03, 05, 19, 57, 0),
                EndDate = new DateTime(2018, 03, 05, 19, 59, 0),
                Predecessor = "13",
                Movie = "Dunkirk",
            };
            TaskbarData Record16 = new TaskbarData()
            {
                TaskId = 15,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 20, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 09, 0),
                Predecessor = "14",
                Performance = "Jimmy Kimmel surprises moviegoers along with celebrities"
            };
            TaskbarData Record17 = new TaskbarData()
            {
                TaskId = 16,
                TaskName = "Best documentary short",
                StartDate = new DateTime(2018, 03, 05, 20, 10, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 12, 0),
                Predecessor = "15",
                Movie = "Heaven is a traffic jam on the 405"
            };
            TaskbarData Record18 = new TaskbarData()
            {
                TaskId = 17,
                TaskName = "Best live action short film",
                StartDate = new DateTime(2018, 03, 05, 20, 13, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 15, 0),
                Predecessor = "16",
                Movie = "The Silent Child"
            };
            TaskbarData Record19 = new TaskbarData()
            {
                TaskId = 18,
                TaskName = "Oscar performance",
                StartDate = new DateTime(2018, 03, 05, 20, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 09, 0),
                Predecessor = "17",
                Performance = "Jimmy Kimmel surprCommon and Andra Day performs 'Stand Up for Something' by 'Marshall'"
            };
            TaskbarData Record20 = new TaskbarData()
            {
                TaskId = 19,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 20, 26, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 29, 0),
                Predecessor = "18",
                Performance = "The oscars are showcasing the #MeToo and #TimesUp movements with a montage and interviews with actors and filmmakers"
            };
            TaskbarData Record21 = new TaskbarData()
            {
                TaskId = 20,
                TaskName = "Oscar for best adapted screenplay",
                StartDate = new DateTime(2018, 03, 05, 20, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 35, 0),
                Predecessor = "19",
                Winner = "James Ivory",
                Movie = "Call Me By Your Name"
            };
            TaskbarData Record22 = new TaskbarData()
            {
                TaskId = 21,
                TaskName = "Oscar for best original screenplay",
                StartDate = new DateTime(2018, 03, 05, 20, 36, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 44, 0),
                Predecessor = "20",
                Winner = "Jordan Peele",
                Movie = "Get Out"
            };
            TaskbarData Record23 = new TaskbarData()
            {
                TaskId = 22,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 20, 40, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 45, 0),
                Predecessor = "21",
                Performance = "Who’s trending on Twitter at the Oscars? Actors Timothée Chalamet, Chadwick Boseman,Tom Holland, Lupita Nyong’o and Adam Rippon."
            };
            TaskbarData Record24 = new TaskbarData()
            {
                TaskId = 23,
                TaskName = "Best cinematography",
                StartDate = new DateTime(2018, 03, 05, 20, 46, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 48, 0),
                Predecessor = "22",
                Winner = "Roger A. Deakins",
                Movie = "Blade Runner 2049"
            };

            TaskbarData Record25 = new TaskbarData()
            {
                TaskId = 24,
                TaskName = "Oscar performance",
                StartDate = new DateTime(2018, 03, 05, 20, 49, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 54, 0),
                Predecessor = "23",
                Performance = "Keala Settle performs the nominated song 'This is Me' from 'The Greatest Showman'."
            };
            TaskbarData Record26 = new TaskbarData()
            {
                TaskId = 25,
                TaskName = "Best original score",
                StartDate = new DateTime(2018, 03, 05, 20, 55, 0),
                EndDate = new DateTime(2018, 03, 05, 20, 59, 0),
                Predecessor = "24",
                Movie = "The Shape of Water"
            };
            TaskbarData Record27 = new TaskbarData()
            {
                TaskId = 26,
                TaskName = "Award for original song",
                StartDate = new DateTime(2018, 03, 05, 21, 0, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 07, 0),
                Predecessor = "25",
                Winner = "Remember Me",
                Movie = "Coco"
            };
            TaskbarData Record28 = new TaskbarData()
            {
                TaskId = 27,
                TaskName = "Oscar moments",
                StartDate = new DateTime(2018, 03, 05, 21, 05, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 11, 0),
                Predecessor = "26",
                Performance = "Time to pay tribute to those in the cinema world we lost last year"
            };
            TaskbarData Record29 = new TaskbarData()
            {
                TaskId = 28,
                TaskName = "Oscar for best director",
                StartDate = new DateTime(2018, 03, 05, 21, 12, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 19, 0),
                Predecessor = "27",
                Winner = "Guillermo del Toro",
                Movie = "The Shape of Water"
            };
            TaskbarData Record30 = new TaskbarData()
            {
                TaskId = 29,
                TaskName = "Best actor in a leading role",
                StartDate = new DateTime(2018, 03, 05, 21, 20, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 29, 0),
                Predecessor = "28",
                Winner = "Gary Oldman",
                Movie = "The Shape of Water"
            };
            TaskbarData Record31 = new TaskbarData()
            {
                TaskId = 30,
                TaskName = "Best leading actress",
                StartDate = new DateTime(2018, 03, 05, 21, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 44, 0),
                Predecessor = "29",
                Winner = "Frances McDormand",
                Movie = "Three Billboards Outside Ebbing, Missouri"
            };
            TaskbarData Record32 = new TaskbarData()
            {
                TaskId = 31,
                TaskName = "Oscar for best picture.",
                StartDate = new DateTime(2018, 03, 05, 21, 20, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 29, 0),
                Predecessor = "30",
                Movie = "The Shape of Water"
            };
            TaskbarData Record33 = new TaskbarData()
            {
                TaskId = 32,
                TaskName = "90th Academy awards wind-up",
                StartDate = new DateTime(2018, 03, 05, 21, 30, 0),
                EndDate = new DateTime(2018, 03, 05, 21, 30, 0),
                Predecessor = "31",
                Duration = "0",
                Performance = "90th Academy awards wind-up"
            };

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
            TaskDataCollection.Add(Record24);
            TaskDataCollection.Add(Record25);
            TaskDataCollection.Add(Record26);
            TaskDataCollection.Add(Record27);
            TaskDataCollection.Add(Record28);
            TaskDataCollection.Add(Record29);
            TaskDataCollection.Add(Record30);
            TaskDataCollection.Add(Record31);
            TaskDataCollection.Add(Record32);
            TaskDataCollection.Add(Record33);
            return TaskDataCollection;
        } 
    }
}
