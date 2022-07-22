using Shojy.FF7.Reno.MemoryAddresses.Offsets;
using System.Runtime.InteropServices;

namespace Shojy.FF7.Reno.Models;

public readonly partial record struct SaveMap
{
    private const int MateriaSize = 4;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 0)]
    private readonly MateriaRecord Materia1;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 1)]
    private readonly MateriaRecord Materia2;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 2)]
    private readonly MateriaRecord Materia3;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 3)]
    private readonly MateriaRecord Materia4;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 4)]
    private readonly MateriaRecord Materia5;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 5)]
    private readonly MateriaRecord Materia6;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 6)]
    private readonly MateriaRecord Materia7;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 7)]
    private readonly MateriaRecord Materia8;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 8)]
    private readonly MateriaRecord Materia9;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 9)]
    private readonly MateriaRecord Materia10;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 10)]
    private readonly MateriaRecord Materia11;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 11)]
    private readonly MateriaRecord Materia12;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 12)]
    private readonly MateriaRecord Materia13;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 13)]
    private readonly MateriaRecord Materia14;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 14)]
    private readonly MateriaRecord Materia15;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 15)]
    private readonly MateriaRecord Materia16;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 16)]
    private readonly MateriaRecord Materia17;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 17)]
    private readonly MateriaRecord Materia18;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 18)]
    private readonly MateriaRecord Materia19;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 19)]
    private readonly MateriaRecord Materia20;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 20)]
    private readonly MateriaRecord Materia21;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 21)]
    private readonly MateriaRecord Materia22;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 22)]
    private readonly MateriaRecord Materia23;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 23)]
    private readonly MateriaRecord Materia24;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 24)]
    private readonly MateriaRecord Materia25;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 25)]
    private readonly MateriaRecord Materia26;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 26)]
    private readonly MateriaRecord Materia27;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 27)]
    private readonly MateriaRecord Materia28;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 28)]
    private readonly MateriaRecord Materia29;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 29)]
    private readonly MateriaRecord Materia30;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 30)]
    private readonly MateriaRecord Materia31;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 31)]
    private readonly MateriaRecord Materia32;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 32)]
    private readonly MateriaRecord Materia33;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 33)]
    private readonly MateriaRecord Materia34;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 34)]
    private readonly MateriaRecord Materia35;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 35)]
    private readonly MateriaRecord Materia36;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 36)]
    private readonly MateriaRecord Materia37;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 37)]
    private readonly MateriaRecord Materia38;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 38)]
    private readonly MateriaRecord Materia39;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 39)]
    private readonly MateriaRecord Materia40;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 40)]
    private readonly MateriaRecord Materia41;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 41)]
    private readonly MateriaRecord Materia42;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 42)]
    private readonly MateriaRecord Materia43;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 43)]
    private readonly MateriaRecord Materia44;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 44)]
    private readonly MateriaRecord Materia45;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 45)]
    private readonly MateriaRecord Materia46;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 46)]
    private readonly MateriaRecord Materia47;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 47)]
    private readonly MateriaRecord Materia48;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 48)]
    private readonly MateriaRecord Materia49;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 49)]
    private readonly MateriaRecord Materia50;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 50)]
    private readonly MateriaRecord Materia51;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 51)]
    private readonly MateriaRecord Materia52;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 52)]
    private readonly MateriaRecord Materia53;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 53)]
    private readonly MateriaRecord Materia54;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 54)]
    private readonly MateriaRecord Materia55;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 55)]
    private readonly MateriaRecord Materia56;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 56)]
    private readonly MateriaRecord Materia57;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 57)]
    private readonly MateriaRecord Materia58;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 58)]
    private readonly MateriaRecord Materia59;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 59)]
    private readonly MateriaRecord Materia60;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 60)]
    private readonly MateriaRecord Materia61;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 61)]
    private readonly MateriaRecord Materia62;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 62)]
    private readonly MateriaRecord Materia63;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 63)]
    private readonly MateriaRecord Materia64;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 64)]
    private readonly MateriaRecord Materia65;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 65)]
    private readonly MateriaRecord Materia66;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 66)]
    private readonly MateriaRecord Materia67;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 67)]
    private readonly MateriaRecord Materia68;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 68)]
    private readonly MateriaRecord Materia69;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 69)]
    private readonly MateriaRecord Materia70;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 70)]
    private readonly MateriaRecord Materia71;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 71)]
    private readonly MateriaRecord Materia72;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 72)]
    private readonly MateriaRecord Materia73;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 73)]
    private readonly MateriaRecord Materia74;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 74)]
    private readonly MateriaRecord Materia75;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 75)]
    private readonly MateriaRecord Materia76;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 76)]
    private readonly MateriaRecord Materia77;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 77)]
    private readonly MateriaRecord Materia78;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 78)]
    private readonly MateriaRecord Materia79;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 79)]
    private readonly MateriaRecord Materia80;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 80)]
    private readonly MateriaRecord Materia81;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 81)]
    private readonly MateriaRecord Materia82;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 82)]
    private readonly MateriaRecord Materia83;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 83)]
    private readonly MateriaRecord Materia84;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 84)]
    private readonly MateriaRecord Materia85;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 85)]
    private readonly MateriaRecord Materia86;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 86)]
    private readonly MateriaRecord Materia87;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 87)]
    private readonly MateriaRecord Materia88;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 88)]
    private readonly MateriaRecord Materia89;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 89)]
    private readonly MateriaRecord Materia90;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 90)]
    private readonly MateriaRecord Materia91;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 91)]
    private readonly MateriaRecord Materia92;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 92)]
    private readonly MateriaRecord Materia93;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 93)]
    private readonly MateriaRecord Materia94;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 94)]
    private readonly MateriaRecord Materia95;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 95)]
    private readonly MateriaRecord Materia96;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 96)]
    private readonly MateriaRecord Materia97;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 97)]
    private readonly MateriaRecord Materia98;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 98)]
    private readonly MateriaRecord Materia99;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 99)]
    private readonly MateriaRecord Materia100;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 100)]
    private readonly MateriaRecord Materia101;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 101)]
    private readonly MateriaRecord Materia102;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 102)]
    private readonly MateriaRecord Materia103;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 103)]
    private readonly MateriaRecord Materia104;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 104)]
    private readonly MateriaRecord Materia105;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 105)]
    private readonly MateriaRecord Materia106;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 106)]
    private readonly MateriaRecord Materia107;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 107)]
    private readonly MateriaRecord Materia108;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 108)]
    private readonly MateriaRecord Materia109;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 109)]
    private readonly MateriaRecord Materia110;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 110)]
    private readonly MateriaRecord Materia111;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 111)]
    private readonly MateriaRecord Materia112;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 112)]
    private readonly MateriaRecord Materia113;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 113)]
    private readonly MateriaRecord Materia114;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 114)]
    private readonly MateriaRecord Materia115;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 115)]
    private readonly MateriaRecord Materia116;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 116)]
    private readonly MateriaRecord Materia117;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 117)]
    private readonly MateriaRecord Materia118;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 118)]
    private readonly MateriaRecord Materia119;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 119)]
    private readonly MateriaRecord Materia120;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 120)]
    private readonly MateriaRecord Materia121;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 121)]
    private readonly MateriaRecord Materia122;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 122)]
    private readonly MateriaRecord Materia123;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 123)]
    private readonly MateriaRecord Materia124;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 124)]
    private readonly MateriaRecord Materia125;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 125)]
    private readonly MateriaRecord Materia126;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 126)]
    private readonly MateriaRecord Materia127;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 127)]
    private readonly MateriaRecord Materia128;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 128)]
    private readonly MateriaRecord Materia129;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 129)]
    private readonly MateriaRecord Materia130;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 130)]
    private readonly MateriaRecord Materia131;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 131)]
    private readonly MateriaRecord Materia132;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 132)]
    private readonly MateriaRecord Materia133;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 133)]
    private readonly MateriaRecord Materia134;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 134)]
    private readonly MateriaRecord Materia135;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 135)]
    private readonly MateriaRecord Materia136;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 136)]
    private readonly MateriaRecord Materia137;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 137)]
    private readonly MateriaRecord Materia138;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 138)]
    private readonly MateriaRecord Materia139;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 139)]
    private readonly MateriaRecord Materia140;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 140)]
    private readonly MateriaRecord Materia141;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 141)]
    private readonly MateriaRecord Materia142;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 142)]
    private readonly MateriaRecord Materia143;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 143)]
    private readonly MateriaRecord Materia144;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 144)]
    private readonly MateriaRecord Materia145;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 145)]
    private readonly MateriaRecord Materia146;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 146)]
    private readonly MateriaRecord Materia147;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 147)]
    private readonly MateriaRecord Materia148;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 148)]
    private readonly MateriaRecord Materia149;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 149)]
    private readonly MateriaRecord Materia150;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 150)]
    private readonly MateriaRecord Materia151;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 151)]
    private readonly MateriaRecord Materia152;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 152)]
    private readonly MateriaRecord Materia153;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 153)]
    private readonly MateriaRecord Materia154;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 154)]
    private readonly MateriaRecord Materia155;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 155)]
    private readonly MateriaRecord Materia156;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 156)]
    private readonly MateriaRecord Materia157;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 157)]
    private readonly MateriaRecord Materia158;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 158)]
    private readonly MateriaRecord Materia159;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 159)]
    private readonly MateriaRecord Materia160;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 160)]
    private readonly MateriaRecord Materia161;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 161)]
    private readonly MateriaRecord Materia162;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 162)]
    private readonly MateriaRecord Materia163;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 163)]
    private readonly MateriaRecord Materia164;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 164)]
    private readonly MateriaRecord Materia165;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 165)]
    private readonly MateriaRecord Materia166;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 166)]
    private readonly MateriaRecord Materia167;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 167)]
    private readonly MateriaRecord Materia168;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 168)]
    private readonly MateriaRecord Materia169;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 169)]
    private readonly MateriaRecord Materia170;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 170)]
    private readonly MateriaRecord Materia171;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 171)]
    private readonly MateriaRecord Materia172;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 172)]
    private readonly MateriaRecord Materia173;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 173)]
    private readonly MateriaRecord Materia174;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 174)]
    private readonly MateriaRecord Materia175;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 175)]
    private readonly MateriaRecord Materia176;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 176)]
    private readonly MateriaRecord Materia177;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 177)]
    private readonly MateriaRecord Materia178;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 178)]
    private readonly MateriaRecord Materia179;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 179)]
    private readonly MateriaRecord Materia180;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 180)]
    private readonly MateriaRecord Materia181;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 181)]
    private readonly MateriaRecord Materia182;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 182)]
    private readonly MateriaRecord Materia183;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 183)]
    private readonly MateriaRecord Materia184;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 184)]
    private readonly MateriaRecord Materia185;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 185)]
    private readonly MateriaRecord Materia186;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 186)]
    private readonly MateriaRecord Materia187;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 187)]
    private readonly MateriaRecord Materia188;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 188)]
    private readonly MateriaRecord Materia189;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 189)]
    private readonly MateriaRecord Materia190;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 190)]
    private readonly MateriaRecord Materia191;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 191)]
    private readonly MateriaRecord Materia192;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 192)]
    private readonly MateriaRecord Materia193;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 193)]
    private readonly MateriaRecord Materia194;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 194)]
    private readonly MateriaRecord Materia195;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 195)]
    private readonly MateriaRecord Materia196;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 196)]
    private readonly MateriaRecord Materia197;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 197)]
    private readonly MateriaRecord Materia198;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 198)]
    private readonly MateriaRecord Materia199;

    [FieldOffset(SaveMapOffsets.MateriaStock + MateriaSize * 199)]
    private readonly MateriaRecord Materia200;

    public MateriaRecord[] MateriaInventory => new[]
    {
        Materia1,
        Materia2,
        Materia3,
        Materia4,
        Materia5,
        Materia6,
        Materia7,
        Materia8,
        Materia9,
        Materia10,
        Materia11,
        Materia12,
        Materia13,
        Materia14,
        Materia15,
        Materia16,
        Materia17,
        Materia18,
        Materia19,
        Materia20,
        Materia21,
        Materia22,
        Materia23,
        Materia24,
        Materia25,
        Materia26,
        Materia27,
        Materia28,
        Materia29,
        Materia30,
        Materia31,
        Materia32,
        Materia33,
        Materia34,
        Materia35,
        Materia36,
        Materia37,
        Materia38,
        Materia39,
        Materia40,
        Materia41,
        Materia42,
        Materia43,
        Materia44,
        Materia45,
        Materia46,
        Materia47,
        Materia48,
        Materia49,
        Materia50,
        Materia51,
        Materia52,
        Materia53,
        Materia54,
        Materia55,
        Materia56,
        Materia57,
        Materia58,
        Materia59,
        Materia60,
        Materia61,
        Materia62,
        Materia63,
        Materia64,
        Materia65,
        Materia66,
        Materia67,
        Materia68,
        Materia69,
        Materia70,
        Materia71,
        Materia72,
        Materia73,
        Materia74,
        Materia75,
        Materia76,
        Materia77,
        Materia78,
        Materia79,
        Materia80,
        Materia81,
        Materia82,
        Materia83,
        Materia84,
        Materia85,
        Materia86,
        Materia87,
        Materia88,
        Materia89,
        Materia90,
        Materia91,
        Materia92,
        Materia93,
        Materia94,
        Materia95,
        Materia96,
        Materia97,
        Materia98,
        Materia99,
        Materia100,
        Materia101,
        Materia102,
        Materia103,
        Materia104,
        Materia105,
        Materia106,
        Materia107,
        Materia108,
        Materia109,
        Materia110,
        Materia111,
        Materia112,
        Materia113,
        Materia114,
        Materia115,
        Materia116,
        Materia117,
        Materia118,
        Materia119,
        Materia120,
        Materia121,
        Materia122,
        Materia123,
        Materia124,
        Materia125,
        Materia126,
        Materia127,
        Materia128,
        Materia129,
        Materia130,
        Materia131,
        Materia132,
        Materia133,
        Materia134,
        Materia135,
        Materia136,
        Materia137,
        Materia138,
        Materia139,
        Materia140,
        Materia141,
        Materia142,
        Materia143,
        Materia144,
        Materia145,
        Materia146,
        Materia147,
        Materia148,
        Materia149,
        Materia150,
        Materia151,
        Materia152,
        Materia153,
        Materia154,
        Materia155,
        Materia156,
        Materia157,
        Materia158,
        Materia159,
        Materia160,
        Materia161,
        Materia162,
        Materia163,
        Materia164,
        Materia165,
        Materia166,
        Materia167,
        Materia168,
        Materia169,
        Materia170,
        Materia171,
        Materia172,
        Materia173,
        Materia174,
        Materia175,
        Materia176,
        Materia177,
        Materia178,
        Materia179,
        Materia180,
        Materia181,
        Materia182,
        Materia183,
        Materia184,
        Materia185,
        Materia186,
        Materia187,
        Materia188,
        Materia189,
        Materia190,
        Materia191,
        Materia192,
        Materia193,
        Materia194,
        Materia195,
        Materia196,
        Materia197,
        Materia198,
        Materia199,
        Materia200,
    };

}