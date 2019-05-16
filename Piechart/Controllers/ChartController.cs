using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Piechart.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BarChart()
        {
            var result = new List<GenderPopulation>()
            {
                new GenderPopulation(){Male = 100,Female=8,Others = 0,MonthYr = "January",Country = "BD"},
                new GenderPopulation(){Male = 30,Female=25,Others = 5,MonthYr = "February",Country = "BD"},
                new GenderPopulation(){Male = 30,Female=25,Others = 5,MonthYr = "March",Country = "BD"},
                new GenderPopulation(){Male = 30,Female=10,Others = 2,MonthYr = "April",Country = "BD"},
                new GenderPopulation(){Male = 70,Female=40,Others = 22,MonthYr = "May",Country = "BD"},
                new GenderPopulation(){Male = 50,Female=5,Others = 1,MonthYr = "Jun",Country = "USA"},
                new GenderPopulation(){Male = 10000,Female=8,Others = 0,MonthYr = "July",Country = "BD"},
                new GenderPopulation(){Male = 30,Female=10,Others = 2,MonthYr = "August",Country = "BD"},
                new GenderPopulation(){Male = 70,Female=40,Others = 22,MonthYr = "September",Country = "BD"},
                new GenderPopulation(){Male = 50,Female=5,Others = 1,MonthYr = "October",Country = "USA"},
                new GenderPopulation(){Male = 100,Female=8,Others = 0,MonthYr = "November",Country = "BD"},
                new GenderPopulation(){Male = 30,Female=25,Others = 5,MonthYr = "December",Country = "BD"}
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public class GenderPopulation
        {
            public Nullable<double> Male { get; set; }
            public Nullable<double> Female { get; set; }
            public Nullable<double> Others { get; set; }
            public string Country { get; set; }
            public string MonthYr { get; set; }
        }
    }
}