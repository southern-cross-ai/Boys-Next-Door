using UnrealSharp.Attributes;

namespace ManagedGameLoop_Combat.Enums;
[UEnum]
public enum ETargetingPriority : byte
{
	Backline,
	LowestHP,
	HighestStress
}
