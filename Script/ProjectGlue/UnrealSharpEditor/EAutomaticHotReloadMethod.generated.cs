using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.UnrealSharpEditor;

[UEnum, GeneratedType("EAutomaticHotReloadMethod", "UnrealSharp.UnrealSharpEditor.EAutomaticHotReloadMethod")]
public enum EAutomaticHotReloadMethod : byte
{
    /// <summary>
    /// Automatically Hot Reloads when script changes are saved
    /// </summary>
    OnScriptSave = 0,
    /// <summary>
    /// Automatically Hot Reloads when the built .NET modules changed (build the C# project in your IDE and UnrealSharp will automatically reload)
    /// </summary>
    OnModuleChange = 1,
    /// <summary>
    /// Wait for the Editor to gain focus before Hot Reloading
    /// </summary>
    OnEditorFocus = 2,
    /// <summary>
    /// Will not Hot Reload automatically
    /// </summary>
    Off = 3,
}