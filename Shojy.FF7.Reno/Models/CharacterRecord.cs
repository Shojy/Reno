using System.Runtime.InteropServices;
using Shojy.FF7.Reno.MemoryAddresses.Offsets;
using Shojy.FF7.Reno.Models.Enums;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Explicit, Size = CharacterOffsets.CharacterLength)]
public struct CharacterRecord
{
    [FieldOffset(CharacterOffsets.CharacterId)]
    public readonly byte Id;

    [FieldOffset(CharacterOffsets.Level)] 
    public readonly byte Level;

    [FieldOffset(CharacterOffsets.Strength)] 
    public readonly byte Strength;
    [FieldOffset(CharacterOffsets.Vitality)] 
    public readonly byte Vitality;
    [FieldOffset(CharacterOffsets.Magic)] 
    public readonly byte Magic;
    [FieldOffset(CharacterOffsets.Spirit)] 
    public readonly byte Spirit;
    [FieldOffset(CharacterOffsets.Dexterity)] 
    public readonly byte Dexterity;
    [FieldOffset(CharacterOffsets.Luck)] 
    public readonly byte Luck;

    [FieldOffset(CharacterOffsets.StrengthBonus)] 
    public readonly byte StrengthBonus;
    [FieldOffset(CharacterOffsets.VitalityBonus)] 
    public readonly byte VitalityBonus;
    [FieldOffset(CharacterOffsets.MagicBonus)] 
    public readonly byte MagicBonus;
    [FieldOffset(CharacterOffsets.SpiritBonus)] 
    public readonly byte SpiritBonus;
    [FieldOffset(CharacterOffsets.DexterityBonus)] 
    public readonly byte DexterityBonus;
    [FieldOffset(CharacterOffsets.LuckBonus)] 
    public readonly byte LuckBonus;

    [FieldOffset(CharacterOffsets.LimitLevel)]
    public readonly byte LimitLevel;
    [FieldOffset(CharacterOffsets.LimitGauge)]
    public readonly byte LimitBar;

    [FieldOffset(CharacterOffsets.Name)]
    public readonly CharacterName Name;

    [FieldOffset(CharacterOffsets.EquippedWeapon)]
    public readonly byte Weapon;
    [FieldOffset(CharacterOffsets.EquippedArmor)]
    public readonly byte Armor;
    [FieldOffset(CharacterOffsets.EquippedAccessory)]
    public readonly byte Accessory;
    [FieldOffset(CharacterOffsets.StatusFlags)]
    public readonly byte Flags;

    [FieldOffset(CharacterOffsets.Row)] 
    public readonly byte Row;
    [FieldOffset(CharacterOffsets.LevelProgress)] 
    public readonly byte LevelProgress;
    [FieldOffset(CharacterOffsets.LimitBreaks)] 
    public readonly LimitBreaksLearned LimitMask;
    [FieldOffset(CharacterOffsets.NumberOfKills)] 
    public readonly ushort Kills;
    [FieldOffset(CharacterOffsets.LimitLevel1Uses)] 
    public readonly ushort LimitLevel1Uses;
    [FieldOffset(CharacterOffsets.LimitLevel2Uses)] 
    public readonly ushort LimitLevel2Uses;
    [FieldOffset(CharacterOffsets.LimitLevel3Uses)] 
    public readonly ushort LimitLevel3Uses;
    [FieldOffset(CharacterOffsets.CurrentHp)] 
    public readonly ushort CurrentHp;
    [FieldOffset(CharacterOffsets.BaseHp)] 
    public readonly ushort BaseHp;

    [FieldOffset(CharacterOffsets.CurrentMp)] 
    public readonly ushort CurrentMp;
    [FieldOffset(CharacterOffsets.BaseMp)] 
    public readonly ushort BaseMp;
    [FieldOffset(CharacterOffsets.MaxHp)] 
    public readonly ushort MaxHp;
    [FieldOffset(CharacterOffsets.MaxMp)] 
    public readonly ushort MaxMp;
    [FieldOffset(CharacterOffsets.CurrentExp)] 
    public readonly int Experience;

    [FieldOffset(CharacterOffsets.WeaponMateria1)] 
    public readonly MateriaRecord WeaponMateria1;
    [FieldOffset(CharacterOffsets.WeaponMateria2)] 
    public readonly MateriaRecord WeaponMateria2;
    [FieldOffset(CharacterOffsets.WeaponMateria3)] 
    public readonly MateriaRecord WeaponMateria3;
    [FieldOffset(CharacterOffsets.WeaponMateria4)] 
    public readonly MateriaRecord WeaponMateria4;
    [FieldOffset(CharacterOffsets.WeaponMateria5)] 
    public readonly MateriaRecord WeaponMateria5;
    [FieldOffset(CharacterOffsets.WeaponMateria6)] 
    public readonly MateriaRecord WeaponMateria6;
    [FieldOffset(CharacterOffsets.WeaponMateria7)] 
    public readonly MateriaRecord WeaponMateria7;
    [FieldOffset(CharacterOffsets.WeaponMateria8)] 
    public readonly MateriaRecord WeaponMateria8;

    [FieldOffset(CharacterOffsets.ArmorMateria1)] 
    public readonly MateriaRecord ArmorMateria1;
    [FieldOffset(CharacterOffsets.ArmorMateria2)] 
    public readonly MateriaRecord ArmorMateria2;
    [FieldOffset(CharacterOffsets.ArmorMateria3)] 
    public readonly MateriaRecord ArmorMateria3;
    [FieldOffset(CharacterOffsets.ArmorMateria4)] 
    public readonly MateriaRecord ArmorMateria4;
    [FieldOffset(CharacterOffsets.ArmorMateria5)] 
    public readonly MateriaRecord ArmorMateria5;
    [FieldOffset(CharacterOffsets.ArmorMateria6)] 
    public readonly MateriaRecord ArmorMateria6;
    [FieldOffset(CharacterOffsets.ArmorMateria7)] 
    public readonly MateriaRecord ArmorMateria7;
    [FieldOffset(CharacterOffsets.ArmorMateria8)] 
    public readonly MateriaRecord ArmorMateria8;

    [FieldOffset(CharacterOffsets.ExpToNextLevel)] 
    public readonly uint ExpToLevel;


    public MateriaRecord[] ArmorMateria => new[]
    {
        ArmorMateria1,
        ArmorMateria2,
        ArmorMateria3,
        ArmorMateria4,
        ArmorMateria5,
        ArmorMateria6,
        ArmorMateria7,
        ArmorMateria8,
    };
    public MateriaRecord[] WeaponMateria => new[]
    {
        WeaponMateria1,
        WeaponMateria2,
        WeaponMateria3,
        WeaponMateria4,
        WeaponMateria5,
        WeaponMateria6,
        WeaponMateria7,
        WeaponMateria8,
    };
}