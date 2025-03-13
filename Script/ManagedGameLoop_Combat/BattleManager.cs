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
            case Enums.EBattleStageType.BattleAction:
                BattleAction(deltaSeconds);
                break;
            case Enums.EBattleStageType.UseItemAction:
                UseItemAction(deltaSeconds);
                break;
            case Enums.EBattleStageType.MovePositionAction:
                MovePositionAction(deltaSeconds);
                break;
            case Enums.EBattleStageType.DefenseAction:
                DefenseAction(deltaSeconds);
                break;
            case Enums.EBattleStageType.ToHitCheck:
                ToHitCheck(deltaSeconds);
                break;
            case Enums.EBattleStageType.CriticalCheck:
                CriticalCheck(deltaSeconds);
                break;
            case Enums.EBattleStageType.DamageCalculation:
                DamageCalculation(deltaSeconds);
                break;
            case Enums.EBattleStageType.StatusEffect:
                StatusEffect(deltaSeconds);
                break;
            case Enums.EBattleStageType.DeathDoorCheck:
                DeathDoorCheck(deltaSeconds);
                break;
            case Enums.EBattleStageType.ClearAndRefresh:
                ClearAndRefresh(deltaSeconds);
                break;
            case Enums.EBattleStageType.EndGame:
                EndGame(deltaSeconds);
                break;
            default:
                break;
        }
    }

    private void StartRound(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            PrintString("[BATTLE] StartRound start", duration: 5);
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
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.BattleAction;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }
    
    // ====================================================================
    // ====================================================================
    private void BattleAction(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: BattleAction start logic
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.ToHitCheck;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void UseItemAction(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: UseItemAction start logic
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.ToHitCheck;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void MovePositionAction(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: MovePositionAction start logic
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.ToHitCheck;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void DefenseAction(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: DefenseAction start logic
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.ToHitCheck;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void ToHitCheck(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: ToHitCheck start logic
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.CriticalCheck;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void CriticalCheck(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: CriticalCheck start logic
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.DamageCalculation;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void DamageCalculation(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: DamageCalculation start logic
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.StatusEffect;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void StatusEffect(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: StatusEffect start logic
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.DeathDoorCheck;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void DeathDoorCheck(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: DeathDoorCheck start logic
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

    private void ClearAndRefresh(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: ClearAndRefresh start logic
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            BattleStageType = Enums.EBattleStageType.EndGame;
            fCurrentStageTime = 0f;
            bHasProceedCurrentStage = false;
        }
    }

    private void EndGame(float deltaTime)
    {
        if (!bHasProceedCurrentStage)
        {
            // TODO: EndGame start logic
            PrintString("[BATTLE] EndGame reached", duration: 5);
            bHasProceedCurrentStage = true;
        }

        fCurrentStageTime += deltaTime;
        if (bHasProceedCurrentStage && fWaitTime < fCurrentStageTime)
        {
            // End of game logic can be handled here
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
