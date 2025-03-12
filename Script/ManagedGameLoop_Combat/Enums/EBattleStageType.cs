namespace ManagedGameLoop_Combat.Enums;

public enum EBattleStageType
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
