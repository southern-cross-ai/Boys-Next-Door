#pragma once
#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "AIBehaviorType.generated.h"
UENUM(BlueprintType)
enum class EAIBehaviorType : uint8
{
	Attack			UMETA(DisplayName = "Attack"),
	Defense			UMETA(DisplayName = "Defense"),
	Cover			UMETA(DisplayName = "Cover"),
};