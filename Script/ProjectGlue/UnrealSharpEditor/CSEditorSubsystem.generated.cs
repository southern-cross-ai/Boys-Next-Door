using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp.UnrealSharpEditor;

[UClass(ClassFlags.Abstract), GeneratedType("CSEditorSubsystem", "UnrealSharp.UnrealSharpEditor.CSEditorSubsystem")]
public partial class UCSEditorSubsystem : UnrealSharp.EditorSubsystem.UEditorSubsystem
{
    static readonly IntPtr NativeClassPtr;
    static UCSEditorSubsystem()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName(typeof(UCSEditorSubsystem).GetAssemblyName(), "UnrealSharp.UnrealSharpEditor", "CSEditorSubsystem");
        IntPtr K2_ShouldCreateSubsystem_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_ShouldCreateSubsystem");
        K2_ShouldCreateSubsystem_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_ShouldCreateSubsystem_NativeFunction);
        K2_ShouldCreateSubsystem_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_ShouldCreateSubsystem_NativeFunction, "ReturnValue");
    }
    // K2_ShouldCreateSubsystem
    IntPtr K2_ShouldCreateSubsystem_NativeFunction;
    static int K2_ShouldCreateSubsystem_ParamsSize;
    static int K2_ShouldCreateSubsystem_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_ShouldCreateSubsystem")]
    protected virtual bool ShouldCreateSubsystem()
    {
        unsafe
        {
            if (K2_ShouldCreateSubsystem_NativeFunction == IntPtr.Zero)
            {
                K2_ShouldCreateSubsystem_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_ShouldCreateSubsystem");
            }
            byte* ParamsBufferAllocation = stackalloc byte[K2_ShouldCreateSubsystem_ParamsSize];
            nint ParamsBuffer = (nint) ParamsBufferAllocation;
            UFunctionExporter.CallInitializeFunctionParams(K2_ShouldCreateSubsystem_NativeFunction, ParamsBuffer);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_ShouldCreateSubsystem_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, K2_ShouldCreateSubsystem_ReturnValue_Offset), 0);
            
            return returnValue;
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual bool ShouldCreateSubsystem_Implementation()
    {
        return default(bool);
    }
    void Invoke_K2_ShouldCreateSubsystem(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool returnValue = ShouldCreateSubsystem_Implementation();
            BoolMarshaller.ToNative(IntPtr.Add(returnBuffer, 0), 0, returnValue);
        }
    }
    
    // K2_Initialize
    IntPtr K2_Initialize_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_Initialize")]
    protected virtual void Initialize()
    {
        unsafe
        {
            if (K2_Initialize_NativeFunction == IntPtr.Zero)
            {
                K2_Initialize_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_Initialize");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_Initialize_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void Initialize_Implementation()
    {
    }
    void Invoke_K2_Initialize(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            Initialize_Implementation();
        }
    }
    
    // K2_Deinitialize
    IntPtr K2_Deinitialize_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent), GeneratedType("K2_Deinitialize")]
    protected virtual void Deinitialize()
    {
        unsafe
        {
            if (K2_Deinitialize_NativeFunction == IntPtr.Zero)
            {
                K2_Deinitialize_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "K2_Deinitialize");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_Deinitialize_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Hide implementation function from Intellisense
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void Deinitialize_Implementation()
    {
    }
    void Invoke_K2_Deinitialize(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            Deinitialize_Implementation();
        }
    }
    
    
}