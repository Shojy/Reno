namespace Shojy.FF7.Reno.Models.Enums;

[PublicAPI]
[Flags]
public enum LimitBreaksLearned : ushort
{
    Limit11 = 0x001,
    Limit12 = 0x002,
    Limit21 = 0x008,
    Limit22 = 0x010,
    Limit31 = 0x040,
    Limit32 = 0x080,
    Limit4  = 0x200
}