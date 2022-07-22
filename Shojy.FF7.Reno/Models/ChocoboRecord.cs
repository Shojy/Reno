using System.Runtime.InteropServices;
using Shojy.FF7.Reno.MemoryAddresses.Offsets;
using Shojy.FF7.Reno.Models.Enums;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Explicit, Size = ChocoboOffsets.ChocoboLength)]
public record struct ChocoboRecord
{
    [FieldOffset(ChocoboOffsets.SprintSpeed)]
    public ushort SprintSpeed;

    [FieldOffset(ChocoboOffsets.MaxSprintSpeed)]
    public ushort MaxSprintSpeed;

    [FieldOffset(ChocoboOffsets.Speed)]
    public ushort Speed;

    [FieldOffset(ChocoboOffsets.MaxSpeed)]
    public ushort MaxSpeed;

    [FieldOffset(ChocoboOffsets.Acceleration)]
    public byte Acceleration;

    [FieldOffset(ChocoboOffsets.Cooperation)]
    public byte Cooperation;

    [FieldOffset(ChocoboOffsets.Intelligence)]
    public byte Intelligence;

    [FieldOffset(ChocoboOffsets.Personality)]
    public byte Personality;

    [FieldOffset(ChocoboOffsets.RacesWon)]
    public byte RacesWon;

    [FieldOffset(ChocoboOffsets.Gender)]
    public ChocoboGender Gender;

    [FieldOffset(ChocoboOffsets.Color)]
    public ChocoboColor Color;
}