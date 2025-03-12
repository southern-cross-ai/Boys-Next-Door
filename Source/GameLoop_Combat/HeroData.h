#pragma once

#include "CoreMinimal.h"
#include "Enums/NPCType.h"
#include "Enums/TargetingPriority.h"
#include "Enums/BuffType.h"
#include "Enums/SkillType.h"
#include "Enums/AIBehaviorType.h"
// #include "Math/IntPoint.h"
// #include "HeroData.h"
#include "HeroData.generated.h"

// 定义英雄（NPC）结构体
USTRUCT(BlueprintType)
struct FHeroData
{
    GENERATED_BODY()

public:
    // 基础属性
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Basic Attributes")
    int32 npc_id;               // NPC唯一标识符

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Basic Attributes")
    FString name;               // NPC名字

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Basic Attributes")
    ENPCType type;              // NPC类型（枚举）

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Basic Attributes")
    bool isEnemy;
    
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Basic Attributes")
    int32 rank;                 // 强度等级

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Basic Attributes")
    int32 size;                 // 占用战斗站位的格数

    // 战斗属性
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    int32 hp;                   // 当前生命值

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    int32 max_hp;               // 最大生命值

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    int32 stress;               // 当前压力值

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    int32 speed;                  // 速度
    
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    float accuracy;                  // 命中率

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    float dodge;                // 闪避率

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    float critical;                 // 暴击率

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    float protect;                 // 护甲

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    TMap<EBuffType, int32> resistances; // 异常状态抗性

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    int32 damage_range;     // 基础伤害范围

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    TArray<int32> position_preferred;
    
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    int32 position;             // 当前站位
    
    // 状态属性
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Status Attributes")
    bool stunned;               // 是否被眩晕

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Status Attributes")
    bool marked;                // 是否被标记

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Status Attributes")
    FIntPoint bleed; // 流血状态（伤害、回合数）

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Status Attributes")
    FIntPoint blight; // 毒素状态（伤害、回合数）

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Status Attributes")
    TArray<EBuffType> buffs;      // 当前所有增益效果

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Status Attributes")
    bool death_door;            // 是否处于濒死状态

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Status Attributes")
    float death_save_chance;    // 濒死状态下的生存几率

    // 行为属性
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Behavioral Attributes")
    TArray<ESkillType> skills;     // 技能列表

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Behavioral Attributes")
    TMap<ESkillType, int32> skill_cooldowns; // 技能冷却

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Behavioral Attributes")
    EAIBehaviorType ai_behavior;        // AI行为模式

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Behavioral Attributes")
    TArray<int32> extra_actions;        // 当前回合额外行动次数

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Behavioral Attributes")
    ETargetingPriority targeting_priority; // 攻击目标优先级（枚举）
    
    // 动态参数
    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    int32 dynamic_speed;                  // 速度

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    int32 dynamic_critical;                  // 速度

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "Combat Attributes")
    int32 dynamic_dodge;                  // 速度

public:
    // 默认构造函数
    FHeroData()
        : npc_id(0), name(TEXT("Unnamed Hero")), type(ENPCType::Beast), isEnemy(false), rank(1), size(1), 
          hp(100), max_hp(100), stress(0), speed(5), accuracy(0.8f), dodge(0.15f), critical(0.1f), 
          protect(0.2f), damage_range(10), position(1), stunned(false), marked(false), bleed(0, 0),
          blight(0, 0), death_door(false), death_save_chance(0.0f)
    {
        // Initialize maps and arrays
        position_preferred.Append({0, 1, 2, 3});
        resistances.Add(EBuffType::SpeedDown, 0.3);
        buffs.Add(EBuffType::PowerUp);
        skills.Add(ESkillType::StraightDamage);
        ai_behavior = EAIBehaviorType::Attack;
        // extra_actions.Add(1);
        targeting_priority = ETargetingPriority::LowestHP;
    }
    FHeroData(FString InName, int32 InNpcId, float InSpeed, bool IsEnemy)
    : npc_id(InNpcId), name(InName), type(ENPCType::Beast), rank(1), size(1),
      hp(100), max_hp(100), stress(0), speed(InSpeed), accuracy(0.8f), dodge(0.15f), 
      critical(0.1f), protect(0.2f), damage_range(10), position(1), stunned(false), 
      marked(false), bleed(0, 0), blight(0, 0), death_door(false), death_save_chance(0.0f)
    {
        name = InName;
        npc_id = InNpcId;
        speed = InSpeed;
        isEnemy = IsEnemy;
        // Initialize maps and arrays
        position_preferred.Append({0, 1, 2, 3});
        resistances.Add(EBuffType::SpeedDown, 0.3);
        buffs.Add(EBuffType::PowerUp);
        skills.Add(ESkillType::StraightDamage);
        ai_behavior = EAIBehaviorType::Attack;
        targeting_priority = ETargetingPriority::LowestHP;
    }

};
