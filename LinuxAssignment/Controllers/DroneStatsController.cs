using LinuxAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinuxAssignment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DroneStatsController : ControllerBase
    {
        [HttpGet("yearly")]
        public IActionResult GetDroneStatisticYearly()
        {
            var curryear = 2023;
            var lastyear = 2000;
            var rand = new Random();
            var stats = new List<DroneCertStatisticYearly>();
            for (int i = curryear; i >= lastyear; i--)
            {
                stats.Add(new DroneCertStatisticYearly() { Year = i, NumberOfCert = rand.Next(5000, 20000) });
            }
            return Ok(stats);
        }
    }
}
