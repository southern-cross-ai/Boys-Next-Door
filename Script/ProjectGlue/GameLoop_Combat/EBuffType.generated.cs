using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.GameLoop_Combat;

[UEnum, GeneratedType("EBuffType", "UnrealSharp.GameLoop_Combat.EBuffType")]
public enum EBuffType : byte
{
    SpeedUp = 0,
    PowerUp = 1,
    SpeedDown = 2,
    PowerDown = 3,
}