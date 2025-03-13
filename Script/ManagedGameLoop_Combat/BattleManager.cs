// using System;
// using System.Collections.Generic;
// using System.Linq;
using UnrealSharp.Attributes;
using UnrealSharp.Engine;

namespace ManagedGameLoop_Combat;

[UClass]
public class ABattleManager : AActor
{
    private List<HeroData> EntityDataList = new List<HeroData>();
    private Enums.EBattleStageType BattleStageType;
    private float fCurrentStageTime;
    private bool bHasProceedCurrentStage;
    private float fWaitTime = 2.0f;

    public ABattleManager()
    {
        
    }

    protected override void BeginPlay()
    {
        Initialization();
    }
    public override void Tick(float deltaSeconds)
    {
        switch (BattleStageType)
        {
            case Enums.EBattleStageType.StartRound:
                StartRound(deltaSeconds);
                break;
            case Enums.EBattleStageType.PlayerAction:
                PlayerAction(deltaSeconds);
                break;
        }
    }
    private void Initialization()
    {
        PrintString("[BATTLE] Initialization start", duration: 5);
        EntityDataList.Add(new HeroData("Hero 01", 0, 10, false));
        EntityDataList.Add(new HeroData("Hero 02", 1, 5, false));
        EntityDataList.Add(new HeroData("Hero 03", 2, 8, false));
        EntityDataList.Add(new HeroData("Hero 04", 3, 3, false));

        EntityDataList.Add(new HeroData("Enemy 01", 10, 3, true));

        BattleStageType = Enums.EBattleStageType.StartRound;
        fCurrentStageTime = 0f;
        bHasProceedCurrentStage = false;
    }

    private void StartRound(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            PrintString("[BATTLE] StartRound start", duration: 5);
            // // PrintToConsole("[BATTLE] StartRound start");
            SortUnitsBySpeed(EntityDataList);
            DeployUnitsByPreferred(EntityDataList, true);
            DeployUnitsByPreferred(EntityDataList, false);

            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.PlayerAction;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void PlayerAction(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            PrintString("[BATTLE] PlayerAction start", duration: 5);
            // PrintToConsole("[BATTLE] PlayerAction start");
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.PlayerAction;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void SortUnitsBySpeed(List<HeroData> heroList)
    {
        Random random = new Random();
        foreach (var hero in heroList)
        {
            int randomInt = random.Next(-1, 2);
            hero.DynamicSpeed = hero.Speed + randomInt;
        }

        heroList.Sort((a, b) => b.DynamicSpeed.CompareTo(a.DynamicSpeed));
    }

    private void DeployUnitsByPreferred(List<HeroData> heroList, bool isEnemy)
    {
        bool[] occupiedPositions = new bool[4];

        foreach (var hero in heroList)
        {
            if (hero.IsEnemy == isEnemy)
            {
                var indexes = hero.PositionPreferred
                    .Select((pos, idx) => new { Position = pos, OriginalIdx = idx })
                    .OrderByDescending(x => x.Position)
                    .ToList();

                foreach (var preferredPosition in indexes)
                {
                    if (!occupiedPositions[preferredPosition.OriginalIdx])
                    {
                        occupiedPositions[preferredPosition.OriginalIdx] = true;
                        hero.Position = preferredPosition.Position;
                        PrintString($"[BATTLE] Deployed {hero.Name} to {hero.Position}", duration: 5);
                        // PrintToConsole($"[BATTLE] Deployed {hero.Name} to {hero.Position}");
                        break;
                    }
                }
            }
        }
    }
}
