using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.GameLoop_Combat;

[UEnum, GeneratedType("EAIBehaviorType", "UnrealSharp.GameLoop_Combat.EAIBehaviorType")]
public enum EAIBehaviorType : byte
{
    Attack = 0,
    Defense = 1,
    Cover = 2,
}