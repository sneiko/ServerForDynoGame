namespace GameServer.Models.MongoDB.Entities;

public class Score: BasePlayerEntity
{
    public DateTime ScoreDate { get; set; }
    public int Value { get; set; }
}