// Fill out your copyright notice in the Description page of Project Settings.

using System.IO;

using UnrealBuildTool;

public class BeCKEditor : ModuleRules
{
    public BeCKEditor(TargetInfo Target)
    {
        PublicIncludePaths.AddRange(
            new string[] {
                "BeCKEditor/Public"
            }
        );

        PrivateIncludePaths.AddRange(
            new string[] {
                "BeCKEditor/Private"
            }
        );

        string engine_path = Path.GetFullPath(BuildConfiguration.RelativeEnginePath);
        string srced_path = engine_path + "Source/Editor/";
        PublicIncludePaths.Add(srced_path + "GraphEditor/");
        PublicIncludePaths.Add(srced_path + "GraphEditor/Private/");
        PublicIncludePaths.Add(srced_path + "GraphEditor/Private/KismetPins");
        PublicIncludePaths.Add(srced_path + "GraphEditor/Public/");

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "BeCK",
                "Core",
                "Engine",
                "CoreUObject",
                "UnrealEd",
                "BlueprintGraph",
                "Kismet",
                "KismetWidgets",
                "KismetCompiler",
                "Slate",
                "SlateCore",
                "LevelEditor",
                "GraphEditor",
                "EditorStyle",
                "Paper2D"
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "AssetTools"
            }
        );
    }
}
