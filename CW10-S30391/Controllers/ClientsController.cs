using CW10_S30391.Services;
using Microsoft.AspNetCore.Mvc;

namespace CW10_S30391.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientsController(IDbService service) : ControllerBase
{
    
}