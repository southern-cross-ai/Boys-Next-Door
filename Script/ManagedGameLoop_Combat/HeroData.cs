namespace ManagedGameLoop_Combat;

using System;
using System.Collections.Generic;

// 枚举类型示例（这些需要自己定义或引用现有的）
public enum NPCType { Beast, Human, Undead }
public enum BuffType { SpeedDown, PowerUp }
public enum SkillType { StraightDamage }
public enum AIBehaviorType { Attack, Defense, Cover }
public enum TargetingPriority { LowestHP, HighestHP }

// 状态点结构体（相当于FIntPoint）
public struct IntPoint
{
    public int X;
    public int Y;

    public IntPoint(int x, int y)
    {
        X = x;
        Y = y;
    }
}

// 英雄（NPC）数据类
public class HeroData
{
    // 基础属性
    public int NpcId { get; set; }                       // NPC唯一标识符
    public string Name { get; set; }                    // NPC名字
    public NPCType Type { get; set; }                   // NPC类型（枚举）
    public bool IsEnemy { get; set; }                   // 是否敌方
    public int Rank { get; set; }                       // 强度等级
    public int Size { get; set; }                       // 占用站位格数

    // 战斗属性
    public int Hp { get; set; }                         // 当前生命值
    public int MaxHp { get; set; }                      // 最大生命值
    public int Stress { get; set; }                     // 当前压力值
    public int Speed { get; set; }                      // 基础速度
    public float Accuracy { get; set; }                 // 命中率
    public float Dodge { get; set; }                    // 闪避率
    public float Critical { get; set; }                 // 暴击率
    public float Protect { get; set; }                  // 护甲
    public Dictionary<BuffType, float> Resistances { get; set; } // 异常状态抗性
    public int DamageRange { get; set; }                // 基础伤害范围
    public List<int> PositionPreferred { get; set; }    // 偏好站位
    public int Position { get; set; }                   // 当前站位

    // 状态属性
    public bool Stunned { get; set; }                   // 是否被眩晕
    public bool Marked { get; set; }                    // 是否被标记
    public IntPoint Bleed { get; set; }                 // 流血状态（伤害、回合数）
    public IntPoint Blight { get; set; }                // 毒素状态（伤害、回合数）
    public List<BuffType> Buffs { get; set; }           // 当前所有增益效果
    public bool DeathDoor { get; set; }                 // 是否处于濒死状态
    public float DeathSaveChance { get; set; }          // 濒死状态下的生存几率

    // 行为属性
    public List<SkillType> Skills { get; set; }         // 技能列表
    public Dictionary<SkillType, int> SkillCooldowns { get; set; } // 技能冷却
    public AIBehaviorType AiBehavior { get; set; }      // AI行为模式
    public List<int> ExtraActions { get; set; }         // 当前回合额外行动次数
    public TargetingPriority TargetingPriority { get; set; } // 攻击目标优先级

    // 动态参数
    public int DynamicSpeed { get; set; }               // 动态速度
    public int DynamicCritical { get; set; }            // 动态暴击
    public int DynamicDodge { get; set; }               // 动态闪避

    // 默认构造函数
    public HeroData()
    {
        NpcId = 0;
        Name = "Unnamed Hero";
        Type = NPCType.Beast;
        IsEnemy = false;
        Rank = 1;
        Size = 1;

        Hp = 100;
        MaxHp = 100;
        Stress = 0;
        Speed = 5;
        Accuracy = 0.8f;
        Dodge = 0.15f;
        Critical = 0.1f;
        Protect = 0.2f;
        DamageRange = 10;
        Position = 1;

        Stunned = false;
        Marked = false;
        Bleed = new IntPoint(0, 0);
        Blight = new IntPoint(0, 0);
        DeathDoor = false;
        DeathSaveChance = 0.0f;

        PositionPreferred = new List<int> { 0, 1, 2, 3 };
        Resistances = new Dictionary<BuffType, float> { { BuffType.SpeedDown, 0.3f } };
        Buffs = new List<BuffType> { BuffType.PowerUp };
        Skills = new List<SkillType> { SkillType.StraightDamage };
        SkillCooldowns = new Dictionary<SkillType, int>();
        AiBehavior = AIBehaviorType.Attack;
        ExtraActions = new List<int>();
        TargetingPriority = TargetingPriority.LowestHP;
    }

    // 带参数构造函数
    public HeroData(string name, int npcId, int speed, bool isEnemy)
    {
        NpcId = npcId;
        Name = name;
        Type = NPCType.Beast;
        Rank = 1;
        Size = 1;

        Hp = 100;
        MaxHp = 100;
        Stress = 0;
        Speed = speed;
        Accuracy = 0.8f;
        Dodge = 0.15f;
        Critical = 0.1f;
        Protect = 0.2f;
        DamageRange = 10;
        Position = 1;

        Stunned = false;
        Marked = false;
        Bleed = new IntPoint(0, 0);
        Blight = new IntPoint(0, 0);
        DeathDoor = false;
        DeathSaveChance = 0.0f;

        PositionPreferred = new List<int> { 0, 1, 2, 3 };
        Resistances = new Dictionary<BuffType, float> { { BuffType.SpeedDown, 0.3f } };
        Buffs = new List<BuffType> { BuffType.PowerUp };
        Skills = new List<SkillType> { SkillType.StraightDamage };
        SkillCooldowns = new Dictionary<SkillType, int>();
        AiBehavior = AIBehaviorType.Attack;
        ExtraActions = new List<int>();
        TargetingPriority = TargetingPriority.LowestHP;
    }
}
