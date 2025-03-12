using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.UnrealSharpEditor;

[UClass, GeneratedType("CSUnrealSharpEditorSettings", "UnrealSharp.UnrealSharpEditor.CSUnrealSharpEditorSettings")]
public partial class UCSUnrealSharpEditorSettings : UnrealSharp.DeveloperSettings.UDeveloperSettings
{
    static readonly IntPtr NativeClassPtr;
    static UCSUnrealSharpEditorSettings()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName(typeof(UCSUnrealSharpEditorSettings).GetAssemblyName(), "UnrealSharp.UnrealSharpEditor", "CSUnrealSharpEditorSettings");
        IntPtr AutomaticHotReloading_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "AutomaticHotReloading");
        AutomaticHotReloading_Offset = FPropertyExporter.CallGetPropertyOffset(AutomaticHotReloading_NativeProperty);
        IntPtr bSuffixGeneratedTypes_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSuffixGeneratedTypes");
        bSuffixGeneratedTypes_Offset = FPropertyExporter.CallGetPropertyOffset(bSuffixGeneratedTypes_NativeProperty);
    }
    
    static int AutomaticHotReloading_Offset;
    
    /// <summary>
    /// Whether Hot Reload should automatically start on script save, gaining Editor focus, or not at all.
    /// </summary>
    public UnrealSharp.UnrealSharpEditor.EAutomaticHotReloadMethod AutomaticHotReloading
    {
        get
        {
            return EnumMarshaller<UnrealSharp.UnrealSharpEditor.EAutomaticHotReloadMethod>.FromNative(IntPtr.Add(NativeObject, AutomaticHotReloading_Offset), 0);
        }
        set
        {
            EnumMarshaller<UnrealSharp.UnrealSharpEditor.EAutomaticHotReloadMethod>.ToNative(IntPtr.Add(NativeObject, AutomaticHotReloading_Offset), 0, value);
        }
    }
    
    
    static int bSuffixGeneratedTypes_Offset;
    
    /// <summary>
    /// Should we suffix generated types' DisplayName with "TypeName (C#)"?
    /// Needs restart to take effect.
    /// </summary>
    public bool SuffixGeneratedTypes
    {
        get
        {
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bSuffixGeneratedTypes_Offset), 0);
        }
        set
        {
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bSuffixGeneratedTypes_Offset), 0, value);
        }
    }
    
    
}