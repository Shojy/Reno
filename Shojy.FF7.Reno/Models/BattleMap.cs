using System.Runtime.InteropServices;
using Shojy.FF7.Reno.MemoryAddresses.Offsets;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Explicit)]
public record struct BattleMap
{
    [FieldOffset(BattleMapOffsets.EnemyActor1)]
    public BattleActor Opponent1;

    [FieldOffset(BattleMapOffsets.EnemyActor2)]
    public BattleActor Opponent2;

    [FieldOffset(BattleMapOffsets.EnemyActor3)]
    public BattleActor Opponent3; 

    [FieldOffset(BattleMapOffsets.EnemyActor4)]
    public BattleActor Opponent4;

    [FieldOffset(BattleMapOffsets.EnemyActor5)]
    public BattleActor Opponent5;

    [FieldOffset(BattleMapOffsets.EnemyActor6)]
    public BattleActor Opponent6;

    [FieldOffset(BattleMapOffsets.PartyActor1)]
    public BattleActor Party1;

    [FieldOffset(BattleMapOffsets.PartyActor2)]
    public BattleActor Party2;

    [FieldOffset(BattleMapOffsets.PartyActor3)]
    public BattleActor Party3;

    [FieldOffset(BattleMapOffsets.PartyActor4)]
    public BattleActor Party4;
}