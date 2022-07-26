﻿namespace Shojy.FF7.Reno.MemoryAddresses.Offsets;

[PublicAPI]
public static class BattleMapActorOffsets
{
    public const int ActorLength = 0x68;

    public const int Status    =  0x0;
    public const int Row       =  0x4;
    public const int Level     =  0x9;
    public const int CurrentMp = 0x28;
    public const int MaxMp     = 0x2A;
    public const int CurrentHp = 0x2C;
    public const int MaxHp     = 0x30;
}