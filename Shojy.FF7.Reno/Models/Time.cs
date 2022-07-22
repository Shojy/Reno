using System.Runtime.InteropServices;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Explicit, Size = 3)]
public record struct Time
{
    [FieldOffset(0x0)]
    public byte Hours;

    [FieldOffset(0x2)]
    public byte Minutes;

    [FieldOffset(0x3)]
    public byte Seconds;
}