using GameServer.Models.Entities.Enum;

namespace GameServer.Models.MongoDB.Entities;

public class BasePlayerEntity: BaseEntity
{
    public string Nickname { get; set; }
    public WarSideType WarSide { get; set; }
}