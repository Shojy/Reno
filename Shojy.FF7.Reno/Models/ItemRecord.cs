using System.Runtime.InteropServices;
using Shojy.FF7.Reno.Models.Enums;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Sequential)]
public readonly record struct ItemRecord
{
    private readonly ushort _bytes;

    public ushort ItemId => (ushort) (_bytes & 0b0000_0001_1111_1111);

    public ushort Quantity => (ushort) ((_bytes & 0b1111_1110_0000_0000) >> 9);

    public ushort TypeId => ItemType switch
    {
        ItemType.Item      => ItemId,
        ItemType.Weapon    => (ushort)(ItemId - 128),
        ItemType.Armor     => (ushort)(ItemId - 256),
        ItemType.Accessory => (ushort)(ItemId - 288),
        _ => ItemId
    };

    public ItemType ItemType => ItemId switch
    {
        <128 => ItemType.Item,
        <256 => ItemType.Weapon,
        <288 => ItemType.Armor,
        <320 => ItemType.Accessory,
        _ => ItemType.Item

    };
}