using System.Runtime.InteropServices;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Sequential)]
public readonly record struct Int24
{
    private readonly byte B1;
    private readonly byte B2;
    private readonly byte B3;

    public int Int32 => (B1 << 0) + (B2 << 8) + (B3 << 16);

    public const int MaxValue = 0xFFFFFF;
    public const int MinValue = 0;
}