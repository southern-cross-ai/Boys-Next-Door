using UnrealSharp.Attributes;

namespace ManagedGameLoop_Combat.Enums;
[UEnum]
public enum EBattleStageType : byte
{
	Initialization,

	StartRound,
	PlayerAction,
		BattleAction,
		UseItemAction,
		MovePositionAction,
		DefenseAction,
	ToHitCheck,
	CriticalCheck,
	DamageCalculation,
	StatusEffect,
	DeathDoorCheck,

	ClearAndRefresh,
	EndGame,
}
