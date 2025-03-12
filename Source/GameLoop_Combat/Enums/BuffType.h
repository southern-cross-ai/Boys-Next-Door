#pragma once
#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "BuffType.generated.h"

UENUM(BlueprintType)
enum class EBuffType : uint8
{
	SpeedUp      UMETA(DisplayName = "SpeedUp"),
	PowerUp      UMETA(DisplayName = "PowerUp"),

	SpeedDown    UMETA(DisplayName = "SpeedDown"),
	PowerDown    UMETA(DisplayName = "PowerDown"),
};