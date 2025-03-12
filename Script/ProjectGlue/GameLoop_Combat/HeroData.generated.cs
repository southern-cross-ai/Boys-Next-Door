using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.GameLoop_Combat;

/// <summary>
/// 定义英雄（NPC）结构体
/// </summary>
[UStruct, GeneratedType("HeroData", "UnrealSharp.GameLoop_Combat.HeroData")]
public partial struct FHeroData : MarshalledStruct<FHeroData>
{
    // npc_id
    
    static int npc_id_Offset;
    /// <summary>
    /// 基础属性
    /// </summary>
    public int npc_id;
    
    // name
    
    static int name_Offset;
    static IntPtr name_NativeProperty;
    /// <summary>
    /// NPC唯一标识符
    /// </summary>
    public string name;
    
    // type
    
    static int type_Offset;
    /// <summary>
    /// NPC名字
    /// </summary>
    public UnrealSharp.GameLoop_Combat.ENPCType type;
    
    // isEnemy
    
    static int isEnemy_Offset;
    /// <summary>
    /// NPC类型（枚举）
    /// </summary>
    public bool isEnemy;
    
    // rank
    
    static int rank_Offset;
    public int rank;
    
    // size
    
    static int size_Offset;
    /// <summary>
    /// 强度等级
    /// </summary>
    public int size;
    
    // hp
    
    static int hp_Offset;
    /// <summary>
    /// 战斗属性
    /// </summary>
    public int hp;
    
    // max_hp
    
    static int max_hp_Offset;
    /// <summary>
    /// 当前生命值
    /// </summary>
    public int max_hp;
    
    // stress
    
    static int stress_Offset;
    /// <summary>
    /// 最大生命值
    /// </summary>
    public int stress;
    
    // speed
    
    static int speed_Offset;
    /// <summary>
    /// 当前压力值
    /// </summary>
    public int speed;
    
    // accuracy
    
    static int accuracy_Offset;
    /// <summary>
    /// 速度
    /// </summary>
    public float accuracy;
    
    // dodge
    
    static int dodge_Offset;
    /// <summary>
    /// 命中率
    /// </summary>
    public float dodge;
    
    // critical
    
    static int critical_Offset;
    /// <summary>
    /// 闪避率
    /// </summary>
    public float critical;
    
    // protect
    
    static int protect_Offset;
    /// <summary>
    /// 暴击率
    /// </summary>
    public float protect;
    
    // resistances
    
    static int resistances_Offset;
    static IntPtr resistances_NativeProperty;
    static MapCopyMarshaller<UnrealSharp.GameLoop_Combat.EBuffType, int> resistances_Marshaller = null;
    /// <summary>
    /// 护甲
    /// </summary>
    public System.Collections.Generic.IDictionary<UnrealSharp.GameLoop_Combat.EBuffType, int> resistances;
    
    // damage_range
    
    static int damage_range_Offset;
    /// <summary>
    /// 异常状态抗性
    /// </summary>
    public int damage_range;
    
    // position_preferred
    
    static int position_preferred_Offset;
    static IntPtr position_preferred_NativeProperty;
    static ArrayCopyMarshaller<int> position_preferred_Marshaller = null;
    /// <summary>
    /// 基础伤害范围
    /// </summary>
    public System.Collections.Generic.IList<int> position_preferred;
    
    // position
    
    static int position_Offset;
    public int position;
    
    // stunned
    
    static int stunned_Offset;
    /// <summary>
    /// 状态属性
    /// </summary>
    public bool stunned;
    
    // marked
    
    static int marked_Offset;
    /// <summary>
    /// 是否被眩晕
    /// </summary>
    public bool marked;
    
    // bleed
    
    static int bleed_Offset;
    /// <summary>
    /// 是否被标记
    /// </summary>
    public UnrealSharp.CoreUObject.FIntPoint bleed;
    
    // blight
    
    static int blight_Offset;
    /// <summary>
    /// 流血状态（伤害、回合数）
    /// </summary>
    public UnrealSharp.CoreUObject.FIntPoint blight;
    
