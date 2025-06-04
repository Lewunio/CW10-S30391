using CW10_S30391.Services;
using Microsoft.AspNetCore.Mvc;

namespace CW10_S30391.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TripsController(IDbService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTrips([FromQuery] int? page,[FromQuery] int pageSize = 10)
    {
        if (page == null)
        {
            var result = await service.GetTripsAsync();
            return Ok(result);
        }
        else
        {
            var result = await service.GetTripsPagedAsync((int)page, pageSize);
            return Ok(result);
        }
    }
}