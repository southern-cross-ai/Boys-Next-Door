#pragma once
#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "SkillType.generated.h"

UENUM(BlueprintType)
enum class ESkillType : uint8
{
	StraightDamage     UMETA(DisplayName = "StraightDamage"),
	ShotgunDamage      UMETA(DisplayName = "ShotgunDamage"),
};