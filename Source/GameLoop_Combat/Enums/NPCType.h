#pragma once

#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "NPCType.generated.h"

UENUM(BlueprintType)
enum class ENPCType : uint8
{
	Beast			UMETA(DisplayName = "Beast"),
	Human			UMETA(DisplayName = "Human"),
	Aberration		UMETA(DisplayName = "Aberration"),
};