    // buffs
    
    static int buffs_Offset;
    static IntPtr buffs_NativeProperty;
    static ArrayCopyMarshaller<UnrealSharp.GameLoop_Combat.EBuffType> buffs_Marshaller = null;
    /// <summary>
    /// 毒素状态（伤害、回合数）
    /// </summary>
    public System.Collections.Generic.IList<UnrealSharp.GameLoop_Combat.EBuffType> buffs;
    
    // death_door
    
    static int death_door_Offset;
    /// <summary>
    /// 当前所有增益效果
    /// </summary>
    public bool death_door;
    
    // death_save_chance
    
    static int death_save_chance_Offset;
    /// <summary>
    /// 是否处于濒死状态
    /// </summary>
    public float death_save_chance;
    
    // skills
    
    static int skills_Offset;
    static IntPtr skills_NativeProperty;
    static ArrayCopyMarshaller<UnrealSharp.GameLoop_Combat.ESkillType> skills_Marshaller = null;
    /// <summary>
    /// 行为属性
    /// </summary>
    public System.Collections.Generic.IList<UnrealSharp.GameLoop_Combat.ESkillType> skills;
    
    // skill_cooldowns
    
    static int skill_cooldowns_Offset;
    static IntPtr skill_cooldowns_NativeProperty;
    static MapCopyMarshaller<UnrealSharp.GameLoop_Combat.ESkillType, int> skill_cooldowns_Marshaller = null;
    /// <summary>
    /// 技能列表
    /// </summary>
    public System.Collections.Generic.IDictionary<UnrealSharp.GameLoop_Combat.ESkillType, int> skill_cooldowns;
    
    // ai_behavior
    
    static int ai_behavior_Offset;
    /// <summary>
    /// 技能冷却
    /// </summary>
    public UnrealSharp.GameLoop_Combat.EAIBehaviorType ai_behavior;
    
    // extra_actions
    
    static int extra_actions_Offset;
    static IntPtr extra_actions_NativeProperty;
    static ArrayCopyMarshaller<int> extra_actions_Marshaller = null;
    /// <summary>
    /// AI行为模式
    /// </summary>
    public System.Collections.Generic.IList<int> extra_actions;
    
    // targeting_priority
    
    static int targeting_priority_Offset;
    /// <summary>
    /// 当前回合额外行动次数
    /// </summary>
    public UnrealSharp.GameLoop_Combat.ETargetingPriority targeting_priority;
    
    // dynamic_speed
    
    static int dynamic_speed_Offset;
    /// <summary>
    /// 动态参数
    /// </summary>
    public int dynamic_speed;
    
    // dynamic_critical
    
    static int dynamic_critical_Offset;
    /// <summary>
    /// 速度
    /// </summary>
    public int dynamic_critical;
    
    // dynamic_dodge
    
