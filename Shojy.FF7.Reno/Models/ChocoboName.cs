using System.Runtime.InteropServices;

namespace Shojy.FF7.Reno.Models;

[StructLayout(LayoutKind.Sequential, Size = 6)]
public readonly record struct ChocoboName
{
    private readonly byte RawName1;
    private readonly byte RawName2;
    private readonly byte RawName3;
    private readonly byte RawName4;
    private readonly byte RawName5;
    private readonly byte RawName6;

    public byte[] RawName => new[]
    {
        RawName1,
        RawName2,
        RawName3,
        RawName4,
        RawName5,
        RawName6,
    };

    public string Name => RawName.ToFFString();
}