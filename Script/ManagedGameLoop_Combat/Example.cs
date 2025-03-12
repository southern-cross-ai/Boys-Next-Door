using UnrealSharp.Attributes;
using UnrealSharp.Engine;

namespace ManagedGameLoop_Combat;

[UClass]
public class AMyTestClass : AActor
{   
	[UProperty(PropertyFlags.BlueprintReadOnly)]
	public int MyInt { get; set; }

	protected override void BeginPlay()
	{
		PrintString("Hello from C#!");
		MyFunction(false, 1233);
		base.BeginPlay();
	}
	
	[UFunction(FunctionFlags.BlueprintCallable)]
	public void MyFunction(bool myBool, int MyInt)
	{
		PrintString(myBool + " " + MyInt);
		PrintString("Hello from MyFunction!");
	}
}
