using System;
using System.Collections.Generic;

namespace BlazorSparklineGridData
{
	public class SparkGridData
	{
		public SparkGridData()
		{
		}

		public SparkGridData(string name, int id1, int id2)
		{

			this.name = name;
			this.id1 = id1;
			this.id2 = id2;
		}

		public string? name { get; set; }
		public int id1 { get; set; }
		public int id2 { get; set; }
        public static IEnumerable<SparkGridData> GetAllRecords()
        {
            return new List<SparkGridData>
			{
				new SparkGridData("Product A", 1, 1),
				new SparkGridData("Product B", 2, 2),
				new SparkGridData("Product C", 3, 3),
				new SparkGridData("Product D", 4, 4),
				new SparkGridData("Product E", 5, 5)
			};
        }
    }

	public class SparklineGridData
	{
		public SparklineGridData()
		{
		}

		public SparklineGridData(int id, string name, DateTime orderdate, string shipcountry )
		{
			this.id = id;
			this.name = name;
			this.orderdate = orderdate;
			this.shipcountry = shipcountry;
		}

		public int id { get; set; }
		public string? name { get; set; }
		public DateTime orderdate { get; set; }
		public string? shipcountry { get; set; }

        public static IReadOnlyList<SparklineGridData> GetAllRecords()
        {
            return new List<SparklineGridData>
			{
				new SparklineGridData(1, "VINET", new DateTime(1996, 07, 04), "France"),
				new SparklineGridData(2, "TOMSP", new DateTime(1996, 07, 05), "Germany"),
				new SparklineGridData(3, "HANAR", new DateTime(1996, 07, 08), "Brazil"),
				new SparklineGridData(4, "VICTE", new DateTime(1996, 07, 08), "France"),
				new SparklineGridData(5, "SUPRD", new DateTime(1996, 07, 09), "Belgium"),
				new SparklineGridData(6, "HANAR", new DateTime(1996, 07, 10), "Brazil"),
				new SparklineGridData(7, "CHOPS", new DateTime(1996, 07, 11), "Switzerland"),
				new SparklineGridData(8, "RICSU", new DateTime(1996, 07, 12), "Switzerland"),
				new SparklineGridData(9, "WELLI", new DateTime(1996, 07, 15), "Brazil"),
				new SparklineGridData(10, "HILAA", new DateTime(1996, 07, 16), "Venezuela"),
				new SparklineGridData(11, "ERNSH", new DateTime(1996, 07, 17), "Austria"),
				new SparklineGridData(12, "CENTC", new DateTime(1996, 07, 18), "Mexico"),
				new SparklineGridData(13, "OTTIK", new DateTime(1996, 07, 19), "Germany"),
				new SparklineGridData(14, "QUEDE", new DateTime(1996, 07, 19), "Brazil"),
				new SparklineGridData(15, "RATTC", new DateTime(1996, 07, 22), "USA"),
				new SparklineGridData(16, "ERNSH", new DateTime(1996, 07, 23), "Austria"),
				new SparklineGridData(17, "FOLKO", new DateTime(1996, 07, 24), "Sweden"),
				new SparklineGridData(18, "BLONP", new DateTime(1996, 07, 25), "France"),
				new SparklineGridData(19, "WARTH", new DateTime(1996, 07, 26), "France"),
				new SparklineGridData(20, "FRANK", new DateTime(1996, 07, 29), "Germany")
			};
        }
    }


}
