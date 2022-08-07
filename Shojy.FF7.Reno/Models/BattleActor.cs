using System.Runtime.InteropServices;
using Shojy.FF7.Reno.MemoryAddresses.Offsets;
using Shojy.FF7.Reno.Models.Enums;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Explicit, Size = BattleMapActorOffsets.ActorLength)]
public record struct BattleActor
{
    [FieldOffset(BattleMapActorOffsets.Status)]
    public StatusEffects Status;

    [FieldOffset(BattleMapActorOffsets.Row)]
    public byte Row;

    [FieldOffset(BattleMapActorOffsets.Level)]
    public byte Level;

    [FieldOffset(BattleMapActorOffsets.CurrentMp)]
    public ushort CurrentMp;

    [FieldOffset(BattleMapActorOffsets.MaxMp)]
    public ushort MaxMp;

    [FieldOffset(BattleMapActorOffsets.CurrentHp)]
    public uint CurrentHp;

    [FieldOffset(BattleMapActorOffsets.MaxHp)]
    public uint MaxHp;

    public bool IsBackRow => (Row & 0x40) == 0x40;

    public bool IsOutOfCombat => (Status & OutOfCombatStatuses) > 0 || CurrentHp == 0;

    private static readonly StatusEffects OutOfCombatStatuses = StatusEffects.Death | StatusEffects.Petrify | StatusEffects.Imprisoned;
}