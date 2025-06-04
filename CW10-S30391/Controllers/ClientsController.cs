using CW10_S30391.Exceptions;
using CW10_S30391.Services;
using Microsoft.AspNetCore.Mvc;

namespace CW10_S30391.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientsController(IDbService service) : ControllerBase
{
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteClient(int id)
    {
        try
        {
            await service.DeleteClientAsync(id);
            return NoContent();
        }
        catch (BadRequestException e)
        {
            return BadRequest(e.Message);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
}