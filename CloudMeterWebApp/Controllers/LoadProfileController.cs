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
                610, 595, 602, 603, // 0
                591, 593, 593, 601, // 1
                591, 590, 600, 600, // 2
                595, 603, 601, 600, // 3
                591, 592, 591, 593, // 4
                595, 603, 601, 600, // 5
                591, 590, 600, 600, // 6
                410, 0.0, 0.0, 0.0, // 7
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
                212, 601, 597, 598, // 20
                595, 603, 601, 600, // 21
                591, 593, 593, 601, // 22
                595, 603, 601, 600  // 23
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
                Label = "Stromverbrauch in Wh",
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