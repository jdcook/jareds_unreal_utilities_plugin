using System.IO;
using UnrealBuildTool;

public class FCUtilities : ModuleRules
{
	public FCUtilities(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		PrivateDependencyModuleNames.AddRange(new string[] {"Core", "CoreUObject", "Engine", "PhysicsCore" });
	}
}