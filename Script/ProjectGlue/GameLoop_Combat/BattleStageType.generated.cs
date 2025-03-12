using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.GameLoop_Combat;

[UEnum, GeneratedType("BattleStageType", "UnrealSharp.GameLoop_Combat.BattleStageType")]
public enum BattleStageType : byte
{
    Initialization = 0,
    StartRound = 1,
    PlayerAction = 2,
    BattleAction = 3,
    UseItemAction = 4,
    MovePositionAction = 5,
    DefenseAction = 6,
    ToHitCheck = 7,
    CriticalCheck = 8,
    DamageCalculation = 9,
    StatusEffect = 10,
    DeathDoorCheck = 11,
    ClearAndRefresh = 12,
    EndGame = 13,
}