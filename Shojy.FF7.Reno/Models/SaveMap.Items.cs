using System.Runtime.InteropServices;
using Shojy.FF7.Reno.MemoryAddresses.Offsets;

namespace Shojy.FF7.Reno.Models;

public readonly partial record struct SaveMap
{
    private const int ItemSize = 2;
    // It would be nice to handle these as an array, but that doesn't seem to want to work yet.
    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 0)]
    private readonly ItemRecord Item1;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 1)]
    private readonly ItemRecord Item2;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 2)]
    private readonly ItemRecord Item3;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 3)]
    private readonly ItemRecord Item4;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 4)]
    private readonly ItemRecord Item5;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 5)]
    private readonly ItemRecord Item6;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 6)]
    private readonly ItemRecord Item7;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 7)]
    private readonly ItemRecord Item8;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 8)]
    private readonly ItemRecord Item9;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 9)]
    private readonly ItemRecord Item10;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 10)]
    private readonly ItemRecord Item11;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 11)]
    private readonly ItemRecord Item12;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 12)]
    private readonly ItemRecord Item13;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 13)]
    private readonly ItemRecord Item14;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 14)]
    private readonly ItemRecord Item15;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 15)]
    private readonly ItemRecord Item16;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 16)]
    private readonly ItemRecord Item17;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 17)]
    private readonly ItemRecord Item18;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 18)]
    private readonly ItemRecord Item19;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 19)]
    private readonly ItemRecord Item20;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 20)]
    private readonly ItemRecord Item21;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 21)]
    private readonly ItemRecord Item22;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 22)]
    private readonly ItemRecord Item23;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 23)]
    private readonly ItemRecord Item24;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 24)]
    private readonly ItemRecord Item25;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 25)]
    private readonly ItemRecord Item26;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 26)]
    private readonly ItemRecord Item27;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 27)]
    private readonly ItemRecord Item28;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 28)]
    private readonly ItemRecord Item29;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 29)]
    private readonly ItemRecord Item30;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 30)]
    private readonly ItemRecord Item31;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 31)]
    private readonly ItemRecord Item32;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 32)]
    private readonly ItemRecord Item33;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 33)]
    private readonly ItemRecord Item34;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 34)]
    private readonly ItemRecord Item35;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 35)]
    private readonly ItemRecord Item36;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 36)]
    private readonly ItemRecord Item37;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 37)]
    private readonly ItemRecord Item38;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 38)]
    private readonly ItemRecord Item39;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 39)]
    private readonly ItemRecord Item40;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 40)]
    private readonly ItemRecord Item41;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 41)]
    private readonly ItemRecord Item42;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 42)]
    private readonly ItemRecord Item43;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 43)]
    private readonly ItemRecord Item44;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 44)]
    private readonly ItemRecord Item45;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 45)]
    private readonly ItemRecord Item46;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 46)]
    private readonly ItemRecord Item47;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 47)]
    private readonly ItemRecord Item48;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 48)]
    private readonly ItemRecord Item49;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 49)]
    private readonly ItemRecord Item50;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 50)]
    private readonly ItemRecord Item51;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 51)]
    private readonly ItemRecord Item52;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 52)]
    private readonly ItemRecord Item53;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 53)]
    private readonly ItemRecord Item54;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 54)]
    private readonly ItemRecord Item55;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 55)]
    private readonly ItemRecord Item56;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 56)]
    private readonly ItemRecord Item57;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 57)]
    private readonly ItemRecord Item58;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 58)]
    private readonly ItemRecord Item59;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 59)]
    private readonly ItemRecord Item60;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 60)]
    private readonly ItemRecord Item61;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 61)]
    private readonly ItemRecord Item62;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 62)]
    private readonly ItemRecord Item63;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 63)]
    private readonly ItemRecord Item64;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 64)]
    private readonly ItemRecord Item65;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 65)]
    private readonly ItemRecord Item66;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 66)]
    private readonly ItemRecord Item67;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 67)]
    private readonly ItemRecord Item68;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 68)]
    private readonly ItemRecord Item69;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 69)]
    private readonly ItemRecord Item70;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 70)]
    private readonly ItemRecord Item71;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 71)]
    private readonly ItemRecord Item72;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 72)]
    private readonly ItemRecord Item73;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 73)]
    private readonly ItemRecord Item74;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 74)]
    private readonly ItemRecord Item75;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 75)]
    private readonly ItemRecord Item76;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 76)]
    private readonly ItemRecord Item77;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 77)]
    private readonly ItemRecord Item78;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 78)]
    private readonly ItemRecord Item79;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 79)]
    private readonly ItemRecord Item80;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 80)]
    private readonly ItemRecord Item81;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 81)]
    private readonly ItemRecord Item82;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 82)]
    private readonly ItemRecord Item83;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 83)]
    private readonly ItemRecord Item84;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 84)]
    private readonly ItemRecord Item85;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 85)]
    private readonly ItemRecord Item86;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 86)]
    private readonly ItemRecord Item87;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 87)]
    private readonly ItemRecord Item88;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 88)]
    private readonly ItemRecord Item89;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 89)]
    private readonly ItemRecord Item90;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 90)]
    private readonly ItemRecord Item91;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 91)]
    private readonly ItemRecord Item92;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 92)]
    private readonly ItemRecord Item93;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 93)]
    private readonly ItemRecord Item94;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 94)]
    private readonly ItemRecord Item95;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 95)]
    private readonly ItemRecord Item96;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 96)]
    private readonly ItemRecord Item97;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 97)]
    private readonly ItemRecord Item98;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 98)]
    private readonly ItemRecord Item99;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 99)]
    private readonly ItemRecord Item100;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 100)]
    private readonly ItemRecord Item101;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 101)]
    private readonly ItemRecord Item102;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 102)]
    private readonly ItemRecord Item103;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 103)]
    private readonly ItemRecord Item104;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 104)]
    private readonly ItemRecord Item105;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 105)]
    private readonly ItemRecord Item106;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 106)]
    private readonly ItemRecord Item107;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 107)]
    private readonly ItemRecord Item108;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 108)]
    private readonly ItemRecord Item109;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 109)]
    private readonly ItemRecord Item110;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 110)]
    private readonly ItemRecord Item111;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 111)]
    private readonly ItemRecord Item112;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 112)]
    private readonly ItemRecord Item113;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 113)]
    private readonly ItemRecord Item114;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 114)]
    private readonly ItemRecord Item115;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 115)]
    private readonly ItemRecord Item116;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 116)]
    private readonly ItemRecord Item117;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 117)]
    private readonly ItemRecord Item118;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 118)]
    private readonly ItemRecord Item119;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 119)]
    private readonly ItemRecord Item120;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 120)]
    private readonly ItemRecord Item121;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 121)]
    private readonly ItemRecord Item122;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 122)]
    private readonly ItemRecord Item123;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 123)]
    private readonly ItemRecord Item124;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 124)]
    private readonly ItemRecord Item125;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 125)]
    private readonly ItemRecord Item126;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 126)]
    private readonly ItemRecord Item127;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 127)]
    private readonly ItemRecord Item128;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 128)]
    private readonly ItemRecord Item129;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 129)]
    private readonly ItemRecord Item130;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 130)]
    private readonly ItemRecord Item131;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 131)]
    private readonly ItemRecord Item132;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 132)]
    private readonly ItemRecord Item133;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 133)]
    private readonly ItemRecord Item134;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 134)]
    private readonly ItemRecord Item135;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 135)]
    private readonly ItemRecord Item136;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 136)]
    private readonly ItemRecord Item137;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 137)]
    private readonly ItemRecord Item138;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 138)]
    private readonly ItemRecord Item139;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 139)]
    private readonly ItemRecord Item140;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 140)]
    private readonly ItemRecord Item141;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 141)]
    private readonly ItemRecord Item142;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 142)]
    private readonly ItemRecord Item143;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 143)]
    private readonly ItemRecord Item144;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 144)]
    private readonly ItemRecord Item145;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 145)]
    private readonly ItemRecord Item146;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 146)]
    private readonly ItemRecord Item147;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 147)]
    private readonly ItemRecord Item148;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 148)]
    private readonly ItemRecord Item149;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 149)]
    private readonly ItemRecord Item150;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 150)]
    private readonly ItemRecord Item151;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 151)]
    private readonly ItemRecord Item152;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 152)]
    private readonly ItemRecord Item153;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 153)]
    private readonly ItemRecord Item154;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 154)]
    private readonly ItemRecord Item155;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 155)]
    private readonly ItemRecord Item156;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 156)]
    private readonly ItemRecord Item157;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 157)]
    private readonly ItemRecord Item158;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 158)]
    private readonly ItemRecord Item159;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 159)]
    private readonly ItemRecord Item160;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 160)]
    private readonly ItemRecord Item161;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 161)]
    private readonly ItemRecord Item162;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 162)]
    private readonly ItemRecord Item163;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 163)]
    private readonly ItemRecord Item164;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 164)]
    private readonly ItemRecord Item165;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 165)]
    private readonly ItemRecord Item166;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 166)]
    private readonly ItemRecord Item167;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 167)]
    private readonly ItemRecord Item168;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 168)]
    private readonly ItemRecord Item169;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 169)]
    private readonly ItemRecord Item170;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 170)]
    private readonly ItemRecord Item171;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 171)]
    private readonly ItemRecord Item172;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 172)]
    private readonly ItemRecord Item173;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 173)]
    private readonly ItemRecord Item174;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 174)]
    private readonly ItemRecord Item175;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 175)]
    private readonly ItemRecord Item176;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 176)]
    private readonly ItemRecord Item177;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 177)]
    private readonly ItemRecord Item178;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 178)]
    private readonly ItemRecord Item179;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 179)]
    private readonly ItemRecord Item180;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 180)]
    private readonly ItemRecord Item181;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 181)]
    private readonly ItemRecord Item182;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 182)]
    private readonly ItemRecord Item183;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 183)]
    private readonly ItemRecord Item184;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 184)]
    private readonly ItemRecord Item185;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 185)]
    private readonly ItemRecord Item186;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 186)]
    private readonly ItemRecord Item187;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 187)]
    private readonly ItemRecord Item188;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 188)]
    private readonly ItemRecord Item189;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 189)]
    private readonly ItemRecord Item190;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 190)]
    private readonly ItemRecord Item191;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 191)]
    private readonly ItemRecord Item192;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 192)]
    private readonly ItemRecord Item193;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 193)]
    private readonly ItemRecord Item194;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 194)]
    private readonly ItemRecord Item195;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 195)]
    private readonly ItemRecord Item196;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 196)]
    private readonly ItemRecord Item197;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 197)]
    private readonly ItemRecord Item198;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 198)]
    private readonly ItemRecord Item199;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 199)]
    private readonly ItemRecord Item200;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 200)]
    private readonly ItemRecord Item201;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 201)]
    private readonly ItemRecord Item202;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 202)]
    private readonly ItemRecord Item203;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 203)]
    private readonly ItemRecord Item204;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 204)]
    private readonly ItemRecord Item205;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 205)]
    private readonly ItemRecord Item206;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 206)]
    private readonly ItemRecord Item207;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 207)]
    private readonly ItemRecord Item208;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 208)]
    private readonly ItemRecord Item209;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 209)]
    private readonly ItemRecord Item210;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 210)]
    private readonly ItemRecord Item211;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 211)]
    private readonly ItemRecord Item212;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 212)]
    private readonly ItemRecord Item213;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 213)]
    private readonly ItemRecord Item214;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 214)]
    private readonly ItemRecord Item215;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 215)]
    private readonly ItemRecord Item216;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 216)]
    private readonly ItemRecord Item217;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 217)]
    private readonly ItemRecord Item218;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 218)]
    private readonly ItemRecord Item219;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 219)]
    private readonly ItemRecord Item220;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 220)]
    private readonly ItemRecord Item221;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 221)]
    private readonly ItemRecord Item222;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 222)]
    private readonly ItemRecord Item223;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 223)]
    private readonly ItemRecord Item224;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 224)]
    private readonly ItemRecord Item225;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 225)]
    private readonly ItemRecord Item226;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 226)]
    private readonly ItemRecord Item227;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 227)]
    private readonly ItemRecord Item228;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 228)]
    private readonly ItemRecord Item229;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 229)]
    private readonly ItemRecord Item230;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 230)]
    private readonly ItemRecord Item231;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 231)]
    private readonly ItemRecord Item232;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 232)]
    private readonly ItemRecord Item233;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 233)]
    private readonly ItemRecord Item234;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 234)]
    private readonly ItemRecord Item235;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 235)]
    private readonly ItemRecord Item236;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 236)]
    private readonly ItemRecord Item237;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 237)]
    private readonly ItemRecord Item238;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 238)]
    private readonly ItemRecord Item239;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 239)]
    private readonly ItemRecord Item240;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 240)]
    private readonly ItemRecord Item241;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 241)]
    private readonly ItemRecord Item242;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 242)]
    private readonly ItemRecord Item243;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 243)]
    private readonly ItemRecord Item244;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 244)]
    private readonly ItemRecord Item245;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 245)]
    private readonly ItemRecord Item246;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 246)]
    private readonly ItemRecord Item247;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 247)]
    private readonly ItemRecord Item248;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 248)]
    private readonly ItemRecord Item249;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 249)]
    private readonly ItemRecord Item250;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 250)]
    private readonly ItemRecord Item251;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 251)]
    private readonly ItemRecord Item252;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 252)]
    private readonly ItemRecord Item253;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 253)]
    private readonly ItemRecord Item254;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 254)]
    private readonly ItemRecord Item255;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 255)]
    private readonly ItemRecord Item256;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 256)]
    private readonly ItemRecord Item257;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 257)]
    private readonly ItemRecord Item258;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 258)]
    private readonly ItemRecord Item259;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 259)]
    private readonly ItemRecord Item260;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 260)]
    private readonly ItemRecord Item261;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 261)]
    private readonly ItemRecord Item262;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 262)]
    private readonly ItemRecord Item263;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 263)]
    private readonly ItemRecord Item264;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 264)]
    private readonly ItemRecord Item265;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 265)]
    private readonly ItemRecord Item266;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 266)]
    private readonly ItemRecord Item267;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 267)]
    private readonly ItemRecord Item268;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 268)]
    private readonly ItemRecord Item269;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 269)]
    private readonly ItemRecord Item270;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 270)]
    private readonly ItemRecord Item271;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 271)]
    private readonly ItemRecord Item272;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 272)]
    private readonly ItemRecord Item273;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 273)]
    private readonly ItemRecord Item274;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 274)]
    private readonly ItemRecord Item275;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 275)]
    private readonly ItemRecord Item276;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 276)]
    private readonly ItemRecord Item277;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 277)]
    private readonly ItemRecord Item278;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 278)]
    private readonly ItemRecord Item279;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 279)]
    private readonly ItemRecord Item280;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 280)]
    private readonly ItemRecord Item281;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 281)]
    private readonly ItemRecord Item282;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 282)]
    private readonly ItemRecord Item283;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 283)]
    private readonly ItemRecord Item284;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 284)]
    private readonly ItemRecord Item285;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 285)]
    private readonly ItemRecord Item286;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 286)]
    private readonly ItemRecord Item287;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 287)]
    private readonly ItemRecord Item288;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 288)]
    private readonly ItemRecord Item289;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 289)]
    private readonly ItemRecord Item290;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 290)]
    private readonly ItemRecord Item291;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 291)]
    private readonly ItemRecord Item292;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 292)]
    private readonly ItemRecord Item293;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 293)]
    private readonly ItemRecord Item294;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 294)]
    private readonly ItemRecord Item295;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 295)]
    private readonly ItemRecord Item296;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 296)]
    private readonly ItemRecord Item297;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 297)]
    private readonly ItemRecord Item298;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 298)]
    private readonly ItemRecord Item299;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 299)]
    private readonly ItemRecord Item300;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 300)]
    private readonly ItemRecord Item301;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 301)]
    private readonly ItemRecord Item302;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 302)]
    private readonly ItemRecord Item303;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 303)]
    private readonly ItemRecord Item304;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 304)]
    private readonly ItemRecord Item305;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 305)]
    private readonly ItemRecord Item306;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 306)]
    private readonly ItemRecord Item307;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 307)]
    private readonly ItemRecord Item308;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 308)]
    private readonly ItemRecord Item309;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 309)]
    private readonly ItemRecord Item310;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 310)]
    private readonly ItemRecord Item311;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 311)]
    private readonly ItemRecord Item312;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 312)]
    private readonly ItemRecord Item313;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 313)]
    private readonly ItemRecord Item314;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 314)]
    private readonly ItemRecord Item315;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 315)]
    private readonly ItemRecord Item316;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 316)]
    private readonly ItemRecord Item317;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 317)]
    private readonly ItemRecord Item318;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 318)]
    private readonly ItemRecord Item319;

    [FieldOffset(SaveMapOffsets.ItemStock + ItemSize * 319)]
    private readonly ItemRecord Item320;

    public ItemRecord[] Items => new[]
    {
        Item1,
        Item2,
        Item3,
        Item4,
        Item5,
        Item6,
        Item7,
        Item8,
        Item9,
        Item10,
        Item11,
        Item12,
        Item13,
        Item14,
        Item15,
        Item16,
        Item17,
        Item18,
        Item19,
        Item20,
        Item21,
        Item22,
        Item23,
        Item24,
        Item25,
        Item26,
        Item27,
        Item28,
        Item29,
        Item30,
        Item31,
        Item32,
        Item33,
        Item34,
        Item35,
        Item36,
        Item37,
        Item38,
        Item39,
        Item40,
        Item41,
        Item42,
        Item43,
        Item44,
        Item45,
        Item46,
        Item47,
        Item48,
        Item49,
        Item50,
        Item51,
        Item52,
        Item53,
        Item54,
        Item55,
        Item56,
        Item57,
        Item58,
        Item59,
        Item60,
        Item61,
        Item62,
        Item63,
        Item64,
        Item65,
        Item66,
        Item67,
        Item68,
        Item69,
        Item70,
        Item71,
        Item72,
        Item73,
        Item74,
        Item75,
        Item76,
        Item77,
        Item78,
        Item79,
        Item80,
        Item81,
        Item82,
        Item83,
        Item84,
        Item85,
        Item86,
        Item87,
        Item88,
        Item89,
        Item90,
        Item91,
        Item92,
        Item93,
        Item94,
        Item95,
        Item96,
        Item97,
        Item98,
        Item99,
        Item100,
        Item101,
        Item102,
        Item103,
        Item104,
        Item105,
        Item106,
        Item107,
        Item108,
        Item109,
        Item110,
        Item111,
        Item112,
        Item113,
        Item114,
        Item115,
        Item116,
        Item117,
        Item118,
        Item119,
        Item120,
        Item121,
        Item122,
        Item123,
        Item124,
        Item125,
        Item126,
        Item127,
        Item128,
        Item129,
        Item130,
        Item131,
        Item132,
        Item133,
        Item134,
        Item135,
        Item136,
        Item137,
        Item138,
        Item139,
        Item140,
        Item141,
        Item142,
        Item143,
        Item144,
        Item145,
        Item146,
        Item147,
        Item148,
        Item149,
        Item150,
        Item151,
        Item152,
        Item153,
        Item154,
        Item155,
        Item156,
        Item157,
        Item158,
        Item159,
        Item160,
        Item161,
        Item162,
        Item163,
        Item164,
        Item165,
        Item166,
        Item167,
        Item168,
        Item169,
        Item170,
        Item171,
        Item172,
        Item173,
        Item174,
        Item175,
        Item176,
        Item177,
        Item178,
        Item179,
        Item180,
        Item181,
        Item182,
        Item183,
        Item184,
        Item185,
        Item186,
        Item187,
        Item188,
        Item189,
        Item190,
        Item191,
        Item192,
        Item193,
        Item194,
        Item195,
        Item196,
        Item197,
        Item198,
        Item199,
        Item200,
        Item201,
        Item202,
        Item203,
        Item204,
        Item205,
        Item206,
        Item207,
        Item208,
        Item209,
        Item210,
        Item211,
        Item212,
        Item213,
        Item214,
        Item215,
        Item216,
        Item217,
        Item218,
        Item219,
        Item220,
        Item221,
        Item222,
        Item223,
        Item224,
        Item225,
        Item226,
        Item227,
        Item228,
        Item229,
        Item230,
        Item231,
        Item232,
        Item233,
        Item234,
        Item235,
        Item236,
        Item237,
        Item238,
        Item239,
        Item240,
        Item241,
        Item242,
        Item243,
        Item244,
        Item245,
        Item246,
        Item247,
        Item248,
        Item249,
        Item250,
        Item251,
        Item252,
        Item253,
        Item254,
        Item255,
        Item256,
        Item257,
        Item258,
        Item259,
        Item260,
        Item261,
        Item262,
        Item263,
        Item264,
        Item265,
        Item266,
        Item267,
        Item268,
        Item269,
        Item270,
        Item271,
        Item272,
        Item273,
        Item274,
        Item275,
        Item276,
        Item277,
        Item278,
        Item279,
        Item280,
        Item281,
        Item282,
        Item283,
        Item284,
        Item285,
        Item286,
        Item287,
        Item288,
        Item289,
        Item290,
        Item291,
        Item292,
        Item293,
        Item294,
        Item295,
        Item296,
        Item297,
        Item298,
        Item299,
        Item300,
        Item301,
        Item302,
        Item303,
        Item304,
        Item305,
        Item306,
        Item307,
        Item308,
        Item309,
        Item310,
        Item311,
        Item312,
        Item313,
        Item314,
        Item315,
        Item316,
        Item317,
        Item318,
        Item319,
        Item320,
    };

}