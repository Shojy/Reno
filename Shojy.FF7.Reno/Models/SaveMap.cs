using System.Runtime.InteropServices;
using Shojy.FF7.Reno.MemoryAddresses.Offsets;
using Shojy.FF7.Reno.Models.Enums;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Explicit, Size = SaveMapOffsets.SaveMapLength, Pack = 1)]
public readonly partial record  struct SaveMap
{
    [FieldOffset(SaveMapOffsets.CloudRecord)]
    public readonly CharacterRecord Cloud;

    [FieldOffset(SaveMapOffsets.BarretRecord)]
    public readonly CharacterRecord Barret;

    [FieldOffset(SaveMapOffsets.TifaRecord)]
    public readonly CharacterRecord Tifa;

    [FieldOffset(SaveMapOffsets.AerisRecord)]
    public readonly CharacterRecord Aeris;

    [FieldOffset(SaveMapOffsets.RedXIIIRecord)]
    public readonly CharacterRecord RedXIII;

    [FieldOffset(SaveMapOffsets.YuffieRecord)]
    public readonly CharacterRecord Yuffie;

    [FieldOffset(SaveMapOffsets.CaitSithRecord)]
    public readonly CharacterRecord CaitSith;

    [FieldOffset(SaveMapOffsets.VincentRecord)]
    public readonly CharacterRecord Vincent;

    [FieldOffset(SaveMapOffsets.CidRecord)]
    public readonly CharacterRecord Cid;

    [FieldOffset(SaveMapOffsets.YoungCloudRecord)]
    public readonly CharacterRecord YoungCloud;

    [FieldOffset(SaveMapOffsets.SephirothRecord)]
    public readonly CharacterRecord Sephiroth;

    [FieldOffset(SaveMapOffsets.PartyMember1)]
    public readonly PartyMember PartyMember1;

    [FieldOffset(SaveMapOffsets.PartyMember2)]
    public readonly PartyMember PartyMember2;

    [FieldOffset(SaveMapOffsets.PartyMember3)]
    public readonly PartyMember PartyMember3;

    [FieldOffset(SaveMapOffsets.FinalBattleGroup1Character1)]
    public readonly PartyMember FinalBattleGroup1PartyMember1;

    [FieldOffset(SaveMapOffsets.FinalBattleGroup1Character2)]
    public readonly PartyMember FinalBattleGroup1PartyMember2;

    [FieldOffset(SaveMapOffsets.FinalBattleGroup1Character3)]
    public readonly PartyMember FinalBattleGroup1PartyMember3;
    
    [FieldOffset(SaveMapOffsets.FinalBattleGroup2Character1)]
    public readonly PartyMember FinalBattleGroup2PartyMember1;

    [FieldOffset(SaveMapOffsets.FinalBattleGroup2Character2)]
    public readonly PartyMember FinalBattleGroup2PartyMember2;

    [FieldOffset(SaveMapOffsets.FinalBattleGroup2Character3)]
    public readonly PartyMember FinalBattleGroup2PartyMember3;
    
    [FieldOffset(SaveMapOffsets.FinalBattleGroup3Character1)]
    public readonly PartyMember FinalBattleGroup3PartyMember1;

    [FieldOffset(SaveMapOffsets.FinalBattleGroup3Character2)]
    public readonly PartyMember FinalBattleGroup3PartyMember2;

    [FieldOffset(SaveMapOffsets.FinalBattleGroup3Character3)]
    public readonly PartyMember FinalBattleGroup3PartyMember3;

    [FieldOffset(SaveMapOffsets.ChocoboRecord1)]
    public readonly ChocoboRecord Chocobo1;

    [FieldOffset(SaveMapOffsets.ChocoboName1)]
    public readonly ChocoboName Chocobo1Name;

    [FieldOffset(SaveMapOffsets.ChocoboRecord2)]
    public readonly ChocoboRecord Chocobo2;

    [FieldOffset(SaveMapOffsets.ChocoboName2)]
    public readonly ChocoboName Chocobo2Name;

    [FieldOffset(SaveMapOffsets.ChocoboRecord3)]
    public readonly ChocoboRecord Chocobo3;

    [FieldOffset(SaveMapOffsets.ChocoboName3)]
    public readonly ChocoboName Chocobo3Name;
    
    [FieldOffset(SaveMapOffsets.ChocoboRecord4)]
    public readonly ChocoboRecord Chocobo4;

    [FieldOffset(SaveMapOffsets.ChocoboName4)]
    public readonly ChocoboName Chocobo4Name;
    
    [FieldOffset(SaveMapOffsets.ChocoboRecord5)]
    public readonly ChocoboRecord Chocobo5;

    [FieldOffset(SaveMapOffsets.ChocoboName5)]
    public readonly ChocoboName Chocobo5Name;

    [FieldOffset(SaveMapOffsets.ChocoboRecord6)]
    public readonly ChocoboRecord Chocobo6;

    [FieldOffset(SaveMapOffsets.ChocoboName6)]
    public readonly ChocoboName Chocobo6Name;

    [FieldOffset(SaveMapOffsets.ChocoboStamina1)]
    public readonly ushort Chocobo1Stamina;

    [FieldOffset(SaveMapOffsets.ChocoboStamina2)]
    public readonly ushort Chocobo2Stamina;

    [FieldOffset(SaveMapOffsets.ChocoboStamina3)]
    public readonly ushort Chocobo3Stamina;

    [FieldOffset(SaveMapOffsets.ChocoboStamina4)]
    public readonly ushort Chocobo4Stamina;

    [FieldOffset(SaveMapOffsets.ChocoboStamina5)]
    public readonly ushort Chocobo5Stamina;

    [FieldOffset(SaveMapOffsets.ChocoboStamina6)]
    public readonly ushort Chocobo6Stamina;

    [FieldOffset(SaveMapOffsets.PlayTime)]
    public readonly Time PlayTime;

    [FieldOffset(SaveMapOffsets.Countdown)]
    public readonly Time Countdown;

    [FieldOffset(SaveMapOffsets.WindowColor)]
    public readonly WindowColor WindowColor;

    [FieldOffset(SaveMapOffsets.GameDisc)]
    public readonly byte GameDisc;

    [FieldOffset(SaveMapOffsets.Gil)]
    public readonly int Gil;

    [FieldOffset(SaveMapOffsets.UltimateWeaponHp)]
    public readonly Int24 UltimateWeaponHP;

    [FieldOffset(SaveMapOffsets.KeyItems)] 
    public readonly KeyItems KeyItems;
}