using System.Runtime.InteropServices;
using Shojy.FF7.Reno.MemoryAddresses.Offsets;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Explicit, Size = MateriaOffsets.MateriaLength)]
public record struct MateriaRecord
{
    [FieldOffset(MateriaOffsets.Id)] 
    public byte Id;

    [FieldOffset(MateriaOffsets.AP)]
    public Int24 AP;
}