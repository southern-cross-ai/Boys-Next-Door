using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.GameLoop_Combat;

[UEnum, GeneratedType("ETargetingPriority", "UnrealSharp.GameLoop_Combat.ETargetingPriority")]
public enum ETargetingPriority : byte
{
    Backline = 0,
    LowestHP = 1,
    HighestStress = 2,
}