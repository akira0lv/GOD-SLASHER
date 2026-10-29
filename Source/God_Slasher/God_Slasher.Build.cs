// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class God_Slasher : ModuleRules
{
	public God_Slasher(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"God_Slasher",
			"God_Slasher/Variant_Platforming",
			"God_Slasher/Variant_Platforming/Animation",
			"God_Slasher/Variant_Combat",
			"God_Slasher/Variant_Combat/AI",
			"God_Slasher/Variant_Combat/Animation",
			"God_Slasher/Variant_Combat/Gameplay",
			"God_Slasher/Variant_Combat/Interfaces",
			"God_Slasher/Variant_Combat/UI",
			"God_Slasher/Variant_SideScrolling",
			"God_Slasher/Variant_SideScrolling/AI",
			"God_Slasher/Variant_SideScrolling/Gameplay",
			"God_Slasher/Variant_SideScrolling/Interfaces",
			"God_Slasher/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
