using Microsoft.AspNetCore.Mvc;

namespace GameServer.API.Controllers;

[ApiController]
public class ApiController: ControllerBase
{
    private readonly ILogger<ApiController> _logger;

    public ApiController(ILogger<LeaderboardController> logger)
    {
        _logger = logger;
    }
}