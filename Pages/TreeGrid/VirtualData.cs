using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_virtualdata
{
    public class VirtualData
    {
        public int TaskID { get; set; }
        public string FIELD1 { get; set; }
        public int FIELD2 { get; set; }
        public int FIELD3 { get; set; }
        public int FIELD4 { get; set; }
        public int FIELD5 { get; set; }
        public int FIELD6 { get; set; }
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

            var rand = new Random();

            var RecordID = 0;

            for (var i = 1; i <= 2000; i++)
            {
                var name = rand.Next(0, 100);
                VirtualData Parent = new VirtualData()
                {
                    TaskID = ++RecordID,
                    FIELD1 = Names[name],
                    FIELD2 = 1967 + rand.Next(0, 10),
                    FIELD3 = 395 + rand.Next(100, 600),
                    FIELD4 = 87 + rand.Next(50, 250),
                    FIELD5 = 410 + rand.Next(100, 600),
                    FIELD6 = 67 + rand.Next(50, 250),
                    ParentID = null
                };

                DataCollection.Add(Parent);

                for (var j = 1; j <= 4; j++)
                {
                    var childName = rand.Next(0, 100);
                    DataCollection.Add(new VirtualData()
                    {
                        TaskID = ++RecordID,
                        FIELD1 = Names[childName],
                        FIELD2 = 1967 + rand.Next(0, 10),
                        FIELD3 = 395 + rand.Next(100, 600),
                        FIELD4 = 87 + rand.Next(50, 250),
                        FIELD5 = 410 + rand.Next(100, 600),
                        FIELD6 = 67 + rand.Next(50, 250),
                        ParentID = Parent.TaskID
                    });
                }


                

            }
            return DataCollection;

        }

    }
}
