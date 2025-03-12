#pragma once
#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "BattleStageType.generated.h"

UENUM(BlueprintType)
enum class BattleStageType : uint8
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
};