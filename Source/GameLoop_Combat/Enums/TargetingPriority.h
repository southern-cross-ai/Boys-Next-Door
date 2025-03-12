#pragma once

#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "TargetingPriority.generated.h"

UENUM(BlueprintType)
enum class ETargetingPriority : uint8
{
	Backline			UMETA(DisplayName = "Backline"),
	LowestHP			UMETA(DisplayName = "Lowest HP"),
	HighestStress		UMETA(DisplayName = "Highest Stress"),
};
