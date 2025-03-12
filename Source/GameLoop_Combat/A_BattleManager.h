#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "HeroData.h"
#include "Enums/BattleStageType.h"

#include "A_BattleManager.generated.h"


UCLASS()
class GAMELOOP_COMBAT_API AA_BattleManager : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	AA_BattleManager();
	
protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

	// void InitializeBattle();

	void StartBattleSequence(float DeltaTime);

	void Initialization();
	void StartRound(float DeltaTime);
	void PlayerAction(float DeltaTime);
	void BattleAction(float DeltaTime);
	void UseItemAction(float DeltaTime);
	void MovePositionAction(float DeltaTime);
	void DefenseAction(float DeltaTime);
	void ToHitCheck(float DeltaTime);
	void CriticalCheck(float DeltaTime);
	void DamageCalculation(float DeltaTime);
	void StatusEffect(float DeltaTime);
	void DeathDoorCheck(float DeltaTime);
	void ClearAndRefresh(float DeltaTime);
	void EndGame(float DeltaTime);
	
	void SortUnitsBySpeed(TArray<FHeroData>& HeroList);
	void DeployUnitsByPreferred(TArray<FHeroData>& HeroList, bool isEnemy);
public:
	bool bIsBattleActive;
	
	UPROPERTY(EditAnywhere)
	TArray<FHeroData> EntityDataList;

	// UPROPERTY(EditAnywhere)
	// TArray<FHeroData&> PositionMap;
	//
	UPROPERTY(EditAnywhere)
	int32 iCurrentRound;

	UPROPERTY(EditAnywhere)
	BattleStageType eBattleStageType;

	UPROPERTY(EditAnywhere)
	float fWaitTime = 5.f;

	UPROPERTY(EditAnywhere)
	float fCurrentStageTime;
	
	UPROPERTY(EditAnywhere)
	bool bHasProceedCurrentStage;

};
