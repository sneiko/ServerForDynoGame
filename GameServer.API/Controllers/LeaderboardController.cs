using GameServer.Models;
using GameServer.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GameServer.API.Controllers;


[Route("[controller]")]
public class LeaderboardController : ApiController
{
    private readonly IUnitOfWork _unitOfWork;

    public LeaderboardController(ILogger<LeaderboardController> logger, IUnitOfWork unitOfWork) : base(logger)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpPost]
    [Route("add")]
    public async Task<IActionResult> Add(IScore score, CancellationToken cancellationToken)
    {
        await _unitOfWork.Scores.Insert(score, cancellationToken);
        return Ok();
    }
}