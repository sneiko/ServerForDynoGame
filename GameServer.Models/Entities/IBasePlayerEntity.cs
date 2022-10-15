using GameServer.Models.Entities.Enum;

namespace GameServer.Models.Entities;

public interface IBasePlayerEntity: IBaseEntity
{
    string Nickname { get; set; }
    WarSideType WarSide { get; set; }
}