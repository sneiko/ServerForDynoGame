namespace GameServer.Models.Entities;

public interface IScore: IBasePlayerEntity
{
    DateTime ScoreDate { get; set; }
    int Value { get; set; }
}