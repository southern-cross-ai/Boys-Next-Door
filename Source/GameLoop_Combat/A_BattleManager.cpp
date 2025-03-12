#include "A_BattleManager.h"
#include "HeroData.h"
#include "GameFramework/Actor.h"
#include "Kismet/KismetMathLibrary.h"
#include "Engine/World.h"
#include "Enums/BattleStageType.h"
#include "TimerManager.h"

// Sets default values
AA_BattleManager::AA_BattleManager()
{
    PrimaryActorTick.bCanEverTick = true;
}

void AA_BattleManager::BeginPlay()
{
    Super::BeginPlay();
    
    // 初始化战斗
    Initialization();
}

void AA_BattleManager::Tick(float DeltaTime)
{
    Super::Tick(DeltaTime);
    StartBattleSequence(DeltaTime);
}

// 初始化战斗
void AA_BattleManager::Initialization()
{
    UE_LOG(LogTemp, Log, TEXT("[BATTLE] Initialization start"));
    // 初始化敌人和玩家单位，设置初始数据等
    EntityDataList.Add(FHeroData("Hero 01", 0, 10));  // 示例
    EntityDataList.Add(FHeroData("Hero 02", 1, 5));  // 示例
    EntityDataList.Add(FHeroData("Hero 03", 2, 8));  // 示例
    EntityDataList.Add(FHeroData("Hero 04", 3, 3));  // 示例
    
    EntityDataList.Add(FHeroData("Enemy 01", 10, 3));  // 示例
    
    // 标记战斗状态为进行中
    eBattleStageType = BattleStageType::StartRound;
    fCurrentStageTime = 0.f;
    bHasProceedCurrentStage = false;
}

// 开始每回合
void AA_BattleManager::StartBattleSequence(float DeltaTime)
{
    switch (eBattleStageType)
    {
        case BattleStageType::StartRound: StartRound(DeltaTime); break;
        case BattleStageType::PlayerAction: PlayerAction(DeltaTime); break;
    }
}

void AA_BattleManager::StartRound(float DeltaTime)
{
    if (!bHasProceedCurrentStage)
    {
        UE_LOG(LogTemp, Log, TEXT("[BATTLE] StartRound start"));
        for (FHeroData& HeroData : EntityDataList)
        {
            int randomInt = FMath::RandRange(-1, 1);
            HeroData.dynamic_speed = HeroData.speed + randomInt;
        }
        bHasProceedCurrentStage = true;
    }

    fCurrentStageTime += DeltaTime;
    if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
    {
        eBattleStageType = BattleStageType::PlayerAction;
        fCurrentStageTime = 0.f;
        bHasProceedCurrentStage = false;
    }
}

void AA_BattleManager::PlayerAction(float DeltaTime)
{
    if (!bHasProceedCurrentStage)
    {
        UE_LOG(LogTemp, Log, TEXT("[BATTLE] PlayerAction start"));
        bHasProceedCurrentStage = true;
    }

    fCurrentStageTime += DeltaTime;
    if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
    {
        eBattleStageType = BattleStageType::PlayerAction;
        fCurrentStageTime = 0.f;
        bHasProceedCurrentStage = false;
    }
}

// 根据SPD排序单位
void AA_BattleManager::SortUnitsBySpeed(TArray<FHeroData*>& HeroList)
{
    // 给每个单位计算速度 + 随机浮动
    for (FHeroData* Hero : HeroList)
    {
        float RandomFloat = UKismetMathLibrary::RandomFloatInRange(-1.f, 1.f);
        Hero->speed = Hero->speed + RandomFloat;
    }
    
    // 按照计算后的速度排序
    HeroList.Sort([](const FHeroData& A, const FHeroData& B) {
        return (&A)->dynamic_speed > (&B)->dynamic_speed;
    });
}

