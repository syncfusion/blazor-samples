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

		public string name { get; set; }
		public int id1 { get; set; }
		public int id2 { get; set; }
		public static List<SparkGridData> GetAllRecords()
		{
			List<SparkGridData> spark = new List<SparkGridData>();
			spark.Add(new SparkGridData("Product A", 1, 1));
			spark.Add(new SparkGridData("Product B", 2, 2));
			spark.Add(new SparkGridData("Product C", 3, 3));
			spark.Add(new SparkGridData("Product D", 4, 4));
			spark.Add(new SparkGridData("Product E", 5, 5));
			return spark;
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
		public string name { get; set; }
		public DateTime orderdate { get; set; }
		public string shipcountry { get; set; }

		public static List<SparklineGridData> GetAllRecords()
		{
			List<SparklineGridData> spark = new List<SparklineGridData>();
			spark.Add(new SparklineGridData( 1, "VINET", new DateTime(1996,07,04), "France"));
			spark.Add(new SparklineGridData(2, "TOMSP", new DateTime(1996, 07, 05), "Germany"));
			spark.Add(new SparklineGridData(3, "HANAR", new DateTime(1996, 07, 08), "Brazil"));
			spark.Add(new SparklineGridData(4, "VICTE", new DateTime(1996, 07, 08), "France"));
			spark.Add(new SparklineGridData(5, "SUPRD", new DateTime(1996, 07, 09), "Belgium"));
			spark.Add(new SparklineGridData(6, "HANAR", new DateTime(1996, 07, 10), "Brazil"));
			spark.Add(new SparklineGridData(7, "CHOPS", new DateTime(1996, 07, 11), "Switzerland"));
			spark.Add(new SparklineGridData(8, "RICSU", new DateTime(1996, 07, 12), "Switzerland"));
			spark.Add(new SparklineGridData(9, "WELLI", new DateTime(1996, 07, 15), "Brazil"));
			spark.Add(new SparklineGridData(10, "HILAA", new DateTime(1996, 07, 16), "Venezuela"));
			spark.Add(new SparklineGridData(11, "ERNSH", new DateTime(1996, 07, 17), "Austria"));
			spark.Add(new SparklineGridData(12, "CENTC", new DateTime(1996, 07, 18), "Mexico"));
			spark.Add(new SparklineGridData(13, "OTTIK", new DateTime(1996, 07, 19), "Germany"));
			spark.Add(new SparklineGridData(14, "QUEDE", new DateTime(1996, 07, 19), "Brazil"));
			spark.Add(new SparklineGridData(15, "RATTC", new DateTime(1996, 07, 22), "USA"));
			spark.Add(new SparklineGridData(16, "ERNSH", new DateTime(1996, 07, 23), "Austria"));
			spark.Add(new SparklineGridData(17, "FOLKO", new DateTime(1996, 07, 24), "Sweden"));
			spark.Add(new SparklineGridData(18, "BLONP", new DateTime(1996, 07, 25), "France"));
			spark.Add(new SparklineGridData(19, "WARTH", new DateTime(1996, 07, 26), "France"));
			spark.Add(new SparklineGridData(20, "FRANK", new DateTime(1996, 07, 29), "Germany"));
			return spark;
		}
	}


}
