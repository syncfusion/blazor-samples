using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Syncfusion.Blazor;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using ej2_blazor_virtualdata;
using Microsoft.Extensions.Primitives;

namespace BlazorDemos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreeGridController : ControllerBase
    {
        public static List<SelfReferenceData> FlatData = new List<SelfReferenceData>();
        // GET: api/Default
        [HttpGet]
        public object Get(int? code)
        {
            FlatData.Clear();
            var queryString = Request.Query;
            if (SelfReferenceData.tree.Count == 0)
                SelfReferenceData.GetTree();
            DataRequest req = QueryGenerator(queryString);
            if (req.filter != "" && !req.filter.Contains("null"))
            {
                int fltr = Int32.Parse(req.filter.Split("eq")[1].Split(")")[0].Trim());
                IQueryable<SelfReferenceData> data1 = SelfReferenceData.tree.Where(f => f.ParentItem == fltr).AsQueryable();
                return new { result = data1.ToList(), items = data1.ToList(), count = data1.Count() };
            }
            List<SelfReferenceData> data = SelfReferenceData.tree.ToList();
            data = data.Where(p => p.ParentItem == null).ToList();
            int count = data.Count;
            if (req.inlinecount)
            {
                if (req.skip == null && req.take == null)
                    FlatData = data;
                else
                    FlatData = data.Skip((int)req.skip).Take((int)req.take).ToList();
                return new { result = FlatData, items = FlatData, count = count };
            }
            else
            {
                return SelfReferenceData.GetTree();
            }

        }

        public DataRequest QueryGenerator(IQueryCollection queryString)
        {
            DataRequest req = new DataRequest();
            StringValues Skip;
            StringValues Take;
            StringValues filter;
            req.skip = queryString.TryGetValue("$skip", out Skip) ? Convert.ToInt32(Skip[0]) : (Nullable<int>)null;
            req.take = (queryString.TryGetValue("$top", out Take)) ? Convert.ToInt32(Take[0]) : (Nullable<int>)null;
            req.filter = queryString.TryGetValue("$filter", out filter) ? filter[0].ToString() : "";
            req.inlinecount = queryString.Keys.Contains("$inlinecount") ? true : false;
            return req;
        }

    }



    public class DataRequest
    {
        public Nullable<int> skip { get; set; }
        public Nullable<int> take { get; set; }
        public Boolean inlinecount { get; set; }
        public string filter { get; set; }
    }
}
