using System.Runtime.InteropServices;

namespace Shojy.FF7.Reno.Models;

[StructLayout(LayoutKind.Sequential, Size = 12)]
public readonly record struct CharacterName
{
    private readonly byte RawName1;
    private readonly byte RawName2;
    private readonly byte RawName3;
    private readonly byte RawName4;
    private readonly byte RawName5;
    private readonly byte RawName6;
    private readonly byte RawName7;
    private readonly byte RawName8;
    private readonly byte RawName9;
    private readonly byte RawName10;
    private readonly byte RawName11;
    private readonly byte RawName12;

    public byte[] RawName => new[]
    {
        RawName1,
        RawName2,
        RawName3,
        RawName4,
        RawName5,
        RawName6,
        RawName7,
        RawName8,
        RawName9,
        RawName10,
        RawName11,
        RawName12,
    };

    public string Name => RawName.ToFFString();
}