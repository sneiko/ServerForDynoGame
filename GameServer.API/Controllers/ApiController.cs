using Microsoft.AspNetCore.Mvc;

namespace GameServer.API.Controllers;

[ApiController]
[Route("/api")]
public class ApiController: ControllerBase
{
    private readonly ILogger<ApiController> _logger;

    public ApiController(ILogger<LeaderboardController> logger)
    {
        _logger = logger;
    }
}