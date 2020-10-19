using System;
using Microsoft.AspNetCore.Mvc;

namespace CloudMeterWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoadProfileController : Controller
    {
        // GET
        [Route("")]
        public ActionResult<LoadProfile> Index(DateTime date)
        {
            var values = new []
            {
                0.6, 0.6, 0.6, 0.6, // 0
                0.6, 0.6, 0.6, 0.6, // 1
                0.6, 0.6, 0.6, 0.6, // 2
                0.6, 0.6, 0.6, 0.6, // 3
                0.6, 0.6, 0.6, 0.6, // 4
                0.6, 0.6, 0.6, 0.6, // 5
                0.6, 0.6, 0.6, 0.6, // 6
                0.4, 0.0, 0.0, 0.0, // 7
                0.0, 0.0, 0.0, 0.0, // 8
                0.0, 0.0, 0.0, 0.0, // 9
                0.0, 0.0, 0.0, 0.0, // 10
                0.0, 0.0, 0.0, 0.0, // 11
                0.0, 0.0, 0.0, 0.0, // 12
                0.0, 0.0, 0.0, 0.0, // 13
                0.0, 0.0, 0.0, 0.0, // 14
                0.0, 0.0, 0.0, 0.0, // 15
                0.0, 0.0, 0.0, 0.0, // 16
                0.0, 0.0, 0.0, 0.0, // 17
                0.0, 0.0, 0.0, 0.0, // 18
                0.0, 0.0, 0.0, 0.0, // 19
                0.2, 0.6, 0.6, 0.6, // 20
                0.6, 0.6, 0.6, 0.6, // 21
                0.6, 0.6, 0.6, 0.6, // 22
                0.6, 0.6, 0.6, 0.6, // 23
            };
            var data = new LoadProfileValue[96];
            for(var i = 0; i<96; i+=1)
            {
                data[i] = new LoadProfileValue
                {
                    Y =values[i],
                    X = date.AddMinutes(i * 15)
                };
            }
            return new LoadProfile
            {
                Label = "Stromverbrauch in kWh",
                Data = data 
            };
        }
    }

    public class LoadProfileValue
    {
        public double Y { get; set; }
        public DateTime X { get; set; }
    }

    public class LoadProfile
    {
        public string Label { get; set; }
        public LoadProfileValue[] Data { get; set; }
    }
}