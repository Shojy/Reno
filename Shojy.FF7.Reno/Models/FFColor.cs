using System.Runtime.InteropServices;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Explicit, Size = 0x3)]
public record struct FFColor
{
    [FieldOffset(0x0)] 
    public byte Red;

    [FieldOffset(0x1)] 
    public byte Green;

    [FieldOffset(0x2)] 
    public byte Blue;
}