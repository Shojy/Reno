﻿// ReSharper disable InconsistentNaming
namespace Shojy.FF7.Reno.Models.Enums;

[PublicAPI]
[Flags]
public enum KeyItems : ulong
{
    // Names used here are default english names. While only 51 items exist in-game, the kernel has
    // space for all 64 items, so the remaining slots are listed for mod compatibility. An ID lookup
    // will be made that can be cross-referenced with kernel data for valid names.

    CottonDress           = 0x1UL <<  0,
    SatinDress            = 0x1UL <<  1,
    SilkDress             = 0x1UL <<  2,
    Wig                   = 0x1UL <<  3,
    DyedWig               = 0x1UL <<  4,
    BlondeWig             = 0x1UL <<  5,
    GlassTiara            = 0x1UL <<  6,
    RubyTiara             = 0x1UL <<  7,
    DiamondTiara          = 0x1UL <<  8,
    Cologne               = 0x1UL <<  9,
    FlowerCologne         = 0x1UL << 10,
    SexyCologne           = 0x1UL << 11,
    MembersCard           = 0x1UL << 12,
    Lingerie              = 0x1UL << 13,
    MysteryPanties        = 0x1UL << 14,
    BikiniBriefs          = 0x1UL << 15,
    PharmacyCoupon        = 0x1UL << 16,
    Disinfectant          = 0x1UL << 17,
    Deodorant             = 0x1UL << 18,
    Digestive             = 0x1UL << 19,
    HugeMateriaFortCondor = 0x1UL << 20,
    HugeMateriaCorel      = 0x1UL << 21,
    HugeMateriaUnderwater = 0x1UL << 22,
    HugeMateriaRocket     = 0x1UL << 23,
    KeyToAncients         = 0x1UL << 24,
    LetterToADaughter     = 0x1UL << 25,
    LetterToAWife         = 0x1UL << 26,
    LunarHarp             = 0x1UL << 27,
    BasementKey           = 0x1UL << 28,
    KeyToSector5          = 0x1UL << 29,
    Keycard60             = 0x1UL << 30,
    Keycard62             = 0x1UL << 31,
    Keycard65             = 0x1UL << 32,
    Keycard66             = 0x1UL << 33,
    Keycard68             = 0x1UL << 34,
    MidgarParts1          = 0x1UL << 35,
    MidgarParts2          = 0x1UL << 36,
    MidgarParts3          = 0x1UL << 37,
    MidgarParts4          = 0x1UL << 38,
    MidgarParts5          = 0x1UL << 39,
    PHS                   = 0x1UL << 40,
    GoldTicket            = 0x1UL << 41,
    Keystone              = 0x1UL << 42,
    LeviathanScales       = 0x1UL << 43,
    GlacierMap            = 0x1UL << 44,
    ACoupon               = 0x1UL << 45,
    BCoupon               = 0x1UL << 46,
    CCoupon               = 0x1UL << 47,
    BlackMateria          = 0x1UL << 48,
    Mythril               = 0x1UL << 49,
    Snowboard             = 0x1UL << 50,
    KeyItem52             = 0x1UL << 51,
    KeyItem53             = 0x1UL << 52,
    KeyItem54             = 0x1UL << 53,
    KeyItem55             = 0x1UL << 54,
    KeyItem56             = 0x1UL << 55,
    KeyItem57             = 0x1UL << 56,
    KeyItem58             = 0x1UL << 57,
    KeyItem59             = 0x1UL << 58,
    KeyItem60             = 0x1UL << 59,
    KeyItem61             = 0x1UL << 60,
    KeyItem62             = 0x1UL << 61,
    KeyItem63             = 0x1UL << 62,
    KeyItem64             = 0x1UL << 63,
}