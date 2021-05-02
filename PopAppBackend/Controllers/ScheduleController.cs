using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PopAppBackend.Controllers
{
    [Route("api/schedule")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDateResult()
        {
            try
            {
                var currentDate = DateTime.Now;
                var weekDate = currentDate.AddDays(7);
                return Ok(new
                {
                    CurrentDate = currentDate,
                    OtherDate = weekDate
                }) ;
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
