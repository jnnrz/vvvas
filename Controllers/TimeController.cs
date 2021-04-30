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
            var time = new
            {
                Time = DateTime.Now.ToString(CultureInfo.CurrentCulture)
            };
            
            return await Task.Run(() => Ok(time));
        }
    }
}