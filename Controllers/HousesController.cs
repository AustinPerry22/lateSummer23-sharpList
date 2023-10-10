using server.Models;
using server.Services;
namespace server.Controllers;

[ApiController]
[Route("api/houses")]

public class HousesController : ControllerBase
{
    private readonly HousesService _housesService;

    public HousesController(HousesService housesService)
    {
        _housesService = housesService;
    }
}