    static int dynamic_dodge_Offset;
    /// <summary>
    /// 速度
    /// </summary>
    public int dynamic_dodge;
    
    
    static readonly IntPtr NativeClassPtr;
    public static IntPtr GetNativeClassPtr() => NativeClassPtr;
    public static readonly int NativeDataSize;
    public static int GetNativeDataSize() => NativeDataSize;
    static FHeroData()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName(typeof(FHeroData).GetAssemblyName(), "UnrealSharp.GameLoop_Combat", "HeroData");
        IntPtr npc_id_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "npc_id");
        npc_id_Offset = FPropertyExporter.CallGetPropertyOffset(npc_id_NativeProperty);
        name_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "name");
        name_Offset = FPropertyExporter.CallGetPropertyOffset(name_NativeProperty);
        IntPtr type_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "type");
        type_Offset = FPropertyExporter.CallGetPropertyOffset(type_NativeProperty);
        IntPtr isEnemy_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "isEnemy");
        isEnemy_Offset = FPropertyExporter.CallGetPropertyOffset(isEnemy_NativeProperty);
        IntPtr rank_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "rank");
        rank_Offset = FPropertyExporter.CallGetPropertyOffset(rank_NativeProperty);
        IntPtr size_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "size");
        size_Offset = FPropertyExporter.CallGetPropertyOffset(size_NativeProperty);
        IntPtr hp_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "hp");
        hp_Offset = FPropertyExporter.CallGetPropertyOffset(hp_NativeProperty);
        IntPtr max_hp_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "max_hp");
        max_hp_Offset = FPropertyExporter.CallGetPropertyOffset(max_hp_NativeProperty);
        IntPtr stress_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "stress");
        stress_Offset = FPropertyExporter.CallGetPropertyOffset(stress_NativeProperty);
        IntPtr speed_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "speed");
        speed_Offset = FPropertyExporter.CallGetPropertyOffset(speed_NativeProperty);
        IntPtr accuracy_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "accuracy");
        accuracy_Offset = FPropertyExporter.CallGetPropertyOffset(accuracy_NativeProperty);
        IntPtr dodge_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "dodge");
        dodge_Offset = FPropertyExporter.CallGetPropertyOffset(dodge_NativeProperty);
        IntPtr critical_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "critical");
        critical_Offset = FPropertyExporter.CallGetPropertyOffset(critical_NativeProperty);
        IntPtr protect_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "protect");
        protect_Offset = FPropertyExporter.CallGetPropertyOffset(protect_NativeProperty);
        resistances_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "resistances");
        resistances_Offset = FPropertyExporter.CallGetPropertyOffset(resistances_NativeProperty);
        IntPtr damage_range_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "damage_range");
        damage_range_Offset = FPropertyExporter.CallGetPropertyOffset(damage_range_NativeProperty);
        position_preferred_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "position_preferred");
        position_preferred_Offset = FPropertyExporter.CallGetPropertyOffset(position_preferred_NativeProperty);
        IntPtr position_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "position");
        position_Offset = FPropertyExporter.CallGetPropertyOffset(position_NativeProperty);
        IntPtr stunned_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "stunned");
        stunned_Offset = FPropertyExporter.CallGetPropertyOffset(stunned_NativeProperty);
        IntPtr marked_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "marked");
        marked_Offset = FPropertyExporter.CallGetPropertyOffset(marked_NativeProperty);
        IntPtr bleed_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bleed");
        bleed_Offset = FPropertyExporter.CallGetPropertyOffset(bleed_NativeProperty);
        IntPtr blight_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "blight");
        blight_Offset = FPropertyExporter.CallGetPropertyOffset(blight_NativeProperty);
        buffs_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "buffs");
        buffs_Offset = FPropertyExporter.CallGetPropertyOffset(buffs_NativeProperty);
        IntPtr death_door_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "death_door");
        death_door_Offset = FPropertyExporter.CallGetPropertyOffset(death_door_NativeProperty);
        IntPtr death_save_chance_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "death_save_chance");
        death_save_chance_Offset = FPropertyExporter.CallGetPropertyOffset(death_save_chance_NativeProperty);
        skills_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "skills");
        skills_Offset = FPropertyExporter.CallGetPropertyOffset(skills_NativeProperty);
        skill_cooldowns_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "skill_cooldowns");
        skill_cooldowns_Offset = FPropertyExporter.CallGetPropertyOffset(skill_cooldowns_NativeProperty);
        IntPtr ai_behavior_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ai_behavior");
        ai_behavior_Offset = FPropertyExporter.CallGetPropertyOffset(ai_behavior_NativeProperty);
        extra_actions_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "extra_actions");
        extra_actions_Offset = FPropertyExporter.CallGetPropertyOffset(extra_actions_NativeProperty);
        IntPtr targeting_priority_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "targeting_priority");
        targeting_priority_Offset = FPropertyExporter.CallGetPropertyOffset(targeting_priority_NativeProperty);
        IntPtr dynamic_speed_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "dynamic_speed");
        dynamic_speed_Offset = FPropertyExporter.CallGetPropertyOffset(dynamic_speed_NativeProperty);
        IntPtr dynamic_critical_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "dynamic_critical");
        dynamic_critical_Offset = FPropertyExporter.CallGetPropertyOffset(dynamic_critical_NativeProperty);
        IntPtr dynamic_dodge_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "dynamic_dodge");
        dynamic_dodge_Offset = FPropertyExporter.CallGetPropertyOffset(dynamic_dodge_NativeProperty);
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    public FHeroData(IntPtr InNativeStruct)
    {
        unsafe
        {
            npc_id = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, npc_id_Offset), 0);
            IntPtr name_NativePtr = IntPtr.Add(InNativeStruct,name_Offset);
            name = StringMarshaller.FromNative(name_NativePtr,0);
            type = EnumMarshaller<UnrealSharp.GameLoop_Combat.ENPCType>.FromNative(IntPtr.Add(InNativeStruct, type_Offset), 0);
            isEnemy = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, isEnemy_Offset), 0);
            rank = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, rank_Offset), 0);
            size = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, size_Offset), 0);
            hp = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, hp_Offset), 0);
            max_hp = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, max_hp_Offset), 0);
            stress = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, stress_Offset), 0);
            speed = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, speed_Offset), 0);
            accuracy = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, accuracy_Offset), 0);
            dodge = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, dodge_Offset), 0);
            critical = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, critical_Offset), 0);
            protect = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, protect_Offset), 0);
            resistances_Marshaller ??= new MapCopyMarshaller<UnrealSharp.GameLoop_Combat.EBuffType, int>(resistances_NativeProperty, EnumMarshaller<UnrealSharp.GameLoop_Combat.EBuffType>.ToNative, EnumMarshaller<UnrealSharp.GameLoop_Combat.EBuffType>.FromNative, BlittableMarshaller<int>.ToNative, BlittableMarshaller<int>.FromNative);
            IntPtr resistances_NativeProperty_ParamsBuffer = IntPtr.Add(InNativeStruct, resistances_Offset);
            resistances = resistances_Marshaller.FromNative(InNativeStruct, 0);
            damage_range = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, damage_range_Offset), 0);
            position_preferred_Marshaller ??= new ArrayCopyMarshaller<int>(position_preferred_NativeProperty, BlittableMarshaller<int>.ToNative, BlittableMarshaller<int>.FromNative);
            IntPtr position_preferred_NativeBuffer = IntPtr.Add(InNativeStruct, position_preferred_Offset);
            position_preferred = position_preferred_Marshaller.FromNative(position_preferred_NativeBuffer, 0);
            position = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, position_Offset), 0);
            stunned = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, stunned_Offset), 0);
            marked = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, marked_Offset), 0);
            bleed = StructMarshaller<UnrealSharp.CoreUObject.FIntPoint>.FromNative(IntPtr.Add(InNativeStruct, bleed_Offset), 0);
            blight = StructMarshaller<UnrealSharp.CoreUObject.FIntPoint>.FromNative(IntPtr.Add(InNativeStruct, blight_Offset), 0);
            buffs_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.GameLoop_Combat.EBuffType>(buffs_NativeProperty, EnumMarshaller<UnrealSharp.GameLoop_Combat.EBuffType>.ToNative, EnumMarshaller<UnrealSharp.GameLoop_Combat.EBuffType>.FromNative);
            IntPtr buffs_NativeBuffer = IntPtr.Add(InNativeStruct, buffs_Offset);
            buffs = buffs_Marshaller.FromNative(buffs_NativeBuffer, 0);
            death_door = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, death_door_Offset), 0);
            death_save_chance = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, death_save_chance_Offset), 0);
            skills_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.GameLoop_Combat.ESkillType>(skills_NativeProperty, EnumMarshaller<UnrealSharp.GameLoop_Combat.ESkillType>.ToNative, EnumMarshaller<UnrealSharp.GameLoop_Combat.ESkillType>.FromNative);
            IntPtr skills_NativeBuffer = IntPtr.Add(InNativeStruct, skills_Offset);
            skills = skills_Marshaller.FromNative(skills_NativeBuffer, 0);
            skill_cooldowns_Marshaller ??= new MapCopyMarshaller<UnrealSharp.GameLoop_Combat.ESkillType, int>(skill_cooldowns_NativeProperty, EnumMarshaller<UnrealSharp.GameLoop_Combat.ESkillType>.ToNative, EnumMarshaller<UnrealSharp.GameLoop_Combat.ESkillType>.FromNative, BlittableMarshaller<int>.ToNative, BlittableMarshaller<int>.FromNative);
            IntPtr skill_cooldowns_NativeProperty_ParamsBuffer = IntPtr.Add(InNativeStruct, skill_cooldowns_Offset);
            skill_cooldowns = skill_cooldowns_Marshaller.FromNative(InNativeStruct, 0);
            ai_behavior = EnumMarshaller<UnrealSharp.GameLoop_Combat.EAIBehaviorType>.FromNative(IntPtr.Add(InNativeStruct, ai_behavior_Offset), 0);
            extra_actions_Marshaller ??= new ArrayCopyMarshaller<int>(extra_actions_NativeProperty, BlittableMarshaller<int>.ToNative, BlittableMarshaller<int>.FromNative);
            IntPtr extra_actions_NativeBuffer = IntPtr.Add(InNativeStruct, extra_actions_Offset);
            extra_actions = extra_actions_Marshaller.FromNative(extra_actions_NativeBuffer, 0);
            targeting_priority = EnumMarshaller<UnrealSharp.GameLoop_Combat.ETargetingPriority>.FromNative(IntPtr.Add(InNativeStruct, targeting_priority_Offset), 0);
            dynamic_speed = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, dynamic_speed_Offset), 0);
            dynamic_critical = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, dynamic_critical_Offset), 0);
            dynamic_dodge = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, dynamic_dodge_Offset), 0);
        }
    }
    
    public static FHeroData FromNative(IntPtr buffer) => new FHeroData(buffer);
    
    public void ToNative(IntPtr buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, npc_id_Offset), 0, npc_id);
            IntPtr name_NativePtr = IntPtr.Add(buffer, name_Offset);
            StringMarshaller.ToNative(name_NativePtr,0,name);
            EnumMarshaller<UnrealSharp.GameLoop_Combat.ENPCType>.ToNative(IntPtr.Add(buffer, type_Offset), 0, type);
            BoolMarshaller.ToNative(IntPtr.Add(buffer, isEnemy_Offset), 0, isEnemy);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, rank_Offset), 0, rank);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, size_Offset), 0, size);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, hp_Offset), 0, hp);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, max_hp_Offset), 0, max_hp);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, stress_Offset), 0, stress);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, speed_Offset), 0, speed);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(buffer, accuracy_Offset), 0, accuracy);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(buffer, dodge_Offset), 0, dodge);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(buffer, critical_Offset), 0, critical);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(buffer, protect_Offset), 0, protect);
            resistances_Marshaller ??= new MapCopyMarshaller<UnrealSharp.GameLoop_Combat.EBuffType, int>(resistances_NativeProperty, EnumMarshaller<UnrealSharp.GameLoop_Combat.EBuffType>.ToNative, EnumMarshaller<UnrealSharp.GameLoop_Combat.EBuffType>.FromNative, BlittableMarshaller<int>.ToNative, BlittableMarshaller<int>.FromNative);
            IntPtr resistances_NativeProperty_NativeBuffer = IntPtr.Add(buffer, resistances_Offset);
            resistances_Marshaller.ToNative(resistances_NativeProperty_NativeBuffer, 0, resistances);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, damage_range_Offset), 0, damage_range);
            position_preferred_Marshaller ??= new ArrayCopyMarshaller<int>(position_preferred_NativeProperty, BlittableMarshaller<int>.ToNative, BlittableMarshaller<int>.FromNative);
            IntPtr position_preferred_NativeBuffer = IntPtr.Add(buffer, position_preferred_Offset);
            position_preferred_Marshaller.ToNative(position_preferred_NativeBuffer, 0, position_preferred);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, position_Offset), 0, position);
            BoolMarshaller.ToNative(IntPtr.Add(buffer, stunned_Offset), 0, stunned);
            BoolMarshaller.ToNative(IntPtr.Add(buffer, marked_Offset), 0, marked);
            StructMarshaller<UnrealSharp.CoreUObject.FIntPoint>.ToNative(IntPtr.Add(buffer, bleed_Offset), 0, bleed);
            StructMarshaller<UnrealSharp.CoreUObject.FIntPoint>.ToNative(IntPtr.Add(buffer, blight_Offset), 0, blight);
            buffs_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.GameLoop_Combat.EBuffType>(buffs_NativeProperty, EnumMarshaller<UnrealSharp.GameLoop_Combat.EBuffType>.ToNative, EnumMarshaller<UnrealSharp.GameLoop_Combat.EBuffType>.FromNative);
            IntPtr buffs_NativeBuffer = IntPtr.Add(buffer, buffs_Offset);
            buffs_Marshaller.ToNative(buffs_NativeBuffer, 0, buffs);
            BoolMarshaller.ToNative(IntPtr.Add(buffer, death_door_Offset), 0, death_door);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(buffer, death_save_chance_Offset), 0, death_save_chance);
            skills_Marshaller ??= new ArrayCopyMarshaller<UnrealSharp.GameLoop_Combat.ESkillType>(skills_NativeProperty, EnumMarshaller<UnrealSharp.GameLoop_Combat.ESkillType>.ToNative, EnumMarshaller<UnrealSharp.GameLoop_Combat.ESkillType>.FromNative);
            IntPtr skills_NativeBuffer = IntPtr.Add(buffer, skills_Offset);
            skills_Marshaller.ToNative(skills_NativeBuffer, 0, skills);
            skill_cooldowns_Marshaller ??= new MapCopyMarshaller<UnrealSharp.GameLoop_Combat.ESkillType, int>(skill_cooldowns_NativeProperty, EnumMarshaller<UnrealSharp.GameLoop_Combat.ESkillType>.ToNative, EnumMarshaller<UnrealSharp.GameLoop_Combat.ESkillType>.FromNative, BlittableMarshaller<int>.ToNative, BlittableMarshaller<int>.FromNative);
            IntPtr skill_cooldowns_NativeProperty_NativeBuffer = IntPtr.Add(buffer, skill_cooldowns_Offset);
            skill_cooldowns_Marshaller.ToNative(skill_cooldowns_NativeProperty_NativeBuffer, 0, skill_cooldowns);
            EnumMarshaller<UnrealSharp.GameLoop_Combat.EAIBehaviorType>.ToNative(IntPtr.Add(buffer, ai_behavior_Offset), 0, ai_behavior);
            extra_actions_Marshaller ??= new ArrayCopyMarshaller<int>(extra_actions_NativeProperty, BlittableMarshaller<int>.ToNative, BlittableMarshaller<int>.FromNative);
            IntPtr extra_actions_NativeBuffer = IntPtr.Add(buffer, extra_actions_Offset);
            extra_actions_Marshaller.ToNative(extra_actions_NativeBuffer, 0, extra_actions);
            EnumMarshaller<UnrealSharp.GameLoop_Combat.ETargetingPriority>.ToNative(IntPtr.Add(buffer, targeting_priority_Offset), 0, targeting_priority);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, dynamic_speed_Offset), 0, dynamic_speed);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, dynamic_critical_Offset), 0, dynamic_critical);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(buffer, dynamic_dodge_Offset), 0, dynamic_dodge);
        }
    }
}

public static class FHeroDataMarshaller
{
    public static FHeroData FromNative(IntPtr nativeBuffer, int arrayIndex)
    {
        return new FHeroData(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, FHeroData obj)
    {
        obj.ToNative(nativeBuffer + (arrayIndex * GetNativeDataSize()));
    }
    
    public static int GetNativeDataSize()
    {
        return FHeroData.NativeDataSize;
    }
}