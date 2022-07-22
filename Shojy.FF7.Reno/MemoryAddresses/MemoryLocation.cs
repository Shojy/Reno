using Shojy.FF7.Reno.MemoryAddresses.Offsets;

namespace Shojy.FF7.Reno.MemoryAddresses;

[PublicAPI]
public record struct MemoryLocation(IntPtr Address, int Length = 1);

[PublicAPI]
public static class MemoryLocations
{
    public static MemoryLocation SaveMap { get; } =
        new(new IntPtr(SaveMapOffsets.SaveMapStart), SaveMapOffsets.SaveMapLength);

    public static MemoryLocation BattleMap { get; } =
        new(new IntPtr(BattleMapOffsets.BattleMapStart), BattleMapOffsets.BattleMapLength);
}