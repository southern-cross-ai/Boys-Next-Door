using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.GameLoop_Combat;

[UClass, GeneratedType("A_BattleManager", "UnrealSharp.GameLoop_Combat.A_BattleManager")]
public partial class AA_BattleManager : UnrealSharp.Engine.AActor
{
    static readonly IntPtr NativeClassPtr;
    static AA_BattleManager()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName(typeof(AA_BattleManager).GetAssemblyName(), "UnrealSharp.GameLoop_Combat", "A_BattleManager");
        EntityDataList_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "EntityDataList");
        EntityDataList_Offset = FPropertyExporter.CallGetPropertyOffset(EntityDataList_NativeProperty);
        IntPtr iCurrentRound_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "iCurrentRound");
        iCurrentRound_Offset = FPropertyExporter.CallGetPropertyOffset(iCurrentRound_NativeProperty);
        IntPtr eBattleStageType_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "eBattleStageType");
        eBattleStageType_Offset = FPropertyExporter.CallGetPropertyOffset(eBattleStageType_NativeProperty);
        IntPtr fWaitTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "fWaitTime");
        fWaitTime_Offset = FPropertyExporter.CallGetPropertyOffset(fWaitTime_NativeProperty);
        IntPtr fCurrentStageTime_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "fCurrentStageTime");
        fCurrentStageTime_Offset = FPropertyExporter.CallGetPropertyOffset(fCurrentStageTime_NativeProperty);
        IntPtr bHasProceedCurrentStage_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bHasProceedCurrentStage");
        bHasProceedCurrentStage_Offset = FPropertyExporter.CallGetPropertyOffset(bHasProceedCurrentStage_NativeProperty);
    }
    
    static int EntityDataList_Offset;
    static IntPtr EntityDataList_NativeProperty;
    ArrayMarshaller<UnrealSharp.GameLoop_Combat.FHeroData> EntityDataList_Marshaller = null;
    
    public System.Collections.Generic.IList<UnrealSharp.GameLoop_Combat.FHeroData> EntityDataList
    {
        get
        {
            EntityDataList_Marshaller ??= new ArrayMarshaller<UnrealSharp.GameLoop_Combat.FHeroData>(EntityDataList_NativeProperty, StructMarshaller<UnrealSharp.GameLoop_Combat.FHeroData>.ToNative, StructMarshaller<UnrealSharp.GameLoop_Combat.FHeroData>.FromNative);
            return EntityDataList_Marshaller.FromNative(IntPtr.Add(NativeObject, EntityDataList_Offset), 0);
        }
    }
    
    
    static int iCurrentRound_Offset;
    
    /// <summary>
    /// UPROPERTY(EditAnywhere)
    /// TArray<FHeroData&> PositionMap;
    /// </summary>
    public int iCurrentRound
    {
        get
        {
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, iCurrentRound_Offset), 0);
        }
        set
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, iCurrentRound_Offset), 0, value);
        }
    }
    
    
    static int eBattleStageType_Offset;
    
    public UnrealSharp.GameLoop_Combat.BattleStageType eBattleStageType
    {
        get
        {
            return EnumMarshaller<UnrealSharp.GameLoop_Combat.BattleStageType>.FromNative(IntPtr.Add(NativeObject, eBattleStageType_Offset), 0);
        }
        set
        {
            EnumMarshaller<UnrealSharp.GameLoop_Combat.BattleStageType>.ToNative(IntPtr.Add(NativeObject, eBattleStageType_Offset), 0, value);
        }
    }
    
    
    static int fWaitTime_Offset;
    
    public float fWaitTime
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, fWaitTime_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, fWaitTime_Offset), 0, value);
        }
    }
    
    
    static int fCurrentStageTime_Offset;
    
    public float fCurrentStageTime
    {
        get
        {
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, fCurrentStageTime_Offset), 0);
        }
        set
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, fCurrentStageTime_Offset), 0, value);
        }
    }
    
    
    static int bHasProceedCurrentStage_Offset;
    
    public bool HasProceedCurrentStage
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bHasProceedCurrentStage_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bHasProceedCurrentStage_Offset), 0, value);
        }
    }
    
    
}