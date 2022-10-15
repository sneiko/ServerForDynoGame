using Microsoft.AspNetCore.Mvc;

namespace GameServer.API.Controllers;

public class LeaderboardController : ApiController
{
    public LeaderboardController(ILogger<LeaderboardController> logger) : base(logger)
    {
    }
}