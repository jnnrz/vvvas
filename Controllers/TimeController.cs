using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace vvvas.Controllers
{
    [ApiController]
    public class TimeController : Controller
    {
        [HttpGet("/time")]
        public async Task<IActionResult> Time()
        {
            var vzTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Venezuela Standard Time");
            var nowTime = TimeZoneInfo.ConvertTime(DateTime.Now, vzTimeZoneInfo);
            
            var time = new
            {
                Time = nowTime.ToString(CultureInfo.CurrentCulture)
            };
            
            return await Task.Run(() => Ok(time));
        }
    }
}